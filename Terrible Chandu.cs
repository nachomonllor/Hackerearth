        static void Main()
        {
            int t = int.Parse(Console.ReadLine());

            while (t-- > 0)
            {
                char[] ch = Console.ReadLine().ToCharArray();
                Array.Reverse(ch);
                Console.WriteLine(new string(ch));
            }

            Console.ReadLine();
        }
