﻿using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class AdventureModesPM
    {
        #region Public Fields

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 254,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BorderBottomRight = new PixelMapping
        {
            X = 296,
            Y = 229,
            Color = 13880002,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping BorderTopLeft = new PixelMapping
        {
            X = 151,
            Y = 211,
            Color = 9185593,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping CelestialTowerButton = new PixelMapping
        {
            X = 704,
            Y = 200,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SpecialDungeonButton = new PixelMapping
        {
            X = 268,
            Y = 209,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 355;
        public static readonly int GOLD_OFFSET_Y = 0;
        public static readonly int KEY_OFFSET_X = 350;
        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping KeyIcon = new PixelMapping
        {
            X = 404,
            Y = 22,
            Color = 13649463,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping GoldPlusIcon = new PixelMapping
        {
            X = 676,
            Y = 20,
            Color = 16774327,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping RaidButton = new PixelMapping
        {
            X = 704,
            Y = 460,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int RUBY_OFFSET_X = 364;
        public static readonly int RUBY_OFFSET_Y = 0;

        #endregion Public Fields
    }
}