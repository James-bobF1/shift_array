using System;

namespace shift_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input lenght");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("input shift");
            int shift = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = i;
            }
            shiftArray(ref arr, shift);
        }

        static void shiftArray(ref int[] arr, int shift)
        {
            if (arr.Length==0)
            {
                return;//can't shift
            }
            int ShiftCount = 0;
            int calculatedShift = shift % arr.Length;
            if (calculatedShift < 0)
            {
                calculatedShift = arr.Length + calculatedShift;
            }
            if (calculatedShift == 0)
            {
                return;//not need shift
            }
            int tail = 0;
            int head = calculatedShift;
            int topush= arr[tail];
            while (ShiftCount < arr.Length - 1)
            {
                if (head == tail)
                {
                    arr[tail++] = topush;
                    topush = arr[tail];
                    head = (tail + calculatedShift) % arr.Length; 
                }
                else
                {
                    int tmp = arr[head];
                    arr[head] = topush;
                    topush = tmp;
                    head = (head + calculatedShift) % arr.Length;
                }
                ShiftCount++;
            }
            arr[head] = topush;//shift complete
        }
    }
}
