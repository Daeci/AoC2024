using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoC2024.Days
{
    public static class Day1
    {
        /*
         * Given a text file of 2 columns of numbers, sort each column from smallest to largest
         * then map each index to each other and determine the difference and add all
         * the differences up to get the final result.
         */
        public static int FirstPuzzle()
        {
            StreamReader reader = new StreamReader( Helper.GetInputDirectory( "day1.txt" ) );

            List<int> leftNumbers = new List<int>();
            List<int> rightNumbers = new List<int>();
            string line;
            while( ( line = reader.ReadLine() ) != null )
            {
                string noSpaceLine = Regex.Replace( line, @"\s+", "," );
                string[] numbers = noSpaceLine.Split( ',' );
                leftNumbers.Add( int.Parse( numbers[ 0 ] ) );
                rightNumbers.Add( int.Parse( numbers[ 1 ] ) );
            }

            leftNumbers.Sort();
            rightNumbers.Sort();

            int totalCount = 0;
            for( int i = 0; i < leftNumbers.Count; i++ )
            {
                totalCount += Math.Abs( leftNumbers[ i ] - rightNumbers[ i ] );
            }

            return totalCount;
        }

        /*
         * Find all instances of numbers in the right column that equal each index in the
         * left column. Multiply that amount of instances with the left column number and
         * add all the results up.
         */
        public static int SecondPuzzle()
        {
            StreamReader reader = new StreamReader( Helper.GetInputDirectory( "day1.txt" ) );

            List<int> leftNumbers = new List<int>();
            List<int> rightNumbers = new List<int>();
            string line;
            while( ( line = reader.ReadLine() ) != null )
            {
                string noSpaceLine = Regex.Replace( line, @"\s+", "," );
                string[] numbers = noSpaceLine.Split( ',' );
                leftNumbers.Add( int.Parse( numbers[ 0 ] ) );
                rightNumbers.Add( int.Parse( numbers[ 1 ] ) );
            }

            leftNumbers.Sort();
            rightNumbers.Sort();

            int totalCount = 0;
            for( int i = 0; i < leftNumbers.Count; i++ )
            {
                totalCount += rightNumbers.FindAll(
                    delegate( int num )
                    {
                        return num == leftNumbers[ i ];
                    }
                ).Count * leftNumbers[ i ];
            }

            return totalCount;
        }
    }
}
