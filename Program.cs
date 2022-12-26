using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    /* 
     * Bubble- Sort Programm 
     * by rene.jock@outlook.de
     * Date: 26.12.2022
     * Inspired by ChatGPT (https://chat.openai.com/chat)
     * Ein kleines SortierProgramm, welches ein Array mit dem Datentyp Integer an nimmt
     * und dieses in aufsteigender Reihenfolge sortiert.
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {1,3,2,4,6,5,8,9,7,10};
            BubbleSort(arr);

            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }

        static void BubbleSort(int[] arr)
        {
            bool swapped;
            do
            {
                swapped= false;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                        swapped = true;

                    } 
                }
            } while (swapped);
        }
    }
}
