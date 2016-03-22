using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamonds
{
    class DiamondMaker
    {
        public List<string> MakeDiamond(char middleLetter)
        {
            //if(middleLetter == 'A')
            //    return new List<string>() { "A" };

            //else if (middleLetter == 'B')
            //    return new List<string>() { " A ", "B B", " A " };

            //else
            //{
                List<string> diamond = new List<string>();

                int midIndex = (int)middleLetter - 64;
                int lineCount = (midIndex) * 2 - 1;

                for (int i = 0; i < lineCount; i++)
                {
                    var letterCode = midIndex - Math.Abs(midIndex - i - 1) + 64;
                    var letterIndex = letterCode - 64;
                    var letter = ((char)letterCode).ToString();
                    var betweenSpace = (letterIndex - 1)*2 - 1;

                    string lineMiddle;
                    if (betweenSpace <= 0) //letter is A
                        lineMiddle = letter;
                    else
                        lineMiddle = letter + "".PadRight(betweenSpace) + letter;

                    var line = lineMiddle.PadLeft(midIndex + (betweenSpace + 1)/2).PadRight(lineCount);
                                      
                    diamond.Add(line);
                }

                return diamond;
            //}
        }
    }
}
