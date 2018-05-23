#include<iostream>
#define MAX(A,B) (A>B) ? A : B ;

using namespace std;

int M,N;

void PreBM(char P[], int Delta[])
{
  for( int i = 0; i <= 255; i++ )
      Delta[i] = M;
      
  for( int i = 0; i < M; i++){
	  
       Delta[P[i]] = M - 1 - i ;

	   
  }
   

}

int Boyer_Moore_Matcher(char T[], char P[])
{
  int i = M - 1 ,j = M - 1 ;
  int Delta[256];
  int aux,aux2;
  PreBM(P,Delta);

  while( j >= 0 )
      {
       while ( T[i] != P[j] )
             {
              
		
			
              i += MAX(M-j , Delta[T[i]]); 
			  aux=i;
   
              if( i >= N )
                 return N;
                 
              j = M - 1; 
               
             }
        j--;
        i--;
 
        if ( j < 0 )
           {
			   cout<<endl;
			cout<<"Palabra Encontrada esta entre la posicion "<<i+1<<" a "<<aux+2<<" ";
			
			cout<<endl<<endl;
			
				 
            i += M + 1;
            j = M - 1;
           }     
      }
 return 0; 
}


int main()
{
 system("color f0");
 
 char Texto[100],Patron[100];
 
 cout<<"\n\n\t Ingrese Texto  : ";
 gets(Texto);
 
 N = strlen(Texto);
 
 do
   {
    cout<<"\n\t Ingrese Patron : ";
    cin>>Patron;
    
    M = strlen(Patron);

    
    if( M > N )
       cout<<"\t\t ERROR!!! Texto > Patron... \n";
    
   } 
 while( M > N );

     
 Boyer_Moore_Matcher(Texto,Patron);
 
 system("PAUSE");
 
}