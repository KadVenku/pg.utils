using pg.util.enumerations;

namespace pg.util
{
    public sealed class FileTypeUtility
    {
        public static PetroglyphFileType GetPetroglyphFileTypeByExtension(string extension)
        {
            extension = extension.ToUpper();
            switch (extension)
            {
                default:
                    return PetroglyphFileType.BINARY;
            }
        }
    }
}
