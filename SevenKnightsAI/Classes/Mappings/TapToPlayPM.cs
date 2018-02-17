using System;

namespace SevenKnightsAI.Classes.Mappings
{
    internal static class TapToPlayPM
    {
        #region Public Fields

        public static readonly PixelMapping Point1 = new PixelMapping 
        {
            X = 164,
            Y = 84,
            Color = 16652821,
            Type = MappingType.ANCHOR
        };

        public static readonly PixelMapping TapArea = new PixelMapping
        {
            X = 519,
            Y = 542,
            Color = 0,
            Type = MappingType.BUTTON
        };

        #endregion Public Fields
    }
}