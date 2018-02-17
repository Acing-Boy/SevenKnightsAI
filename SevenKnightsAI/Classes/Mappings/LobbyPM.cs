using System;
using System.Drawing;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class LobbyPM
    {
        #region Public Fields

        public static readonly PixelMapping StatusBoard = new PixelMapping //evan hair
        {
            X = 74,
            Y = 217,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping MasteryButton = new PixelMapping
        {
            X = 324,
            Y = 104,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping Mastery_1 = new PixelMapping
        {
            X = 396,
            Y = 152,
            Color = 15782941,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_2 = new PixelMapping
        {
            X = 399,
            Y = 162,
            Color = 15454237,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping Mastery_3 = new PixelMapping
        {
            X = 400,
            Y = 159,
            Color = 16769568,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping AdventureButton = new PixelMapping
        {
            X = 947,
            Y = 553,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping BattleButton = new PixelMapping
        {
            X = 717,
            Y = 497,
            Color = 6235918,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping CostumeButton = new PixelMapping
        {
            X = 508,
            Y = 487,
            Color = 3093560,
            Type = MappingType.BUTTON
        };

        public static readonly int GOLD_OFFSET_X = 0;

        public static readonly int GOLD_OFFSET_Y = 0;

        public static readonly PixelMapping GuildButton = new PixelMapping
        {
            X = 318,
            Y = 540,
            Color = 14277571,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping HeroButton = new PixelMapping
        {
            X = 51,
            Y = 531,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int HONOR_OFFSET_X = 0;

        public static readonly int HONOR_OFFSET_Y = 0;

        public static readonly PixelMapping InboxAvailable = new PixelMapping
        {
            X = 893,
            Y = 29,
            Color = 12920833,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping InboxButton = new PixelMapping
        {
            X = 910,
            Y = 47,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int KEY_OFFSET_X = 0;

        public static readonly int KEY_OFFSET_Y = 0;

        public static readonly PixelMapping MenuButtonYellowLeft = new PixelMapping //Chest
        {
            X = 821,
            Y = 39,
            Color = 11631152,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping MenuButtonYellowRight = new PixelMapping //Chest
        {
            X = 865,
            Y = 64,
            Color = 8803614,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestAvailable = new PixelMapping
        {
            X = 93,
            Y = 451,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestButton = new PixelMapping
        {
            X = 140,
            Y = 543,
            Color = 0,
            Type = MappingType.BUTTON
        };

        //public static readonly int RUBY_OFFSET_X = 10;
        public static readonly int RUBY_OFFSET_X = 0;

        public static readonly int RUBY_OFFSET_Y = 0;

        public static readonly PixelMapping RudysGiftButton = new PixelMapping
        {
            X = 910,
            Y = 402,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping ShopButton = new PixelMapping
        {
            X = 785,
            Y = 537,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly PixelMapping SocialAvailable = new PixelMapping
        {
            X = 177,
            Y = 450,
            Color = 13051905,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping SocialButton = new PixelMapping
        {
            X = 233,
            Y = 533,
            Color = 0,
            Type = MappingType.BUTTON
        };

        public static readonly int TOPAZ_OFFSET_X = 0;

        public static readonly int TOPAZ_OFFSET_Y = 0;

        public static readonly Rectangle OwnerLocation = new Rectangle
        {
            X = 209,
            Y = 168,
            Width = 200,
            Height = 30
        };

        /* Exploration */

        public static readonly PixelMapping ExplorationAvailable1 = new PixelMapping
        {
            X = 930,
            Y = 338,
            Color = 10911333,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ExplorationAvailable2 = new PixelMapping
        {
            X = 890,
            Y = 346,
            Color = 12880701,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping ExplorationLobbyButton = new PixelMapping
        {
            X = 890,
            Y = 346,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}