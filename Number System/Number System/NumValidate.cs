using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_System
{
    class NumValidate
    {
        public bool isValid(string input, string inType)
        {
            bool output = false;
            int l;
            char c;
            if (inType.Equals("Binary"))
            {
                l = input.Length - 1;
                while (l >= 0)
                {
                    if (input[l] == '1' || input[l] == '0')
                    {
                        output = true;
                        l--;
                    }
                    else
                    {
                        output = false;
                        return output;
                    }
                }
                return output;
            }
            if (inType.Equals("Octal"))
            {

                l = input.Length - 1;
                while (l >= 0)
                {
                    c = input[l];
                    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7')
                    {
                        output = true;
                        l--;
                    }
                    else
                    {
                        output = false;
                        return output;
                    }
                }
                return output;
            }
            if (inType.Equals("Decimal"))
            {
                l = input.Length - 1;
                while (l >= 0)
                {
                    c = input[l];
                    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                    {
                        output = true;
                        l--;
                    }
                    else
                    {
                        output = false;
                        return output;
                    }
                }
                return output;
            }
            if (inType.Equals("Hexa-Decimal"))
            {
                l = input.Length - 1;
                while (l >= 0)
                {
                    c = input[l];
                    if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F' || c == 'a' || c == 'b' || c == 'c' || c == 'd' || c == 'e' || c == 'f')
                    {
                        output = true;
                        l--;
                    }
                    else
                    {
                        output = false;
                        return output;
                    }
                }
                return output;
            }

            return output;
        }

    }
}
