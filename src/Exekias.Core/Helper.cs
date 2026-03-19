using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;

namespace Exekias.Core
{
    public static class Utils
    {
        public static string ComputeSHA256(string path)
        {
            if (path == null) throw new ArgumentNullException(nameof(path));

            using var sha = SHA256.Create();
            using var stream = File.OpenRead(path);
            var hash = sha.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "");
        }
    }
}