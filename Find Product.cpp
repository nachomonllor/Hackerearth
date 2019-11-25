https://www.hackerearth.com/problem/algorithm/find-product/description/
#include <iostream>
#include <stdio.h>

#define ll long long int

using namespace std;

int main()
{
    
    int n;
    scanf("%d", &n);
    
    int arr[n];
    
    for(int i =0; i<n; i++) {
        scanf("%d", &arr[i]);
    }
    
    ll answer = 1;
    for(int i =0; i<n; i++) {
          answer = (answer * arr[i]) %  1000000007;
    }
    
    cout << answer << endl;
    
    //system("pause");
    
    return 0;
}
