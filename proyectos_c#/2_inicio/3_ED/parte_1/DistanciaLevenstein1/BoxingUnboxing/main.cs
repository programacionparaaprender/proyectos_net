using System;

public class LevenshteinDistance
{
    public static void Main(String[] args)
    {
        int n;
        Console.WriteLine(computeLevenshteinDistance("casa", "calle"));
        n = Console.Read();
        Console.ReadKey(true);
    }
    private static int minimum(int a, int b, int c)
    {
        if (a <= b && a <= c)
            return a;
        
        if (b <= a && b <= c)
            return b;
        
        return c;
    }

    private static int computeLevenshteinDistance(string str1,string str2)
    {
        int [,] distance = new int[str1.Length+1,str2.Length+1];

        for (int i = 0; i <= str1.Length; i++)
                distance[i,0]=i;
        
        for (int j = 0; j <= str2.Length; j++)
                distance[0,j]=j;
        
        for (int i = 1; i <= str1.Length; i++)
            for(int j=1;j<=str2.Length;j++)
                  distance[i,j]= minimum(distance[i-1,j]+1,

                 distance[i,j-1]+1, distance[i-1,j-1]+

                 ((str1[i-1]==str2[j-1])?0:1));
            
        return distance[str1.Length,str2.Length];
 
    }
}