using System;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //2d arrays where there is an array and every element in itself is an array 

            int[,] numberGrid = {            //the comma tells c# its a 2d array 

                {1, 2 },//index 0 
                {3, 4 },//index 1
                {5, 6 } //index 2 

            };

            Console.WriteLine(numberGrid[0, 0]);//referring to row 0 column 0 
            Console.WriteLine(numberGrid[1, 1]);//will return 4 

            int[,] myArray = new int[2, 3];// telling c# how many rows and columns i would like if i dont know the values 


            Console.ReadLine();

        }
    }
}
