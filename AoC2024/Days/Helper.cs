using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2024.Days
{
    public static class Helper
    {
        public static string GetInputDirectory( string fileName )
        {
            return Path.Combine( AppDomain.CurrentDomain.BaseDirectory, "Inputs", fileName );
        }
    }
}
