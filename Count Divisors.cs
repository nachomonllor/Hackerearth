https://www.hackerearth.com/problem/algorithm/count-divisors/
static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int l = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int k = int.Parse(input[2]);

            int cont = 0;

            for (int i = l; i <= r; i++)
            {
                if (i % k == 0)
                {
                    cont++;
                }
            }

            Console.WriteLine(cont);

            Console.ReadLine();

        }
