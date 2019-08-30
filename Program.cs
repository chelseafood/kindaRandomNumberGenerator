using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp_RandomNumberGenerator
{
    class Program
    {
        public static void Main()
        {
            
            DateTime time = DateTime.Now;             // Use current time.
            string format = "ssmmHHddMMyy";   // Use this format.

            //WITHOUT SECOND AND MINUTES CONVERTED
            string secondsminutes = "ssmm";   // Use this format.
            string stringsecondsminutes = time.ToString(secondsminutes);

            int integermillisec = time.Millisecond;
            int integertruncmillisec = Convert.ToInt32(integermillisec / 10);
            int integerasciimillisec;
            if (integermillisec <= 25)
            {
                integerasciimillisec = integertruncmillisec + 65;
            }
            else
            {
                if (integermillisec <= 51)
                {
                    integerasciimillisec = integertruncmillisec + 71;
                }
                else
                {
                    integerasciimillisec = integertruncmillisec - 4;
                }

            }
            string stringmillisec = ((char)integerasciimillisec).ToString();
            Console.WriteLine(stringmillisec);

            //WITH SECOND CONVERTED
            int integersecond = time.Second;
            int integerasciisecond;
            if (integersecond <= 25)
            {
                integerasciisecond = integersecond + 65;
            }
            else
            {
                if (integersecond <= 51)
                {
                    integerasciisecond = integersecond + 71;
                }
                else
                {
                    integerasciisecond = integersecond - 4;
                }

            }
            string stringsecond = ((char)integerasciisecond).ToString();
            Console.WriteLine(stringsecond);

            //WITH MINUTE CONVERTED
            int integerminute = time.Minute;
            int integerasciiminute;
            if (integerminute <= 25)
            {
                integerasciiminute = integerminute + 65;
            }
            else
            {
                if (integerminute <= 51)
                {
                    integerasciiminute = integerminute + 71;
                }
                else
                {
                    integerasciiminute = integerminute - 4;
                }
                
            }
            string stringminute = ((char)integerasciiminute).ToString();
            Console.WriteLine(stringminute);


            int integerhour = time.Hour;
            int integerasciihour;
            if (integerhour <= 26)
            {
                integerasciihour = integerhour + 64;
            }
            else
            {
                integerasciihour = integerhour + 21;
            }
            string stringhour = ((char)integerasciihour).ToString();

            int integerday = time.Day;
            int integerasciiday;
            if (integerday <= 26)
            {
                integerasciiday = integerday + 64;
            }
            else
            {
                integerasciiday = integerday + 21;
            }
            string stringday = ((char)integerasciiday).ToString();


            int integermonth = time.Month;
            int integerasciimonth;
            if (integermonth <= 26)
            {
                integerasciimonth = integermonth + 64;
            }
            else
            {
                integerasciimonth = integermonth + 21;
            }
            string stringmonth = ((char)integerasciimonth).ToString();

            string year = "yy";   // Use this format.
            string stringyear = time.ToString(year);


            Console.WriteLine(stringmillisec + stringsecond + stringminute + stringhour + stringday + stringmonth + stringyear);
            Console.WriteLine(integermillisec+ stringsecondsminutes + stringhour + stringday + stringmonth + stringyear);
            Console.WriteLine(time.ToString(format)); // Write to console.



        }
      
    }
}

