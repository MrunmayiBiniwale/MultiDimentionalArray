namespace MultiDimentionalArray
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3,3]; //multidimensional array
            int[][] arr2 = new int[3][]; //jagged array

            //get array values from user
            Console.WriteLine("Please enter the elements for the first array :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            //create sub arrays for jagged array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0 + i; j < 3; j++)
                {
                    arr2[i] = new int[3 - i];
                }
            }

            //assign values to jagged array from multidimensional array
            for (int j = 0; j < 3; j++)
            {
                for(int k = 0; k < arr2[j].Length; k++)
                {
                    arr2[j][k] = arr1[j, k + j];
                }                    
            }

            //print multidimensional array
            Console.WriteLine("\nTableau uniforme :");
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {                    
                    Console.Write(" " + arr1[j,k] + " ");
                }
                Console.WriteLine();
            }

            //print jagged array
            Console.WriteLine("Tableau irrégulié :");
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < arr2[j].Length; k++)
                {                    
                    Console.Write(" " + arr2[j][k] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
