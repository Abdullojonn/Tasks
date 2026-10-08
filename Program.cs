using System.Globalization;
using System.IO.Pipelines;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        string text = "apple banana apple cherry banana apple";

        string[] parts = text.Split(" ");

        /*foreach (var item in parts)
        {
            System.Console.WriteLine(item);
        }*/

        Dictionary<string, int> dc = new Dictionary<string, int>();
        int cnt = 1;
        for(int i = 0; i < parts.Length; i++)
        {
            if(!dc.TryGetValue(parts[i], out cnt))
            {
                dc[parts[i]] = 1;
            }
            else
            {
                cnt ++;
                dc[parts[i]] = cnt;
            }
        }

        foreach (var item in dc)
        {
            System.Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}