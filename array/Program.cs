using System;


class ArrayProgram
{
    public static void Main()
    {
        int[] a = new int[5];
        a[0] = 1;
        a[1] = 2;
        a[2] = 3;

        Console.WriteLine(a[0]); // Output: 1
        Console.WriteLine(a[1]); // Output: 2

        int[] b = new int[5];
        for (int i = 0; i < 10; i++)
        {
            b[i] = i * 10;
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(b[i]); // Output: 0, 10, 20, ..., 90      
        }


        //2D array

        int[][] c = new int[3][];
        
        //array of arrays

        for (int i = 0; i < c.Length; i++)
        {
            c[i] = new int[5];
            for (int j = 0; j < 5; j++)
            {
                c[i] = new int[3];
            }
        }
    }
    



    






}


