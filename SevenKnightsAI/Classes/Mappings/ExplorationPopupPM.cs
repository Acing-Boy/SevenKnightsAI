using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class ExplorationPopupPM
    {
        public static readonly PixelMapping PopupPoint1 = new PixelMapping
        {
            X = 394,
            Y = 140,
            Color = 16758803,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping PopupPoint2 = new PixelMapping
        {
            X = 756,
            Y = 357,
            Color = 7163949,
            Type = MappingType.ANCHOR
        };
        public static readonly PixelMapping Reward1 = new PixelMapping
        {
            X = 684,
            Y = 186,
            Color = 13930755,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward2 = new PixelMapping
        {
            X = 682,
            Y = 253,
            Color = 15052547,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward3 = new PixelMapping
        {
            X = 684,
            Y = 305,
            Color = 14722307,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward4 = new PixelMapping
        {
            X = 687,
            Y = 356,
            Color = 14326275,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping Reward1Collected = new PixelMapping
        {
            X = 683,
            Y = 201,
            Color = 3022336,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward2Collected = new PixelMapping
        {
            X = 690,
            Y = 240,
            Color = 4073985,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward3Collected = new PixelMapping
        {
            X = 691,
            Y = 297,
            Color = 4073985,
            Type = MappingType.BOTH
        };
        public static readonly PixelMapping Reward4Collected = new PixelMapping
        {
            X = 686,
            Y = 353,
            Color = 4073985,
            Type = MappingType.BOTH
        };

        public static readonly PixelMapping ClosButton = new PixelMapping
        {
            X = 733,
            Y = 133,
            Color = 0,
            Type = MappingType.BUTTON
        };
    }
}
