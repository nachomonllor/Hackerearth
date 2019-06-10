#include <iostream>
#include <stdio.h>

using namespace std;

int main() {
    
    int t;
    scanf("%d", &t);
    
    while(t--) {
      
      int n;
      scanf("%d", &n);
      string s ="";   
      cin >> s;
      
      bool contieneU = false;
      for(int i =0; i<s.length(); i++) {
          if(s[i] == 'U') {
             contieneU =true;      
             break;
          }   
      } 
      if(contieneU) {
         printf("Error RNA nucleobases found!\n");
         continue;
      }
      
      for(int i =0; i<s.length(); i++) {
            
            if (s[i] == 'A')
            {
               printf("%c", 'T');
            }
            else if (s[i] == 'T')
            {
                printf("%c", 'A');
            }
            else if (s[i] == 'G')
            {
                printf("%c", 'C');
            }
            else if (s[i] == 'C')
            {
                printf("%c", 'G');
            }
           
         }  
         
         printf("\n"); 
        
    }
    
   // system("pause");
    return 0;
}
