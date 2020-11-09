using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_System
{
    class Convert
    {
        public static string BinToBin(string input)
        {
            return input;
        }

        public static string BinToOct(string input)
        {
            
                string output = "0", temp = "";
                string outp = "";
                int l, i;
                l = input.Length - 1;
            try
            {
                while (l >= 0)
                {
                    temp = "";
                    for (i = 0; i < 3; i++)
                    {
                        if (l < 0)
                        {
                            temp = "0" + temp;
                        }
                        else
                        {
                            temp = input[l] + temp;
                        }
                        l--;
                    }

                    if (temp.Equals("000"))
                    {
                        outp = "0" + outp;
                    }
                    else if (temp.Equals("001"))
                    {
                        outp = "1" + outp;
                    }
                    else if (temp.Equals("010"))
                    {
                        outp = "2" + outp;
                    }
                    else if (temp.Equals("011"))
                    {
                        outp = "3" + outp;
                    }
                    else if (temp.Equals("100"))
                    {
                        outp = "4" + outp;
                    }
                    else if (temp.Equals("101"))
                    {
                        outp = "5" + outp;
                    }
                    else if (temp.Equals("110"))
                    {
                        outp = "6" + outp;
                    }
                    else if (temp.Equals("111"))
                    {
                        outp = "7" + outp;
                    }
                    else
                    {
                        ;
                    }
                }
                output = outp;
            }
            catch(Exception ex)
            {
                output = ex.Message;
            }
            return output;
        }

        public static string BinToDec(string input)
        {
            long a=0;
            long p = 0;
            double i = 0;
            int l, c;
            string output = "";
            try {
                l = input.Length - 1;
                while (l >= 0)
                {
                    c = (int)(input[l] - 48);
                    a = p + (long)(c * Math.Pow(2.0, i));
                    p = a;
                    i++;
                    l--;
                }
                output = a.ToString();
            }
            catch(Exception ex)
            {
                output = ex.Message;
            }
            return output;
        }

        public static string BinToHexa(string input)
        {
            string output = "0", temp = "";
            string outp="";
            int l, i;
            try
            {
                l = input.Length - 1;
                while (l >= 0)
                {
                    temp = "";
                    for (i = 0; i < 4; i++)
                    {
                        if (l < 0)
                        {
                            temp = "0" + temp;
                        }
                        else
                        {
                            temp = input[l] + temp;
                        }
                        l--;
                    }

                    if (temp.Equals("0000"))
                    {
                        outp = "0" + outp;
                    }
                    else if (temp.Equals("0001"))
                    {
                        outp = "1" + outp;
                    }
                    else if (temp.Equals("0010"))
                    {
                        outp = "2" + outp;
                    }
                    else if (temp.Equals("0011"))
                    {
                        outp = "3" + outp;
                    }
                    else if (temp.Equals("0100"))
                    {
                        outp = "4" + outp;
                    }
                    else if (temp.Equals("0101"))
                    {
                        outp = "5" + outp; ;
                    }
                    else if (temp.Equals("0110"))
                    {
                        outp = "6" + outp;
                    }
                    else if (temp.Equals("0111"))
                    {
                        outp = "7" + outp;
                    }
                    else if (temp.Equals("1000"))
                    {
                        outp = "8" + outp;
                    }
                    else if (temp.Equals("1001"))
                    {
                        outp = "9" + outp;
                    }
                    else if (temp.Equals("1010"))
                    {
                        outp = "A" + outp;
                    }
                    else if (temp.Equals("1011"))
                    {
                        outp = "B" + outp;
                    }
                    else if (temp.Equals("1100"))
                    {
                        outp = "C" + outp;
                    }
                    else if (temp.Equals("1101"))
                    {
                        outp = "D" + outp;
                    }
                    else if (temp.Equals("1110"))
                    {
                        outp = "E" + outp;
                    }
                    else if (temp.Equals("1111"))
                    {
                        outp = "F" + outp;
                    }
                    else
                    {
                    }
                }

                output = outp;
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }
            return output;
        }

        public static string OctToBin(string input)
        {
            string output = "0";
            string outp = "";
            int l, a;
            l = input.Length - 1;
            try
            {

                while (l >= 0)
                {
                    a = (int)(input[l] - 48);
                    if (a == 0)
                    {
                        outp = "000"+ outp;
                    }
                    else if (a == 1)
                    {
                        outp = "001" + outp;
                    }
                    else if (a == 2)
                    {
                        outp = "010" + outp;
                    }
                    else if (a == 3)
                    {
                        outp = "011" + outp;
                    }
                    else if (a == 4)
                    {
                        outp = "100" + outp;
                    }
                    else if (a == 5)
                    {
                        outp = "101" + outp;
                    }
                    else if (a == 6)
                    {
                        outp = "110" + outp;
                    }
                    else if (a == 7)
                    {
                        outp = "111" + outp;
                    }
                    else
                    {
                        ;
                    }
                    l--;
                }
                output = outp;
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }
            return output;
        }

        public static string OctToOct(string input)
        {
            return input;
        }

        public static string OctToDec(string input)
        {
            string output = "0";
            output = OctToBin(input);
            output = BinToDec(output);
            return output;
        }

        public static string OctToHexa(string input)
        {
            string output = "0";
            output = OctToBin(input);
            output = BinToHexa(output);
            return output;
        }

        public static string DecToBin(string input)
        {
            string output = "0";
            string outp = "";
            long inp, a;
            try
            {
                inp = long.Parse(input);
                while (inp > 0)
                {
                    a = inp % 2;
                    inp = inp / 2;
                    outp = a + outp;
                }

                output = outp;
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }
            return output;
        }

        public static string DecToOct(string input)
        {
            string output = "0";
            output = DecToBin(input);
            output = BinToOct(output);
            return output;
        }

        public static string DecToDec(string input)
        {
            return input;
        }

        public static string DecToHexa(string input)
        {
            string output = "0";
            output = DecToBin(input);
            output = BinToHexa(output);
            return output;
        }

        public static string HexaToBin(string input)
        {
            string output = "0";
            string outp = "";
            int l, a;

            try
            {
                l = input.Length - 1;

                while (l >= 0)
                {
                    a = (int)(input[l] - 48);
                    if (a == 0)
                    {
                        outp = "0000" + outp;
                    }
                    else if (a == 1)
                    {
                        outp = "0001" + outp;
                    }
                    else if (a == 2)
                    {
                        outp = "0010" + outp;
                    }
                    else if (a == 3)
                    {
                        outp = "0011" + outp;
                    }
                    else if (a == 4)
                    {
                        outp = "0100" + outp;
                    }
                    else if (a == 5)
                    {
                        outp = "0101" + outp;
                    }
                    else if (a == 6)
                    {
                        outp = "0110" + outp;
                    }
                    else if (a == 7)
                    {
                        outp = "0111" + outp;
                    }
                    else if (a == 8)
                    {
                        outp = "1000" + outp;
                    }
                    else if (a == 9)
                    {
                        outp = "1001" + outp;
                    }
                    else if (a == 49 || a == 17)
                    {
                        outp = "1010" + outp;
                    }
                    else if (a == 50 || a == 18)
                    {
                        outp = "1011" + outp;
                    }
                    else if (a == 51 || a == 19)
                    {
                        outp = "1100" + outp;
                    }
                    else if (a == 52 || a == 20)
                    {
                        outp = "1101" + outp;
                    }
                    else if (a == 53 || a == 21)
                    {
                        outp = "1110" + outp;
                    }
                    else if (a == 54 || a == 22)
                    {
                        outp = "1111" + outp;
                    }
                    else
                    {
                        ;
                    }
                    l--;
                }
                output = outp;
            }
            catch (Exception ex)
            {
                output = ex.Message;
            }
            return output;
        }

        public static string HexaToOct(string input)
        {
            string output = "0";
            output = HexaToBin(input);
            output = BinToOct(output);
            return output;
        }

        public static string HexaToDec(string input)
        {
            string output = "0";
            output = HexaToBin(input);
            output = BinToDec(output);
            return output;
        }

        public static string HexaToHexa(string input)
        {
            return input;
        }

    }
}
