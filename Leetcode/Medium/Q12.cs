using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Medium
{
    public class Q12 : IQ<string>
    {
        public int input = 58;
        List<KeyValuePair<char, int>> maps = new List<KeyValuePair<char, int>>()
            {
                new KeyValuePair<char, int>('M', 1000),
                new KeyValuePair<char, int>('D', 500),
                new KeyValuePair<char, int>('C', 100),
                new KeyValuePair<char, int>('L', 50),
                new KeyValuePair<char, int>('X', 10),
                new KeyValuePair<char, int>('V', 5),
                new KeyValuePair<char, int>('I', 1)
            };
        public string BestRun()
        {
            throw new NotImplementedException();
        }

        public string Run()
        {
            return IntToRoman(input);
        }

        public string IntToRoman(int num)
        {
            if (num == 0) return "";
            string roman = "";
            
            for(int i = 0;num > 0 ; i++)
            {
                var baseDecimal = (int)Math.Pow(10, i);
                var baseDigit = num % (10 * baseDecimal);

                num -= baseDigit;

                roman = AppendRoman(baseDigit, int.Parse(baseDigit.ToString()[0].ToString())) + roman;
                

            }

            return roman;
        }

        public string AppendRoman(int num, int baseDigit)
        {
            string result = "";
            foreach(var set in maps)
            {
                if (num < set.Value) continue;

                var index = maps.IndexOf(set);
                // check if either 4 / 9
                if (baseDigit == 4 || baseDigit == 9)
                {
                    bool isStartwithOne = set.Value.ToString().StartsWith("1"); // true == 4 false == 9 true => IV false => IX
                    
                    if (isStartwithOne)
                    {
                        result = "" + set.Key + maps[index - 1].Key; //IV
                        return result;
                    }
                    else
                    {
                        result = "" + maps[index + 1].Key + maps[index - 1].Key; //IX
                        return result;
                    }
                }

                var repetition = (int) num / set.Value;

                var remaining = num % set.Value;

                var extensionString = "";
                if(remaining > 0 )
                {
                    extensionString += new string(maps[index + 1].Key, remaining / maps[index + 1].Value);
                }
                result = new String(set.Key, repetition) + extensionString;
                break;
            }
            return result;
        }
    }
}
