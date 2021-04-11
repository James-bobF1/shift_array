using System;

namespace shift_array
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int maxRange = 200;
            for (int i = 1; i < maxRange; i++)
            {
                for (int j = -i; j <= i; j++)
                {
                    Console.WriteLine($"Array lenght {i} Array shift {j}");
                    shiftArray(i, j);
                }
            }*/
            Console.WriteLine("input lenght");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("input shift");
            int shift = int.Parse(Console.ReadLine());
            shiftArray(lenght, shift);/**/
        }

        static void shiftArray(int ArrayLenght, int shift)
        {
            int ShiftCount = 0;
            int halfArray = ArrayLenght / 2;
            int calculatedShift;//if Abs(shift) > ArrayLenght/2 we can perform a shift in the opposite direction, by a smaller amoun
            if (Math.Abs(shift % ArrayLenght) > halfArray)
            {
                if (shift > 0)
                {
                    calculatedShift = shift % ArrayLenght - ArrayLenght;
                }
                else
                {
                    calculatedShift = shift % ArrayLenght + ArrayLenght;
                }
            }
            else
            {
                if (Math.Abs(shift) >= ArrayLenght)
                {
                    calculatedShift = shift % ArrayLenght;
                }
                else
                {
                    calculatedShift = shift;
                }
            }
            int tail;
            int head;
            if (calculatedShift > 0)
            {
                tail = 0;
                head = calculatedShift;
            }
            else
            {
                tail = ArrayLenght - 1;
                head = ArrayLenght - 1 + calculatedShift;
            }
            int[] arr = new int[ArrayLenght];
            for (int i = 0; i < ArrayLenght; i++)
            {
                arr[i] = i+1;
            }
            arr[head] = arr[tail];
            int topush = head;
            if (!(calculatedShift == 0))
            {
                while (ShiftCount < ArrayLenght - 1)
                {
                    if (head == tail)
                    {
                        if (calculatedShift > 0)
                        {
                            head++;
                        }
                        else
                        {
                            head--;
                        }
                        arr[tail] = tmp;
                        tmp = arr[head];
                        tail = head;
                        if (ShiftCount >= ArrayLenght - 1)
                        {
                            break;
                        }
                    }
                    else
                    {
                        arr[head] = ++ShiftCount;//
                    }
                    head = (head + calculatedShift) % ArrayLenght;
                    if (head < 0)
                    {
                        head += ArrayLenght;
                    }
                }
                arr[head] = tmp;
                Console.WriteLine("Shift success");
                if (true)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == i)
                        {
                            throw new Exception();
                        }
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Can't shift");
            }
        }
    }
}
