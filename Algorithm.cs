using System;
using System.Collections.Generic;
using System.Text;

namespace Horspool_s_Algorithm
{
    public class Algorithm
    {
        public long[] ShiftTable(string pattern)
        {
            var patternToArray = pattern.ToCharArray();

            var patternASCII = Encoding.ASCII.GetBytes(pattern);
            long patternLength = patternASCII.LongLength;

            var table = new long[256];

            for (int i = 0; i < 256; i++)
            {
                table[i] = patternLength;

                for (int j = 0; j < patternLength - 1; j++)
                {
                    table[patternASCII[j]] = patternLength - 1 - j;
                }
            }

            return table;
        }

        public long Horspool(string text, string pattern)
        {
            var textASCII = Encoding.ASCII.GetBytes(text);
            var patternASCII = Encoding.ASCII.GetBytes(pattern);

            long textLength = textASCII.LongLength;
            long patternLength = patternASCII.LongLength;

            long[] shift_table = ShiftTable(pattern);

            long index = patternLength - 1;
            while(index <= textLength - 1)
            {
                int k = 0;

                while(k <= patternLength - 1 && patternASCII[patternLength - 1 - k] == textASCII[index - k])
                {
                    k = k + 1;
                }

                if (k == patternLength)
                    return index - patternLength + 1;
                else
                    index = index + shift_table[textASCII[index]];
            }

            return -1;
        }
    }
}
