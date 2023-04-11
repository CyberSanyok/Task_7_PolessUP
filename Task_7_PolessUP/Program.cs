using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int number = 2017;
        string strNumber = number.ToString();
        var ints = new List<int>();
        while (number != 0)
        {
            ints.Insert(0, number % 10);
            number = number / 10;
        }
        int max = strNumber[0];
        int iToReplace=-1;
        for (int i = 1;i<ints.Count;i++) 
        {
            if (ints[i] > ints[i-1])iToReplace = i;
        }
        if (iToReplace == -1) Console.WriteLine("0");
        else
        {
            int i = ints[iToReplace];
            ints[iToReplace] = ints[iToReplace - 1];
            ints[iToReplace-1] = i;
            Console.WriteLine(string.Join("",ints));
        }
    }
}