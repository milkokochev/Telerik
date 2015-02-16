//Write a method that returns the index of the first element in array 
//that is larger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.


using System;

    class FirstLargerThanNeighbours
    {
        static bool NeighborsComparer(int index, int[] array)
        {
            bool maxIndex = false;
            if (index == 0 && array[index] > array[index + 1])
            {
                maxIndex = true;
            }
            else if (index == array.Length - 1 && array[index] < array[index - 1])
            {
                maxIndex = true;
            }
            else if (index > 0 && array[index - 1] < array[index] && array[index + 1] < array[index] && index < array.Length - 1)
            {
                maxIndex = true;
            }

            return maxIndex;
        }
        static void Main()
        {
            Console.Write("Enter the array:");
            string[] input = Console.ReadLine().Split(',');
            int[] numbers = Array.ConvertAll(input, int.Parse);
            bool minusOne = false;
            bool indexFound = false;
            int maxIndex = 0;
            int minusOneIndex = int.MinValue;
            

            for (int i = 0; i < numbers.Length-1; i++)
            {
                indexFound = NeighborsComparer(i, numbers);

                if (indexFound)
                {
                    maxIndex = i;
                    break;
                }
                else if (numbers[i]>-1 && !minusOne)
                {
                    minusOneIndex = i;
                    minusOne = true;
                }
            }
            if (indexFound)
            {
                Console.WriteLine("Index of the first element in array that is larger than its neighbors is {0} and the element is {1}!",maxIndex,numbers[maxIndex]); 
            }
            else if (minusOne)
            {
                Console.WriteLine("Index of the first element in array that is larger than -1 is {0} and the element is {1}!", minusOneIndex, numbers[minusOneIndex]); 
                
            }
        }
    }