using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, округлёнными до одного знака
            void Zadacha50()
            {
            Random random=new Random() ; 
            int rows=random.Next(1,6);
            int columns=random.Next(3,8);
            int[,] array=new int[rows,columns];
             FillArray(array);
             PrintArray(array);

             Console.WriteLine("введите номер строки");
             int row =Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("введите номер столбца");
             int column=Convert.ToInt32(Console.ReadLine());
             if(row <= rows && row >= 1 && column <= columns && row >= 1)
             {
                Console.WriteLine($"искомый элемент [{row} , {column}] = {array [rows - 1 , columns - 1]}");
             }
             else Console.WriteLine(" такого элемента в массиве нет ");

            
            }
             Zadacha50();

            static void FillArray(int[,] array)
            {
                Random random=new Random();
                int rows=array.GetLength(0);
                int columns=array.GetLength(1);

                for (int i = 0;i < rows; i++)
                {for(int j = 0;j < columns; j++)
                {
                    array[i,j]=random.Next(-9,9) ;
                }
                }
            }

            static void PrintArray(int[,] array)
            {
            Console.WriteLine();
            Console.WriteLine(" массив ");

                int rows= array.GetLength(0);
                int columns= array.GetLength(1);

                for (int i = 0;i < rows ; i++)
                {
                    for(int j = 0;j < columns; j++)
                {
                   Console.Write(array[i,j] + " \t ");
                }
                }
                Console.WriteLine();
            }
           
              //bgh  
        
        }
        
     }
    
}