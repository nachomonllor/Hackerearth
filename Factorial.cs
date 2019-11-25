https://www.hackerearth.com/problem/algorithm/find-factorial/



static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int answer = 1;
            for (int i = 1; i <= n; i++)
            {
                answer *= i;
            }
            Console.WriteLine(answer);

            Console.ReadLine();
        }
