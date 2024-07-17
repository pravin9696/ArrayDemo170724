using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo170724
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////one diamential array

            //int[] ar1 = new int[5];//array declaration

            ////array initialization

            //int[] ar2 = new int[] {111,222,333,444 };
            //Console.WriteLine(ar2.Length);
            //Console.WriteLine("ar2[2]=" + ar2[2]);
            //int x = 4; // variable initialization
            //int y;  //variable declaration
            //y = 78;

            // 2-D array

            int[][] ar3 = new int[2][];

            Console.WriteLine(ar3.Length);

            ar3[0]=new int[5];
            ar3[0][4] = 999;
            Console.WriteLine("value stored is " + ar3[0][2]);
            ar3[1]=new int[2];
            Console.WriteLine("length of  ar3[0]" + ar3[0].Length);
            Console.WriteLine("length of  ar3[1]" + ar3[1].Length);

            //array of city name

            string[] cities = new string[5];
            cities[0] = "pune";
            cities[1] = "mumbai";

            Console.WriteLine(cities[0]);
            //-----------------------------------

            int[,] ar4 = new int[3, 5];
            ar4[0, 0] = 111;
            ar4[1, 2] = 222;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("\t" + ar4[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("row length="+ar4.GetLength(0));
            Console.WriteLine("column length=" + ar4.GetLength(1));

            //float[,,] ar5 = new float[2,2,2];

            /* print following pattern 
              1
              1  2
              1  2  3
              1  2  3  4
             */
            Console.WriteLine("==========================");
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("\t"+j);
                    //System.Out.print("\t" + j);  //for java
                }
               // Console.Write("\n");
                Console.WriteLine();
                //System.Out.println(); //for java
            }
            

            Console.ReadKey();

        }
    }
}
