using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OrderTestListGenerator
{
    public static class TestIdGenerator
    {

        private static HashAlgorithm hashAlgo = new SHA1CryptoServiceProvider();

        public static Guid getGuidFromString(string data)
        {
            byte[] hash = hashAlgo.ComputeHash(System.Text.Encoding.Unicode.GetBytes(data));
            byte[] toGuid = new byte[16];
            Array.Copy(hash, toGuid, 16);
            return new Guid(toGuid);
        }
    }
}
