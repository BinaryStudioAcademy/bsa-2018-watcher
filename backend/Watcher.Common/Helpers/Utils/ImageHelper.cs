namespace Watcher.Common.Helpers.Utils
{
    using System.Collections.Generic;

    using System.Collections.ObjectModel;

    public static class ImageHelper
    {
        public static ReadOnlyDictionary<string, string> ImageFormats { get; }

        static ImageHelper()
        {
            ImageFormats = new ReadOnlyDictionary<string, string>(
                new Dictionary<string, string>(4)
                    {
                        { "image/png", "png" },
                        { "image/jpeg", "jpg" },
                        { "image/gif", "gif" },
                        { "image/tiff", "tiff" },
                        { "image/ico", "ico" }
                    });
        }

    }
}