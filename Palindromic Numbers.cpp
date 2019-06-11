#include <iostream>
#include <vector>
#include <stdio.h>

using namespace std;

bool esPalindromo(int n){
	vector<int> digitos;
	
	while(n > 0) {
		digitos.push_back(n%10);
		n/=10;
	}
	int i = 0, j = digitos.size() - 1;
	
	while(i < j) {
		if(digitos[i] != digitos[j]) {
			return false;
		}
		
		i++;
		j--;
	}
	
	return true;
}

int main() {
	
	int T;
	scanf("%d", &T);
	
	for(int i = 0; i < T; i++) {
		int A, B;
		scanf("%d %d",&A, &B);
		int cont = 0;
		for(int j =A; j <= B; j++) {
			if(esPalindromo(j)) {
				cont++;
			}
		}
		printf("\n%d ", cont);
		
	}
	
	return 0;
}
