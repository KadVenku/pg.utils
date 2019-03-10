using System;

namespace pg.util
{
    public static class ChecksumUtility
    {
        private static readonly ulong[] LOOKUP_TABLE = new ulong[256];

        static ChecksumUtility()
        {
            InitTable();
        }

        private static void InitTable()
        {
            for (int i = 0; i < 256; i++)
            {
                uint crc = (uint)i;
                for (int j = 0; j < 8; j++)
                {
                    crc = ((crc & 1) != 0) ? (crc >> 1) ^ 0xEDB88320 : (crc >> 1);
                }
                LOOKUP_TABLE[i] = crc & 0xFFFFFFFF;
            }
        }

        public static uint GetChecksum(string val)
        {
            return ComputeCrc32(val);
        }

        private static uint ComputeCrc32(string s)
        {
            ulong crc = 0xFFFFFFFF;
            for (int j = 0; j < s.Length; j++)
            {
                crc = ((crc >> 8) & 0x00FFFFFF) ^ LOOKUP_TABLE[(crc ^ (s)[j]) & 0xFF];
            }
            return Convert.ToUInt32(crc ^ 0xFFFFFFFF);
        }

        public static byte[] GetBytes(string v)
        {
            return BitConverter.GetBytes(ComputeCrc32(v));
        }
    }
}
