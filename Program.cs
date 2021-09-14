using System;
using System.Collections.Generic;

namespace SumPair
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter length of array
            Console.WriteLine("Enter length of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; 
            int[] indicesArr = new int[n];
            //input target value
            Console.WriteLine("Enter length of target interger value:");
            int targetValue = Convert.ToInt32(Console.ReadLine());

            //input array
            Console.WriteLine("Enter array:");
            for (int i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //logic for calculating indices of elements pair that sums to targetValue value
            int offset = 1;
            int indexCount = 0;
            int i1=0, i2=1;
            for (int i = 0; i < arr.Length; )
            {
                
                if(i1<arr.Length && i2<arr.Length)
                {
                    int firstElement = arr[i1];
                    int secondElement = arr[i2];

                    if (firstElement != 1000000000 && secondElement != 1000000000)
                    {
                        if (firstElement + secondElement == targetValue)
                        {
                            //save the indices that sums to targetValue
                            indicesArr.SetValue(i1, indexCount);
                            indicesArr.SetValue(i2, indexCount + 1);
                            // to keep track how many values are entered in indices array
                            indexCount = indexCount + 2;

                            //remove those element pair(sums to targetValue) that are being found
                            arr.SetValue(1000000000, i1);
                            arr.SetValue(1000000000, i2);

                            //recalculate the initial i values
                            i = 0; i1 = 0;
                            i2 = i;

                            //firstElement = arr[i1 + 1];
                            //secondElement = arr[i2 + 1];
                        }
                        else
                        {
                            offset++;
                            //i++;
                            i2++;
                        }
                    }
                    else
                    {
                        if (firstElement == 1000000000)
                        { i++; i1++; }
                        if (secondElement == 1000000000)
                        { i2++; }
                        if (i1 == i2)
                        { i2++; }
                    }

                }
                else
                {
                    break;
                }

            }

            Console.WriteLine("Indices of elements pair that sums to targetValue value is:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(indicesArr[i]);
            }
           
        }
    }
}
