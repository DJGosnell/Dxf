﻿// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using IxMilia.Dxf.Blocks;
using IxMilia.Dxf.Entities;
using IxMilia.Dxf.Sections;

namespace IxMilia.Dxf
{
    public class DxfFile
    {
        public const string BinarySentinel = "AutoCAD Binary DXF";
        public const string EofText = "EOF";

        internal DxfHeaderSection HeaderSection { get; private set; }
        internal DxfClassesSection ClassSection { get; private set; }
        internal DxfTablesSection TablesSection { get; private set; }
        internal DxfBlocksSection BlocksSection { get; private set; }
        internal DxfEntitiesSection EntitiesSection { get; private set; }
        internal DxfObjectsSection ObjectsSection { get; private set; }
        internal DxfThumbnailImageSection ThumbnailImageSection { get; private set; }

        public List<DxfEntity> Entities { get { return EntitiesSection.Entities; } }

        public List<DxfClass> Classes { get { return ClassSection.Classes; } }

        public List<DxfBlock> Blocks { get { return BlocksSection.Blocks; } }

        public DxfHeader Header { get { return HeaderSection.Header; } }

        public List<DxfLayer> Layers { get { return TablesSection.LayerTable.Items; } }

        public List<DxfViewPort> ViewPorts { get { return TablesSection.ViewPortTable.Items; } }

        public List<DxfDimStyle> DimensionStyles { get { return TablesSection.DimStyleTable.Items; } }

        public List<DxfView> Views { get { return TablesSection.ViewTable.Items; } }

        public List<DxfUcs> UserCoordinateSystems { get { return TablesSection.UcsTable.Items; } }

        public List<DxfAppId> ApplicationIds { get { return TablesSection.AppIdTable.Items; } }

        public List<DxfBlockRecord> BlockRecords { get { return TablesSection.BlockRecordTable.Items; } }

        public List<DxfLineType> Linetypes { get { return TablesSection.LTypeTable.Items; } }

        public List<DxfStyle> Styles { get { return TablesSection.StyleTable.Items; } }

        /// <summary>
        /// Gets the thumbnail bitmap.
        /// </summary>
        /// <returns>Raw bytes that should serialize to a .BMP file.</returns>
        public byte[] GetThumbnailBitmap()
        {
            return ThumbnailImageSection == null ? null : ThumbnailImageSection.GetThumbnailBitmap();
        }

        /// <summary>
        /// Sets the bitmap thumbnail.
        /// </summary>
        /// <param name="thumbnail">Raw data of the thumbnail image.  Should be a 256-color bitmap, 180 pixels wide, any height.</param>
        public void SetThumbnailBitmap(byte[] thumbnail)
        {
            if (ThumbnailImageSection == null)
                ThumbnailImageSection = new DxfThumbnailImageSection();
            ThumbnailImageSection.SetThumbnailBitmap(thumbnail);
        }

        /// <summary>
        /// Raw data of the thumbnail image.  Should be a 256-color bitmap, 180 pixels wide, any height.
        /// </summary>
        public byte[] RawThumbnail
        {
            get { return ThumbnailImageSection == null ? null : ThumbnailImageSection.RawData; }
            set
            {
                if (value == null)
                {
                    ThumbnailImageSection = null;
                }
                else
                {
                    if (ThumbnailImageSection == null)
                        ThumbnailImageSection = new DxfThumbnailImageSection();
                    ThumbnailImageSection.RawData = value;
                }
            }
        }

        internal IEnumerable<DxfSection> Sections
        {
            get
            {
                yield return this.HeaderSection;
                if (Header.Version >= DxfAcadVersion.R13)
                {
                    yield return this.ClassSection;
                }

                yield return this.TablesSection;
                yield return this.BlocksSection;
                yield return this.EntitiesSection;
                if (Header.Version >= DxfAcadVersion.R13)
                {
                    yield return this.ObjectsSection;
                }

                if (Header.Version >= DxfAcadVersion.R2000 && this.ThumbnailImageSection != null)
                {
                    yield return this.ThumbnailImageSection;
                }
            }
        }

        public DxfFile()
        {
            this.HeaderSection = new DxfHeaderSection();
            this.ClassSection = new DxfClassesSection();
            this.TablesSection = new DxfTablesSection();
            this.BlocksSection = new DxfBlocksSection();
            this.EntitiesSection = new DxfEntitiesSection();
            this.ObjectsSection = new DxfObjectsSection();
            this.ThumbnailImageSection = null; // not always present
        }

