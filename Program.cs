class Program
{
    static void Main(string[] args)
    {
        string s = "А роза упала на лапу Азора";

        System.Console.WriteLine(IsPalindrome(s));

    }
    static bool IsPalindrome(string s)
    {
        s = s.Trim();
        s = s.ToLowerInvariant();
        
        s = s.Replace(" ", "");
        s = s.Replace(",", "");
        s = s.Replace(".", "");
        s = s.Replace("!", "");
        
        string b = s;
        bool r = true;
        for(int i = 0; i < s.Length / 2; i++)
        {
            int j = b.Length - 1 - i;

            if(s[i] != b[j])
            {
                r = false;
                break;
            }
        }
        return r;
    }
}
