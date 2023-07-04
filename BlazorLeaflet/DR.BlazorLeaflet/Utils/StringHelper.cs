using System;
using System.Linq;

namespace DR.BlazorLeaflet.Utils
{
    public class StringHelper
    {

        private static readonly Random _random = new Random();

        public static string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

    }
}
