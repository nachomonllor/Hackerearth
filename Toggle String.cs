https://www.hackerearth.com/problem/algorithm/modify-the-string/
static void Main(string[] args)
    {
 
        string s = Console.ReadLine();
        string ans = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLower(s[i]))
            {
                ans += char.ToUpper(s[i]);
            }
            else
            {
                ans += char.ToLower(s[i]);
            }
        }

        Console.WriteLine(ans);

        Console.ReadLine();
    }
