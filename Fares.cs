using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnandhuPMCodingChallengeNov14
{
    
    internal class Fares
    {
        public double[] fares = new double[3];
        double temp;
        
        public double[] fare_5 = new double[10];

        public void SetData_5()
        {
            Console.WriteLine("Enter 10 fares");
            for (int i = 0; i < 20; i=i+2)
            {
                fare_5[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void SetData()
        {
            Console.WriteLine("Enter 10 fares");
            for(int i = 0; i < fares.Length; i++)
            {
                fares[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void GetData()
        {
            for (int i = 0; i < fares.Length; i++)
            {
                Console.WriteLine(fares[i]);
            }
        }
        public void Ascending()
        {
            for (int i = 0; i < fares.Length; i++)
            {
                for (int j = i; j < fares.Length; j++)
                {
                    if (fares[i] > fares[j])
                    {
                        temp = fares[i];
                        fares[i] = fares[j];
                        fares[j] = temp;
                    }
                }
            }
            GetData();
        }
        public void Descending()
        {
            for (int i = 0; i < fares.Length; i++)
            {
                for (int j = i; j < fares.Length; j++)
                {
                    if (fares[i] < fares[j])
                    {
                        temp = fares[i];
                        fares[i] = fares[j];
                        fares[j] = temp;
                    }
                }
            }
            GetData();
        }
        public void Search()
        {
            Console.WriteLine("Enter Elemnt to Search");
            temp = Convert.ToDouble(Console.ReadLine());
            Boolean flag = false;
            for (int i = 0; i < fares.Length; i++)
            {
                if(temp == fares[i])
                {
                    Console.WriteLine("Element found at index position : " + i);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Element Not found  "  );

            }
        }
        public void MaxMin()
        {
            double max, min;
            max = min = fares[0];
            for (int i = 0; i < fares.Length; i++)
            {
                if(max < fares[i])
                {
                    max = fares[i];
                }
                if (min > fares[i])
                {
                    min = fares[i];
                }

            }
            Console.WriteLine("Maximum is " + max + " Min is " + min);
        }
        public void Duplicate()
        {
            for (int i = 0; i < fares.Length; i++)
            {
                for (int j = i+1; j < fares.Length; j++)
                {
                    if(fares[j] == fares[i])
                    {
                        Console.WriteLine(fares[i]);
                    }
                }
            }
        }
    }
}
