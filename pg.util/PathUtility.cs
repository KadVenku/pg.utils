using System;
using System.IO;

namespace pg.util
{
    public sealed class PathUtility
    {
        public static bool CreatePath(string path)
        {
            path = Path.GetFullPath(path);
            if (!IsValidDirectoryPath(path))
            {
                return false;
            }

            try
            {
                Directory.CreateDirectory(path);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public static bool IsValidFilePath(string path)
        {
            return ValidateFilePath(path, true, true);
        }

        public static bool IsValidDirectoryPath(string path)
        {
            return ValidateFilePath(path, false);
        }

        private static bool ValidateFilePath(string path, bool includeFileName, bool requireFileName = false)
        {
            if (string.IsNullOrEmpty(path))
            {
                return false;
            }

            string root;
            string directory;
            string filename = null;
            try
            {
                path = Path.GetFullPath(path);
                root = Path.GetPathRoot(path);
                directory = Path.GetDirectoryName(path);
                if (includeFileName)
                {
                    filename = Path.GetFileName(path);
                }
            }
            catch (Exception)
            {
                return false;
            }

            if (string.IsNullOrEmpty(root))
            {
                return false;
            }

            if (string.IsNullOrEmpty(directory))
            {
                return false;
            }

            if (!requireFileName) return true;
            if (string.IsNullOrEmpty(filename))
            {
                return false;
            }

            return filename.IndexOfAny(Path.GetInvalidFileNameChars()) < 0;
        }
    }
}
