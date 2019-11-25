﻿#include <iostream>
#include <stdio.h>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> plusOne(vector<int> &digits) {
    int u = digits.size() - 1;
	     
	digits[u]++;
	     
	while(u > 0 && digits[u] > 9){
	    digits[u] = 0;
	    u--;
	    digits[u]++;
	}
	     
	if(digits[0] > 9){
	    vector<int> copia(digits.size()+1);// = new int[digits.size() + 1];
	    copia[0] = 1;
	    	
	    for(int i=1; i<digits.size(); i++){
	    	copia[i] = digits[i];
	    }
	    return copia;
	}
		 
	return digits;
}

std::vector<int> multiplicationOfBigNumbers(std::vector<int> a, std::vector<int> b) {
	
	std::vector<int> c;
	int next = 0;
	for(int k = 0; k < (int)a.size() + (int)b.size() - 1; k++) {
		int cur = next;
		int i, j;
		if(k < a.size()) {
			i = (int)a.size() - 1 - k;
			j = (int) b.size() - 1;
		} else {
			i = 0;
			j = (int)a.size() + (int )b.size() - 2 - k;
		}
		while(i < a.size() && j >= 0) {
			cur += a[i] * b[j];
			i++;
			j--;
		}
		c.push_back(cur % 10);
		next = cur / 10;
		
	}
	if(next > 0) {
		c.push_back(next);
	}
	
	std::reverse(c.begin(), c.end());
	return c;
}

void mostrarFact(int N) {
	
	vector<int> incremento;
	incremento.push_back(1);
	
	vector<int> res;
	res.push_back(1);
	
	for(int i = 0; i < N; i++) {
		
		res = multiplicationOfBigNumbers(incremento, res);
		
		incremento = plusOne(incremento);
		
	}
	
	printf("\n");
	for(int i = 0; i < res.size(); i++) {
		printf("%d", res[i]);
	}
	
}

int main() {
	
	int T;
	scanf("%d", &T);
	
	for(int i = 0; i < T; i++) {
		int N;
		scanf("%d", &N);
		mostrarFact(N);
	}
	
	return 0;
}
