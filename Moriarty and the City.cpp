
#include <iostream>
#include <stdio.h>

using namespace std;

int main() {

    int n;
    scanf("%d", &n);

    //int[] arr = { 1, 1, 1, 1, 1 };
    int arr[n];
    for(int i =0; i<n; i++) {
       scanf("%d", &arr[i]);   
    }

    long unos = 0, max_unos = 0, ceros = 0, max_ceros = 0;

    for (int i = 0; i < n; i++){
        if (arr[i] == 1) {
            unos++;
            max_ceros = max(ceros, max_ceros);
            ceros = 0;
        }
        else{
            max_unos = max(unos, max_unos);
            unos = 0;
            ceros++;
        }
    }

    max_ceros = max(ceros, max_ceros);
    max_unos = max(unos, max_unos);
    //Console.WriteLine("max unos = {0}, max ceros = {1}", max_unos, max_ceros);

    printf("%d\n", max(max_ceros, max_unos));
    
    //system("pause");
    
  return 0;   
}
