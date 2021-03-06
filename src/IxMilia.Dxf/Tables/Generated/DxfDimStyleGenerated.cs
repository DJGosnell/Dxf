// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System.Linq;
using System.Collections.Generic;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Sections;
using IxMilia.Dxf.Tables;

namespace IxMilia.Dxf
{
    public partial class DxfDimStyle : DxfSymbolTableFlags
    {
        internal const string AcDbText = "AcDbDimStyleTableRecord";

        protected override DxfTableType TableType { get { return DxfTableType.DimStyle; } }

        public string DimensioningSuffix { get; set; }
        public string AlternateDimensioningSuffix { get; set; }
        public string ArrowBlockName { get; set; }
        public string FirstArrowBlockName { get; set; }
        public string SecondArrowBlockName { get; set; }
        public double DimensioningScaleFactor { get; set; }
        public double DimensioningArrowSize { get; set; }
        public double DimensionExtensionLineOffset { get; set; }
        public double DimensionLineIncrement { get; set; }
        public double DimensionExtensionLineExtension { get; set; }
        public double DimensionDistanceRoundingValue { get; set; }
        public double DimensionLineExtension { get; set; }
        public double DimensionPlusTolerance { get; set; }
        public double DimensionMinusTolerance { get; set; }
        public bool GenerateDimensionTolerances { get; set; }
        public bool GenerateDimensionLimits { get; set; }
        public bool DimensionTextInsideHorizontal { get; set; }
        public bool DimensionTextOutsideHorizontal { get; set; }
        public bool SuppressFirstDimensionExtensionLine { get; set; }
        public bool SuppressSecondDimensionExtensionLine { get; set; }
        public bool TextAboveDimensionLine { get; set; }
        public DxfUnitZeroSuppression DimensionUnitZeroSuppression { get; set; }
        public DxfUnitZeroSuppression DimensionAngleZeroSuppression { get; set; }
        public double DimensioningTextHeight { get; set; }
        public double CenterMarkSize { get; set; }
        public double DimensioningTickSize { get; set; }
        public double AlternateDimensioningScaleFactor { get; set; }
        public double DimensionLinearMeasurementScaleFactor { get; set; }
        public double DimensionVerticalTextPosition { get; set; }
        public double DimensionToleranceDisplaceScaleFactor { get; set; }
        public double DimensionLineGap { get; set; }
        public double AlternateDimensioningUnitRounding { get; set; }
        public bool UseAlternateDimensioning { get; set; }
        public short AlternateDimensioningDecimalPlaces { get; set; }
        public bool ForceDimensionLineExtensionsOutsideIfTextExists { get; set; }
        public bool UseSeparateArrowBlocksForDimensions { get; set; }
        public bool ForceDimensionTextInsideExtensions { get; set; }
        public bool SuppressOutsideExtensionDimensionLines { get; set; }
        public DxfColor DimensionLineColor { get; set; }
        public DxfColor DimensionExtensionLineColor { get; set; }
        public DxfColor DimensionTextColor { get; set; }
        public short AngularDimensionPrecision { get; set; }
        public DxfUnitFormat DimensionUnitFormat { get; set; }
        public short DimensionUnitToleranceDecimalPlaces { get; set; }
        public short DimensionToleranceDecimalPlaces { get; set; }
        public DxfUnitFormat AlternateDimensioningUnits { get; set; }
        public short AlternateDimensioningToleranceDecimalPlaces { get; set; }
        public DxfAngleFormat DimensioningAngleFormat { get; set; }
        public DxfDimensionFractionFormat DimensionFractionFormat { get; set; }
        public DxfNonAngularUnits DimensionNonAngularUnits { get; set; }
        public char DimensionDecimalSeparatorChar { get; set; }
        public DxfDimensionTextMovementRule DimensionTextMovementRule { get; set; }
        public DxfDimensionTextJustification DimensionTextJustification { get; set; }
        public DxfJustification DimensionToleranceVerticalJustification { get; set; }
        public DxfUnitZeroSuppression DimensionToleranceZeroSuppression { get; set; }
        public DxfUnitZeroSuppression AlternateDimensioningZeroSupression { get; set; }
        public DxfUnitZeroSuppression AlternateDimensioningToleranceZeroSupression { get; set; }
        public DxfDimensionFit DimensionTextAndArrowPlacement { get; set; }
        public bool DimensionCursorControlsTextPosition { get; set; }
        public string DimensionTextStyle { get; set; }
        public string DimensionLeaderBlockName { get; set; }
        public DxfLineWeight DimensionLineWeight { get; set; }
        public DxfLineWeight DimensionExtensionLineWeight { get; set; }

