https://www.hackerearth.com/practice/data-structures/arrays/1-d/practice-problems/algorithm/save-mrinal-35296e39/description/


#include<iostream>
using namespace std;
int main()
{
	long long int arr[30000],n,i;
	cin>>n;
	for(i=0;i<n;i++)
		cin>>arr[i];
	long long int q;
	cin>>q;
	
	while(q-->0)
	{
		long long int l,r,distintos=0,count[1000000]={0};
		cin>>l>>r;
		for(i=l-1;i<r;i++)
		{
			if(count[arr[i]]==0){
				distintos++;
				count[arr[i]]++;
			}
	
		}
		cout<<distintos<<endl;
	}

}