#include <iostream>
#include <stdio.h>

using namespace std;
	
string areEqual(string a, string b) {
	
	int s_a[256];
	int s_b[256];
	
	for(int i =0; i< 256; i++) {
		s_a[i] = 0;
		s_b[i] = 0;
	}
	
	for(int i =0; i < a.size(); i++) {
		s_a[a[i]]++;
	}
	
	for(int i =0; i < b.size(); i++) {
		s_b[b[i]]++;
	}
	
	for(int i = 0; i < 256; i++) {
		if(s_a[i] != s_b[i]) {
			return "NO";
		}
	}
	return "YES";
}


int main() {
	
	
	int t;
	scanf("%d", &t);
	
	while(t--) {
		string s1, s2;
		cin >> s1 >> s2;
		cout << areEqual(s1, s2) << endl;
	}

	return 0;
}
