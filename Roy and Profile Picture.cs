static void Main(string[] args)
        {

            int l = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] linea = Console.ReadLine().Split(' ');
                int w = int.Parse(linea[0]);
                int h = int.Parse(linea[1]);

                if (w < l || h < l)
                {
                    //printf("Upload Another\n");
                    Console.WriteLine("UPLOAD ANOTHER");
                }
                else if (w >= l && h >= l)
                {
                    if (w == h)
                        Console.WriteLine("ACCEPTED");
                    else
                        Console.WriteLine("CROP IT");
                }
            }

            Console.ReadLine();
        }

