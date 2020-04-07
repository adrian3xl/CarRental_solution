
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JobApp
{
   public static class Utils
    {

    
        public static string HashedPassword(string password)
        {
            SHA256 sha = SHA256.Create();


            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[1].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        
    }
}