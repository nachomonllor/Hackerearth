#include <iostream>
#include <stdio.h>

using namespace std;

void emazein(string s) {
	//L, R, U, D
	int x = 0, y = 0;
	for(int i = 0; i < s.size(); i++) {
		
		if(s[i] == 'L' ){
			x--;
		}
		else if(s[i] == 'R') {
			x++;
		}
		else if(s[i] == 'U') {
			y++;
		}
		else if(s[i] == 'D'){
			y--;
		}
	}
	cout << x << " " << y << endl;
}

int main() {
	
	//int num;
	//cin >> num;										// Reading input from STDIN
	//cout << "Input number is " << num << endl;		// Writing output to STDOUT
	
	string s;
	cin >> s;
	
	emazein(s);
	
	return 0;
	
}

