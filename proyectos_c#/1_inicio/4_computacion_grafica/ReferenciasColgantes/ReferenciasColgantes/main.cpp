#include<iostream>
#include<cstdlib>

using namespace std;

void muestra(int *p)
{
	int v = 20;
	p = &v;
	cout<<*p<<endl;
}

int main(void)
{
	int *p = NULL;
	muestra(p);
	if(p==NULL)
		cout<<"es null"<<endl;
	system("pause");
	return 0;
}