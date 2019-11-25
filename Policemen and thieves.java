import java.io.*;
import java.util.*;


public class TestClass {
    public static void main(String[] args) throws IOException {
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        PrintWriter wr = new PrintWriter(System.out);
        int T = Integer.parseInt(br.readLine().trim());
        for(int t_i=0; t_i<T; t_i++)
        {
            String[] line = br.readLine().split(" ");
            int N = Integer.parseInt(line[0]);
            int K = Integer.parseInt(line[1]);
            char[][] A = new char[N][N];
            for(int i_A=0; i_A<N; i_A++)
            {
            	String[] arr_A = br.readLine().split(" ");
            	for(int j_A=0; j_A<arr_A.length; j_A++)
            	{
            		A[i_A][j_A] = arr_A[j_A].charAt(0);
            	}
            }

            int out_ = solution(A, K);
            System.out.println(out_);
            System.out.println("");
         }

         wr.close();
         br.close();
    }
    static int solution(char[][] A, int K){
        // Write your code here
       
         int cont = 0;
            for (int i = 0; i < A.length; i++)
            {

                boolean[] marcas = new boolean[A[i].length];
                for (int j = 0; j < A[i].length; j++)
                {
                    if (A[i][j] == 'P')
                    {
                        for (int k = j + 1; k < A[i].length; k++)
                        {
                            if (A[i][k] == 'T')
                            {
                                if (!marcas[k] && !marcas[j])
                                {
                                    if (k - j <= K)
                                    {
                                        marcas[j] = true;
                                        marcas[k] = true;
                                        cont++;
                                        break;
                                    }
                                }


                            }
                        }
                    }
                   else if (A[i][j] == 'T')
                    {
                        for (int k = j + 1; k < A[i].length; k++)
                        {
                            if (A[i][k] == 'P')
                            {
                                if (!marcas[k] && !marcas[j])
                                {
                                    if (k - j <= K)
                                    {
                                        marcas[j] = true;
                                        marcas[k] = true;
                                        cont++;
                                        break;
                                    }
                                }


                            }
                        }
                    }
                }

               

            }

            return cont;
    
    }
}
