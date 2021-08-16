using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework13._8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TARGIL1


            double[,] tempTest = new double[28, 2];
            Random rnd = new Random();
            //new double = rnd.Next;

            for (int i = 0; i < tempTest.GetLength(0); i++)//רץ על שורות
            {
               
                for (int j = 0; j < tempTest.GetLength(1); j++)//רץ על עמודות
                {

                    tempTest[i, 1] = i + 1;
                    if (i>=3)
                    {
                        tempTest[i, 0] =rnd.Next(24,41);
                    }
                   
                }

            }

            //הצבת 3 ערכים ידני
            tempTest[0, 0] = 36.6;
            tempTest[1, 0] = 35.1;
            tempTest[2, 0] = 32.1;


            //הדפסת ערכי המערך הדו המימדי
            for (int i = 0; i < tempTest.GetLength(0); i++)//רץ על שורות
            {
                for (int j = 0; j < tempTest.GetLength(1); j++)//רץ על עמודות
                {

                    Console.Write(tempTest[i, j] + "\t"); ;


                }

                Console.WriteLine();

            }

            //מציאת ערך על פי יום
            Console.WriteLine();
            Console.WriteLine("the temperature is "+TestValue(tempTest, 2));
            #endregion
            #region Targil2
            Measurement[,] tests = new Measurement[28, 2];
            
            for (int i = 0; i < tests.GetLength(0); i++)//רץ על שורות
            {

                for (int j = 0; j < tests.GetLength(1); j++)//רץ על עמודות
                {
                   // tests[i, j] =
                   

                }

            }


            #endregion  
        }

        public static double TestValue(double[,] myarray,int day)
        {
           double temp =myarray[day-1, 0];


            return temp;
        }
    }
}
