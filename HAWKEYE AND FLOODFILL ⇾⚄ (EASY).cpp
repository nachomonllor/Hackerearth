https://www.hackerearth.com/practice/basic-programming/implementation/basics-of-implementation/practice-problems/algorithm/hawkeye-and-floodfill/
#include <iostream>
#include <stdio.h>
#include <math.h>

using namespace std;

void MostrarMatriz(int a, int b, int n, int p)
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            int m = min(p - abs(i - a),  p - abs(j - b));
            if (m >= 0)
            {
                //Console.Write(min + " ");
                cout << m << " " ;
            }
            else
            {
                //Console.Write(0 + " ");
                cout << "0 ";
            }
        }
        cout << endl;
    }
}



int main() {
	
	
	int n;
	scanf("%d", &n);
	
	int i,j,p;
	scanf("%d %d %d", &i, &j, &p);
	
	MostrarMatriz(i, j, n, p);
	
	
	return 0;
}

