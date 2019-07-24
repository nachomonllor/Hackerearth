using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ConsoleApplication1
{
   

    class Program
    {

        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }


        private static void quicksort(List<Interval> vector, int primero, int ultimo)
        {
            int  i, j, central;
            int pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central].start;
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i].start < pivote) i++;
                while (vector[j].start > pivote) j--;
                if (i <= j)
                {
                    Interval temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    // vector.Set(i, vector.get(j));
                    // vector.set(j, temp);

                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }




        public static List<Interval> Merge(List<Interval> longervals)
        {

            if (longervals == null || longervals.Count == 0) return longervals;

            quicksort(longervals, 0, longervals.Count - 1);

            int  i = 0;

            List<Interval> res = new List<Interval>();

            while (i < longervals.Count)
            {
                Interval a = longervals[i];
                Interval insertar = a;
                while (i + 1 < longervals.Count && longervals[i + 1].start <= a.end)
                {

                    insertar = new Interval(Math.Min(a.start, longervals[i + 1].start), Math.Max(a.end, longervals[i + 1].end));
                    a = insertar;
                    i++;
                }
                res.Add(insertar);
                i++;
            }

            return res;
        }


        static long sumarRango(long a, long b)
        {

            return (b * (b + 1) / 2) - ((a - 1) * (a) / 2);
        }

        static long sumarSobrantes(string[] longervalos)
        {

            List<Interval> lista = new List<Interval>();
            //cargo lista longervalos
            for (long i = 0; i < longervalos.Length; i++)
            {
                string[] item = longervalos[i].Split(' ');
                lista.Add(new Interval(int.Parse(item[0]), int.Parse(item[1])));
            }

            lista = Merge(lista);

            long suma = 0;
            foreach (Interval item in lista)
            {
                suma += sumarRango(item.start, item.end);
            }

            return sumarRango(1, 1000000) - suma;

        }


        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine().Trim());

            string[] input = new string[n];
            long i = 0;
            while (n-- > 0)
            {
                input[i++] = Console.ReadLine().Trim();
            }

            Console.WriteLine(sumarSobrantes(input));


            Console.ReadLine();
        }

    }
}


