using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMagicConsoleApp
{
    static class TranslateDevMagic
    {
        public static String GetString(this String word)
        {
            String result = word;

            return result.ToLower();
        }
    }
}