        public DxfXData XData { get; set; }

        public DxfDimStyle()
            : base()
        {
            DimensioningSuffix = null;
            AlternateDimensioningSuffix = null;
            ArrowBlockName = null;
            FirstArrowBlockName = null;
            SecondArrowBlockName = null;
            DimensioningScaleFactor = 1.0;
            DimensioningArrowSize = 0.18;
            DimensionExtensionLineOffset = 0.0625;
            DimensionLineIncrement = 0.38;
            DimensionExtensionLineExtension = 0.18;
            DimensionDistanceRoundingValue = 0.0;
            DimensionLineExtension = 0.0;
            DimensionPlusTolerance = 0.0;
            DimensionMinusTolerance = 0.0;
            GenerateDimensionTolerances = false;
            GenerateDimensionLimits = false;
            DimensionTextInsideHorizontal = true;
            DimensionTextOutsideHorizontal = true;
            SuppressFirstDimensionExtensionLine = false;
            SuppressSecondDimensionExtensionLine = false;
            TextAboveDimensionLine = false;
            DimensionUnitZeroSuppression = DxfUnitZeroSuppression.SuppressZeroFeetAndZeroInches;
            DimensionAngleZeroSuppression = DxfUnitZeroSuppression.SuppressZeroFeetAndZeroInches;
            DimensioningTextHeight = 0.18;
            CenterMarkSize = 0.09;
            DimensioningTickSize = 0.0;
            AlternateDimensioningScaleFactor = 25.4;
            DimensionLinearMeasurementScaleFactor = 1.0;
            DimensionVerticalTextPosition = 0.0;
            DimensionToleranceDisplaceScaleFactor = 1.0;
            DimensionLineGap = 0.09;
            AlternateDimensioningUnitRounding = 0.0;
            UseAlternateDimensioning = false;
            AlternateDimensioningDecimalPlaces = 2;
            ForceDimensionLineExtensionsOutsideIfTextExists = false;
            UseSeparateArrowBlocksForDimensions = false;
            ForceDimensionTextInsideExtensions = false;
            SuppressOutsideExtensionDimensionLines = false;
            DimensionLineColor = null;
            DimensionExtensionLineColor = null;
            DimensionTextColor = null;
            AngularDimensionPrecision = 0;
            DimensionUnitFormat = DxfUnitFormat.Scientific;
            DimensionUnitToleranceDecimalPlaces = 0;
            DimensionToleranceDecimalPlaces = 0;
            AlternateDimensioningUnits = DxfUnitFormat.Scientific;
            AlternateDimensioningToleranceDecimalPlaces = 0;
            DimensioningAngleFormat = DxfAngleFormat.DecimalDegrees;
            DimensionFractionFormat = DxfDimensionFractionFormat.HorizontalStacking;
            DimensionNonAngularUnits = DxfNonAngularUnits.Scientific;
            DimensionDecimalSeparatorChar = '.';
            DimensionTextMovementRule = DxfDimensionTextMovementRule.MoveLineWithText;
            DimensionTextJustification = DxfDimensionTextJustification.AboveLineCenter;
            SuppressFirstDimensionExtensionLine = false;
            SuppressSecondDimensionExtensionLine = false;
            DimensionToleranceVerticalJustification = DxfJustification.Top;
            DimensionToleranceZeroSuppression = DxfUnitZeroSuppression.SuppressZeroFeetAndZeroInches;
            AlternateDimensioningZeroSupression = DxfUnitZeroSuppression.SuppressZeroFeetAndZeroInches;
            AlternateDimensioningToleranceZeroSupression = DxfUnitZeroSuppression.SuppressZeroFeetAndZeroInches;
            DimensionTextAndArrowPlacement = DxfDimensionFit.TextAndArrowsOutsideLines;
            DimensionCursorControlsTextPosition = true;
            DimensionTextAndArrowPlacement = DxfDimensionFit.TextAndArrowsOutsideLines;
            DimensionTextStyle = null;
            DimensionLeaderBlockName = null;
            ArrowBlockName = null;
            FirstArrowBlockName = null;
            SecondArrowBlockName = null;
            DimensionLineWeight = new DxfLineWeight();
            DimensionExtensionLineWeight = new DxfLineWeight();
        }

