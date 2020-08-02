using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace Lab11
{
    public static class Encoder
    {
        public static bool TryEncode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }
            byte[] bytes = new byte[input.Length];
            List<byte> bytesEncoded = new List<byte>();
            input.Read(bytes, 0, bytes.Length);
            byte countingByte = bytes[0];
            byte count = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                if (count == 255)
                {
                    bytesEncoded.Add(count);
                    bytesEncoded.Add(countingByte);
                    count = 0;
                    countingByte = bytes[i];
                    count++;
                    continue;
                }
                if (countingByte != bytes[i])
                {
                    bytesEncoded.Add(count);
                    bytesEncoded.Add(countingByte);
                    countingByte = bytes[i];
                    count = 0;
                }
                count++;
            }
            bytesEncoded.Add(count);
            bytesEncoded.Add(countingByte);
            bytes = bytesEncoded.ToArray();
            output.Write(bytes, 0, bytes.Length);
            return true;
        }

        public static bool TryDecode(Stream input, Stream output)
        {
            if (input.Length == 0)
            {
                return false;
            }
            byte[] bytes = new byte[input.Length];
            List<byte> bytesDecoded = new List<byte>();
            input.Read(bytes, 0, bytes.Length);

            for (int i = 0; i < bytes.Length; i = i + 2)
            {
                for (int j = 0; j < bytes[i]; j++)
                {
                    bytesDecoded.Add(bytes[i + 1]);
                }
            }
            bytes = bytesDecoded.ToArray();
            output.Write(bytes, 0, bytes.Length);
            return true;
        }
    }
}