        public static DxfFile Load(Stream stream)
        {
            var file = new DxfFile();
            var reader = new DxfReader(stream);
            var buffer = new DxfCodePairBufferReader(reader.ReadCodePairs());
            var version = DxfAcadVersion.R14;
            while (buffer.ItemsRemain)
            {
                var pair = buffer.Peek();
                if (DxfCodePair.IsSectionStart(pair))
                {
                    buffer.Advance(); // swallow (0, SECTION) pair
                    var section = DxfSection.FromBuffer(buffer, version);
                    if (section != null)
                    {
                        switch (section.Type)
                        {
                            case DxfSectionType.Blocks:
                                file.BlocksSection = (DxfBlocksSection)section;
                                break;
                            case DxfSectionType.Entities:
                                file.EntitiesSection = (DxfEntitiesSection)section;
                                break;
                            case DxfSectionType.Classes:
                                file.ClassSection = (DxfClassesSection)section;
                                break;
                            case DxfSectionType.Header:
                                file.HeaderSection = (DxfHeaderSection)section;
                                version = file.Header.Version;
                                break;
                            case DxfSectionType.Tables:
                                file.TablesSection = (DxfTablesSection)section;
                                break;
                            case DxfSectionType.Thumbnail:
                                file.ThumbnailImageSection = (DxfThumbnailImageSection)section;
                                break;
                        }
                    }
                }
                else if (DxfCodePair.IsEof(pair))
                {
                    // swallow and quit
                    buffer.Advance();
                    break;
                }
                else if (DxfCodePair.IsComment(pair))
                {
                    // swallow comments
                    buffer.Advance();
                }
                else
                {
                    // swallow unexpected code pair
                    buffer.Advance();
                }
            }

            Debug.Assert(!buffer.ItemsRemain);
            file.SetHandles();

            return file;
        }

        public void Save(Stream stream, bool asText = true)
        {
            WriteStream(stream, asText);
        }

        private void WriteStream(Stream stream, bool asText)
        {
            var writer = new DxfWriter(stream, asText);
            writer.Open();

            var nextHandle = SetHandles();
            Header.NextAvailableHandle = nextHandle;

            // write sections
            var outputHandles = Header.Version >= DxfAcadVersion.R13 || Header.HandlesEnabled; // handles are always enabled on R13+
            foreach (var section in Sections)
            {
                foreach (var pair in section.GetValuePairs(Header.Version, outputHandles))
                    writer.WriteCodeValuePair(pair);
            }

            writer.Close();
        }

        private IEnumerable<IDxfHasHandle> HandleItems
        {
            get
            {
                return this.TablesSection.GetTables(Header.Version).Cast<IDxfHasHandle>()
                    .Concat(this.ApplicationIds.Cast<IDxfHasHandle>())
                    .Concat(this.BlockRecords.Cast<IDxfHasHandle>())
                    .Concat(this.Blocks.Cast<IDxfHasHandle>())
                    .Concat(this.DimensionStyles.Cast<IDxfHasHandle>())
                    .Concat(this.Entities.Cast<IDxfHasHandle>())
                    .Concat(this.Layers.Cast<IDxfHasHandle>())
                    .Concat(this.Linetypes.Cast<IDxfHasHandle>())
                    .Concat(this.Styles.Cast<IDxfHasHandle>())
                    .Concat(this.UserCoordinateSystems.Cast<IDxfHasHandle>())
                    .Concat(this.ViewPorts.Cast<IDxfHasHandle>())
                    .Concat(this.Views.Cast<IDxfHasHandle>());
            }
        }

        private uint SetHandles()
        {
            uint largestHandle = 0u;

            foreach (var item in HandleItems)
            {
                largestHandle = Math.Max(largestHandle, item.Handle);
                var parent = item as IDxfHasEntityChildren;
                if (parent != null)
                {
                    foreach (var child in parent.GetChildren())
                    {
                        largestHandle = Math.Max(largestHandle, child.Handle);
                    }
                }
            }

            var nextHandle = largestHandle + 1;

            foreach (var item in HandleItems)
            {
                if (item.Handle == 0u)
                {
                    item.Handle = nextHandle++;
                }

                var parent = item as IDxfHasEntityChildren;
                if (parent != null)
                {
                    foreach (var child in parent.GetChildren())
                    {
                        child.OwnerHandle = item.Handle;
                        if (child.Handle == 0u)
                        {
                            child.Handle = nextHandle++;
                        }
                    }
                }
            }

            return nextHandle;
        }
    }
}