        internal override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(100, AcDbText));
            }

            pairs.Add(new DxfCodePair(2, Name));
            pairs.Add(new DxfCodePair(70, (short)StandardFlags));
            pairs.Add(new DxfCodePair(3, (DimensioningSuffix)));
            pairs.Add(new DxfCodePair(4, (AlternateDimensioningSuffix)));
            if (version <= DxfAcadVersion.R14)
            {
                pairs.Add(new DxfCodePair(5, (ArrowBlockName)));
            }

            if (version <= DxfAcadVersion.R14)
            {
                pairs.Add(new DxfCodePair(6, (FirstArrowBlockName)));
            }

            if (version <= DxfAcadVersion.R14)
            {
                pairs.Add(new DxfCodePair(7, (SecondArrowBlockName)));
            }

            pairs.Add(new DxfCodePair(40, (DimensioningScaleFactor)));
            pairs.Add(new DxfCodePair(41, (DimensioningArrowSize)));
            pairs.Add(new DxfCodePair(42, (DimensionExtensionLineOffset)));
            pairs.Add(new DxfCodePair(43, (DimensionLineIncrement)));
            pairs.Add(new DxfCodePair(44, (DimensionExtensionLineExtension)));
            pairs.Add(new DxfCodePair(45, (DimensionDistanceRoundingValue)));
            pairs.Add(new DxfCodePair(46, (DimensionLineExtension)));
            pairs.Add(new DxfCodePair(47, (DimensionPlusTolerance)));
            pairs.Add(new DxfCodePair(48, (DimensionMinusTolerance)));
            pairs.Add(new DxfCodePair(71, BoolShort(GenerateDimensionTolerances)));
            pairs.Add(new DxfCodePair(72, BoolShort(GenerateDimensionLimits)));
            pairs.Add(new DxfCodePair(73, BoolShort(DimensionTextInsideHorizontal)));
            pairs.Add(new DxfCodePair(74, BoolShort(DimensionTextOutsideHorizontal)));
            pairs.Add(new DxfCodePair(75, BoolShort(SuppressFirstDimensionExtensionLine)));
            pairs.Add(new DxfCodePair(76, BoolShort(SuppressSecondDimensionExtensionLine)));
            pairs.Add(new DxfCodePair(77, BoolShort(TextAboveDimensionLine)));
            pairs.Add(new DxfCodePair(78, (short)(DimensionUnitZeroSuppression)));
            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(79, (short)(DimensionAngleZeroSuppression)));
            }

            pairs.Add(new DxfCodePair(140, (DimensioningTextHeight)));
            pairs.Add(new DxfCodePair(141, (CenterMarkSize)));
            pairs.Add(new DxfCodePair(142, (DimensioningTickSize)));
            pairs.Add(new DxfCodePair(143, (AlternateDimensioningScaleFactor)));
            pairs.Add(new DxfCodePair(144, (DimensionLinearMeasurementScaleFactor)));
            pairs.Add(new DxfCodePair(145, (DimensionVerticalTextPosition)));
            pairs.Add(new DxfCodePair(146, (DimensionToleranceDisplaceScaleFactor)));
            pairs.Add(new DxfCodePair(147, (DimensionLineGap)));
            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(148, (AlternateDimensioningUnitRounding)));
            }

            pairs.Add(new DxfCodePair(170, BoolShort(UseAlternateDimensioning)));
            pairs.Add(new DxfCodePair(171, (AlternateDimensioningDecimalPlaces)));
            pairs.Add(new DxfCodePair(172, BoolShort(ForceDimensionLineExtensionsOutsideIfTextExists)));
            pairs.Add(new DxfCodePair(173, BoolShort(UseSeparateArrowBlocksForDimensions)));
            pairs.Add(new DxfCodePair(174, BoolShort(ForceDimensionTextInsideExtensions)));
            pairs.Add(new DxfCodePair(175, BoolShort(SuppressOutsideExtensionDimensionLines)));
            pairs.Add(new DxfCodePair(176, DxfColor.GetRawValue(DimensionLineColor)));
            pairs.Add(new DxfCodePair(177, DxfColor.GetRawValue(DimensionExtensionLineColor)));
            pairs.Add(new DxfCodePair(178, DxfColor.GetRawValue(DimensionTextColor)));
            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(179, (AngularDimensionPrecision)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(270, (short)(DimensionUnitFormat)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(271, (DimensionUnitToleranceDecimalPlaces)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(272, (DimensionToleranceDecimalPlaces)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(273, (short)(AlternateDimensioningUnits)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(274, (AlternateDimensioningToleranceDecimalPlaces)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(275, (short)(DimensioningAngleFormat)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(276, (short)(DimensionFractionFormat)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(277, (short)(DimensionNonAngularUnits)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(278, (short)(DimensionDecimalSeparatorChar)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(279, (short)(DimensionTextMovementRule)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(280, (short)(DimensionTextJustification)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(281, BoolShort(SuppressFirstDimensionExtensionLine)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(282, BoolShort(SuppressSecondDimensionExtensionLine)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(283, (short)(DimensionToleranceVerticalJustification)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(284, (short)(DimensionToleranceZeroSuppression)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(285, (short)(AlternateDimensioningZeroSupression)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(286, (short)(AlternateDimensioningToleranceZeroSupression)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(287, (short)(DimensionTextAndArrowPlacement)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(288, BoolShort(DimensionCursorControlsTextPosition)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(289, (short)(DimensionTextAndArrowPlacement)));
            }

            if (version >= DxfAcadVersion.R13)
            {
                pairs.Add(new DxfCodePair(340, (DimensionTextStyle)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(341, (DimensionLeaderBlockName)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(342, (ArrowBlockName)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(343, (FirstArrowBlockName)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(344, (SecondArrowBlockName)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(371, DxfLineWeight.GetRawValue(DimensionLineWeight)));
            }

            if (version >= DxfAcadVersion.R2000)
            {
                pairs.Add(new DxfCodePair(372, DxfLineWeight.GetRawValue(DimensionExtensionLineWeight)));
            }

            if (XData != null)
            {
                XData.AddValuePairs(pairs, version, outputHandles);
            }
        }

        internal static DxfDimStyle FromBuffer(DxfCodePairBufferReader buffer)
        {
            var item = new DxfDimStyle();
            while (buffer.ItemsRemain)
            {
                var pair = buffer.Peek();
                if (pair.Code == 0)
                {
                    break;
                }

                buffer.Advance();
                switch (pair.Code)
                {
                    case 70:
                        item.StandardFlags = (int)pair.ShortValue;
                        break;
                    case DxfCodePairGroup.GroupCodeNumber:
                        var groupName = DxfCodePairGroup.GetGroupName(pair.StringValue);
                        item.ExtensionDataGroups.Add(DxfCodePairGroup.FromBuffer(buffer, groupName));
                        break;
                    case 3:
                        item.DimensioningSuffix = (pair.StringValue);
                        break;
                    case 4:
                        item.AlternateDimensioningSuffix = (pair.StringValue);
                        break;
                    case 5:
                        item.ArrowBlockName = (pair.StringValue);
                        break;
                    case 6:
                        item.FirstArrowBlockName = (pair.StringValue);
                        break;
                    case 7:
                        item.SecondArrowBlockName = (pair.StringValue);
                        break;
                    case 40:
                        item.DimensioningScaleFactor = (pair.DoubleValue);
                        break;
                    case 41:
                        item.DimensioningArrowSize = (pair.DoubleValue);
                        break;
                    case 42:
                        item.DimensionExtensionLineOffset = (pair.DoubleValue);
                        break;
                    case 43:
                        item.DimensionLineIncrement = (pair.DoubleValue);
                        break;
                    case 44:
                        item.DimensionExtensionLineExtension = (pair.DoubleValue);
                        break;
                    case 45:
                        item.DimensionDistanceRoundingValue = (pair.DoubleValue);
                        break;
                    case 46:
                        item.DimensionLineExtension = (pair.DoubleValue);
                        break;
                    case 47:
                        item.DimensionPlusTolerance = (pair.DoubleValue);
                        break;
                    case 48:
                        item.DimensionMinusTolerance = (pair.DoubleValue);
                        break;
                    case 71:
                        item.GenerateDimensionTolerances = BoolShort(pair.ShortValue);
                        break;
                    case 72:
                        item.GenerateDimensionLimits = BoolShort(pair.ShortValue);
                        break;
                    case 73:
                        item.DimensionTextInsideHorizontal = BoolShort(pair.ShortValue);
                        break;
                    case 74:
                        item.DimensionTextOutsideHorizontal = BoolShort(pair.ShortValue);
                        break;
                    case 75:
                        item.SuppressFirstDimensionExtensionLine = BoolShort(pair.ShortValue);
                        break;
                    case 76:
                        item.SuppressSecondDimensionExtensionLine = BoolShort(pair.ShortValue);
                        break;
                    case 77:
                        item.TextAboveDimensionLine = BoolShort(pair.ShortValue);
                        break;
                    case 78:
                        item.DimensionUnitZeroSuppression = (DxfUnitZeroSuppression)(pair.ShortValue);
                        break;
                    case 79:
                        item.DimensionAngleZeroSuppression = (DxfUnitZeroSuppression)(pair.ShortValue);
                        break;
                    case 140:
                        item.DimensioningTextHeight = (pair.DoubleValue);
                        break;
                    case 141:
                        item.CenterMarkSize = (pair.DoubleValue);
                        break;
                    case 142:
                        item.DimensioningTickSize = (pair.DoubleValue);
                        break;
                    case 143:
                        item.AlternateDimensioningScaleFactor = (pair.DoubleValue);
                        break;
                    case 144:
                        item.DimensionLinearMeasurementScaleFactor = (pair.DoubleValue);
                        break;
                    case 145:
                        item.DimensionVerticalTextPosition = (pair.DoubleValue);
                        break;
                    case 146:
                        item.DimensionToleranceDisplaceScaleFactor = (pair.DoubleValue);
                        break;
                    case 147:
                        item.DimensionLineGap = (pair.DoubleValue);
                        break;
                    case 148:
                        item.AlternateDimensioningUnitRounding = (pair.DoubleValue);
                        break;
                    case 170:
                        item.UseAlternateDimensioning = BoolShort(pair.ShortValue);
                        break;
                    case 171:
                        item.AlternateDimensioningDecimalPlaces = (pair.ShortValue);
                        break;
                    case 172:
                        item.ForceDimensionLineExtensionsOutsideIfTextExists = BoolShort(pair.ShortValue);
                        break;
                    case 173:
                        item.UseSeparateArrowBlocksForDimensions = BoolShort(pair.ShortValue);
                        break;
                    case 174:
                        item.ForceDimensionTextInsideExtensions = BoolShort(pair.ShortValue);
                        break;
                    case 175:
                        item.SuppressOutsideExtensionDimensionLines = BoolShort(pair.ShortValue);
                        break;
                    case 176:
                        item.DimensionLineColor = DxfColor.FromRawValue(pair.ShortValue);
                        break;
                    case 177:
                        item.DimensionExtensionLineColor = DxfColor.FromRawValue(pair.ShortValue);
                        break;
                    case 178:
                        item.DimensionTextColor = DxfColor.FromRawValue(pair.ShortValue);
                        break;
                    case 179:
                        item.AngularDimensionPrecision = (pair.ShortValue);
                        break;
                    case 270:
                        item.DimensionUnitFormat = (DxfUnitFormat)(pair.ShortValue);
                        break;
                    case 271:
                        item.DimensionUnitToleranceDecimalPlaces = (pair.ShortValue);
                        break;
                    case 272:
                        item.DimensionToleranceDecimalPlaces = (pair.ShortValue);
                        break;
                    case 273:
                        item.AlternateDimensioningUnits = (DxfUnitFormat)(pair.ShortValue);
                        break;
                    case 274:
                        item.AlternateDimensioningToleranceDecimalPlaces = (pair.ShortValue);
                        break;
                    case 275:
                        item.DimensioningAngleFormat = (DxfAngleFormat)(pair.ShortValue);
                        break;
                    case 276:
                        item.DimensionFractionFormat = (DxfDimensionFractionFormat)(pair.ShortValue);
                        break;
                    case 277:
                        item.DimensionNonAngularUnits = (DxfNonAngularUnits)(pair.ShortValue);
                        break;
                    case 278:
                        item.DimensionDecimalSeparatorChar = (char)(pair.ShortValue);
                        break;
                    case 279:
                        item.DimensionTextMovementRule = (DxfDimensionTextMovementRule)(pair.ShortValue);
                        break;
                    case 280:
                        item.DimensionTextJustification = (DxfDimensionTextJustification)(pair.ShortValue);
                        break;
                    case 281:
                        item.SuppressFirstDimensionExtensionLine = BoolShort(pair.ShortValue);
                        break;
                    case 282:
                        item.SuppressSecondDimensionExtensionLine = BoolShort(pair.ShortValue);
                        break;
                    case 283:
                        item.DimensionToleranceVerticalJustification = (DxfJustification)(pair.ShortValue);
                        break;
                    case 284:
                        item.DimensionToleranceZeroSuppression = (DxfUnitZeroSuppression)(pair.ShortValue);
                        break;
                    case 285:
                        item.AlternateDimensioningZeroSupression = (DxfUnitZeroSuppression)(pair.ShortValue);
                        break;
                    case 286:
                        item.AlternateDimensioningToleranceZeroSupression = (DxfUnitZeroSuppression)(pair.ShortValue);
                        break;
                    case 287:
                        item.DimensionTextAndArrowPlacement = (DxfDimensionFit)(pair.ShortValue);
                        break;
                    case 288:
                        item.DimensionCursorControlsTextPosition = BoolShort(pair.ShortValue);
                        break;
                    case 289:
                        item.DimensionTextAndArrowPlacement = (DxfDimensionFit)(pair.ShortValue);
                        break;
                    case 340:
                        item.DimensionTextStyle = (pair.StringValue);
                        break;
                    case 341:
                        item.DimensionLeaderBlockName = (pair.StringValue);
                        break;
                    case 342:
                        item.ArrowBlockName = (pair.StringValue);
                        break;
                    case 343:
                        item.FirstArrowBlockName = (pair.StringValue);
                        break;
                    case 344:
                        item.SecondArrowBlockName = (pair.StringValue);
                        break;
                    case 371:
                        item.DimensionLineWeight = DxfLineWeight.FromRawValue(pair.ShortValue);
                        break;
                    case 372:
                        item.DimensionExtensionLineWeight = DxfLineWeight.FromRawValue(pair.ShortValue);
                        break;
                    case (int)DxfXDataType.ApplicationName:
                        item.XData = DxfXData.FromBuffer(buffer, pair.StringValue);
                        break;
                    default:
                        item.TrySetPair(pair);
                        break;
                }
            }

            return item;
        }
    }
}
