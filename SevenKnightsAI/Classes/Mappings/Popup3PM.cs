using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SevenKnightsAI.Classes.Mappings
{
    class Popup3PM
    {

        /* Special Quest Popup */
        public static readonly PixelMapping QuestCharacterPic = new PixelMapping
        {
            X = 477,
            Y = 457,
            Color = 11954701,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestPoint1 = new PixelMapping
        {
            X = 449,
            Y = 71,
            Color = 16774626,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestPoint2 = new PixelMapping //Pentagon Card
        {
            X = 203,
            Y = 351,
            Color = 2520750,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping QuestRedCrossButton = new PixelMapping
        {
            X = 799,
            Y = 75,
            Color = 13188876,
            Type = MappingType.BOTH
        };

        /* Package Shop */
        public static readonly PixelMapping EventPackPoint1 = new PixelMapping
        {
            X = 77,
            Y = 50,
            Color = 7551756,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EventPackPoint2 = new PixelMapping
        {
            X = 943,
            Y = 45,
            Color = 8078095,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping EventPackCloseBtn = new PixelMapping
        {
            X = 983,
            Y = 52,
            Color = 12925963,
            Type = MappingType.BOTH
        };

    }
}
