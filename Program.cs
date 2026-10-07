using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string s = "pwwkew";
        string ans = "";
        int mx = 0;

        for(int i = 0; i < s.Length; i++)
        {
            ans = "";
            for(int j = i; j < s.Length; j++)
            {
                if(!ans.Contains(s[j]))
                {
                    ans += s[j];
                }

                else
                {
                    break;
                }
                if(ans.Length >= mx)
                {
                    mx = ans.Length;
                }
                //System.Console.WriteLine(ans);
            }
        }
        System.Console.WriteLine(mx);
    }
}
