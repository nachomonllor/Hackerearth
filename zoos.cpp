https://www.hackerearth.com/challenges/competitive/november-circuits-19/algorithm/is-zoo-f6f309e7/

#include <iostream>
#include <stdio.h>

using namespace std;


int main() {
	
	string s;
	cin >> s;
	
	int z =0, o =0;
	
	for(int i =0; i<s.length(); i++) {
		if(s[i] == 'z') {
			z++;
		}
		else if(s[i] == 'o') {
			o++;
		}
	}
	
	string ans = "Yes";
	if(o != 2* z) {
		ans = "No";
	}
	
	cout << ans << endl;
	
	return 0;
}