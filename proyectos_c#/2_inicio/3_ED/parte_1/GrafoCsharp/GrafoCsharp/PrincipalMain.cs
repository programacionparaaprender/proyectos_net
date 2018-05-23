using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GrafoCsharp
{
    struct vertice 
    {
        char nod;
        int marca;
        struct vertice sig;
        struct arco arc;
    };

    struct arco 
    {
        struct vertice ver;
        int marca;
        int suma;
        int clave;
        struct arco sig;
    };

    public class PrincipalMain
    {
        vertice pri, nue, aux,ult, aux2;
        arco nueArc, auxArc, arcMen, auxArc2,antArc;

        int verificar(int numero,vertice pri)
        {
            for(vertice aux = pri;aux != null;aux = aux.sig)
                if (aux.marca == numero)
                    return 1;
            return 0;
        }

int existe(char nod,vertice *pri)
{
    for(vertice *aux = pri ; aux != NULL ; aux = aux->sig)
        if (aux->nod == nod)
            return 1;
    return 0;
}

int menu(void)
{
	int op = 0;
    system("cls");
	cout<<"1->Crear Vertices."<<endl;
	cout<<"2->Enlazar Vertices."<<endl;
	cout<<"3->Algoritmo de Prim."<<endl;
	cout<<"4->Salir"<<endl;
	fflush(stdin);
	cin>>op;
	return op;
}

char leerVertice(string cadena)
{
    char letra ='s';
    cout<<cadena<<endl;
    fflush(stdin);
    cin>>letra;
    return letra;
}

int leerEntero(string cadena)
{
    int letra = 0;
    cout<<cadena<<endl;
    fflush(stdin);
    cin>>letra;
    return letra;
}

void crearVertice(void)
{
    char let = 's';
    int ban = 0;
    system ("cls");
    let = leerVertice("Digite la letra del vertice: ");
    nue = new vertice;
    nue->nod = let;
    nue->marca = 0;
    nue->sig = NULL;
    nue->arc = NULL;
    if (pri == NULL)
    {
        pri = nue;
        ult = pri;
        cout << "\nNodo registrado correctamente.";
     }
    else 
    {
        while(existe(let,pri))
            let = leerVertice("Digite la letra del vertice: ");

          nue->nod = let;
          ult->sig = nue;
          ult = nue;
          cout << "\nNodo registrado correctamente.";
     }     
     
     cin.get();         
}

void enlazarVertices(void)
{
    int ban = 0, ban3 = 0,ban4 = 0;
    char auxNod,auxNod2;
     system ("cls");
     if (pri != NULL)
     {
        for(aux = pri;aux != NULL;aux = aux->sig)
            cout << aux->nod << "\n";
		
        do
        {
            auxNod = leerVertice("\nDigite la letra del nodo al cual desea enlazar: ");        
          
        }while(!existe(auxNod,pri));
        cout << "\nEstos son los nodos disponibles para hacer el respectivo enlace:\n";
        
        for(aux2 = pri;aux2->nod != auxNod;aux2 = aux2->sig);
        
        for(aux = pri;aux != NULL;aux = aux->sig)
              if (aux->nod != auxNod)
              {
                ban4 = 0;
                for(auxArc = aux2->arc;auxArc != NULL && ban4 == 0;auxArc = auxArc->sig)
                    if (aux->nod == auxArc->ver->nod)
                           ban4 = 1;
                        
                if (ban4 == 0)
                    cout << aux->nod << "\n";
                  
              }
              
        do
        {
            auxNod2 = leerVertice("\nDigite la letra del nodo al cual desea enlazar el nodo elegido: ");
       
        }while((auxNod2 == auxNod)&&!existe(auxNod2,pri));     
        
        for(aux = pri;aux->nod != auxNod;aux = aux->sig);
        ban3 = 0;
        for(auxArc = aux->arc;auxArc != NULL && ban3 == 0;auxArc = auxArc->sig)
            if (auxArc->ver->nod == auxNod2)
                ban3 = 1;
              
    if (ban3 == 0)
        enlazar(auxNod,auxNod2);
         
    else 
        cout << "\nEse enlace ya existe. Compruebe el enlace la proxima vez.";
    }
}

void enlazar (char auxNod, char auxNod2)
{
    int enlace = 0;
    for(aux = pri;aux->nod != auxNod;aux = aux->sig);
    for(aux2 = pri;aux2->nod != auxNod2;aux2 = aux2->sig);
        
    do
    {
        enlace = leerEntero("\nDigite el valor positivo del enlace: ");
    }while(enlace<0);
    
    //arco auxiliar 1 apunta al vertice
    nueArc = new arco;
    nueArc->ver = aux2;
    nueArc->clave = enlace;
    nueArc->marca = 0;
    nueArc->suma = 0;
    nueArc->sig = NULL;
              
    if (aux->arc == NULL)
    {
        aux->arc = nueArc;
        
        //arco de auxiliar 2 apunta al vertice
        
        nueArc = new arco;
        nueArc->ver = aux;           
        nueArc->clave = enlace;
        nueArc->marca = 0;
        nueArc->suma = 0;
        nueArc->sig = NULL;
        
        if (aux2->arc == NULL)
            aux2->arc = nueArc;
        else 
        {
            auxArc = aux2->arc;
            for( ; auxArc->sig != NULL ; auxArc = auxArc->sig);
            
            auxArc->sig = nueArc;
        }
    }
    
    else 
    {
        auxArc = aux->arc;
        for(;auxArc->sig != NULL;auxArc = auxArc->sig); 
        auxArc->sig = nueArc;
        
        //auxiliar dos
        
        nueArc = new arco;
        nueArc->ver = aux;
        nueArc->clave = enlace;
        nueArc->marca = 0;
        nueArc->suma = 0;
        nueArc->sig = NULL;
        
        if (aux2->arc == NULL)
            aux2->arc = nueArc;
        else 
        {
            auxArc = aux2->arc;
            for(;auxArc->sig != NULL;auxArc = auxArc->sig);
            
            auxArc->sig = nueArc;
        }
    }
    cout << "\nEnlace creado correctamente.";
}

void obtenerArcoMenor(void)
{
     arcMen = NULL;
     for(aux2 = pri;aux2 != NULL;aux2 = aux2->sig)
        if (aux2->marca == 1)
            for(auxArc = aux2->arc;auxArc != NULL;auxArc = auxArc->sig)
                if (auxArc->marca == 1)
                {
                    if (arcMen == NULL)
                        arcMen = auxArc;
                    else if (auxArc->clave < arcMen->clave)
                            arcMen = auxArc;
                                       
                    
                }
    arcMen->marca = 3;
    arcMen->ver->marca = 1;
    
    
    cout << "\nEl arco menor es: "<< arcMen->ver->nod << " vale: " << arcMen->clave;
    cin.get();
    aux = arcMen->ver;
    for(auxArc = aux->arc ; auxArc != NULL;auxArc = auxArc->sig)
    {
        if (auxArc->ver->marca == 0)
        {
            for(aux2 = pri ; aux2 != NULL;aux2 = aux2->sig)
                if(aux2 != aux && aux2->marca == 1)
                    for(auxArc2 = aux2->arc ; auxArc2 != NULL;auxArc2 = auxArc2->sig)
                        if (auxArc->ver->nod == auxArc2->ver->nod)
                        {
                            if (auxArc->clave < auxArc2->clave)
                            {
                                auxArc2->marca = 2;
                                auxArc->marca = 1;
                            }
                            else 
                            {
                                auxArc->marca = 2;
                                auxArc2->marca = 1;
                            }
                        }
                    
        if (auxArc->marca == 0)
            auxArc->marca = 1;
        
        }
        else 
            auxArc->marca = 2;
        
        
    }
    
}

void algoritmoPrim(void) 
{
    char auxNod;
    system("cls");
    if (pri != NULL)
    {
        actualizarCampos();
        do
        {
            auxNod = leerVertice("Digite el vertice inicial: ");
        }while(!existe(auxNod,pri));
        
        for(aux = pri ; aux->nod!=auxNod ; aux = aux->sig);
        
        aux->marca = 1;
        for(auxArc = aux->arc ; auxArc != NULL;auxArc = auxArc->sig)
            auxArc->marca = 1;
            
        cout << "\nSe han marcado todos los arcos para el vertice elegido.";
        do
        {
            obtenerArcoMenor();
  
        }while(verificar(0,pri));
        listarAdyacenciaPrim ();
        cout<<"\nLa suma de los caminos es: "<<sumarCaminos(pri)<<endl;
     }
     cin.get();
}

int sumarCaminos(vertice *pri) 
{
     int suma = 0;
     for(vertice *aux = pri ; aux != NULL ; aux = aux->sig)
        for(arco *auxArc = aux->arc ; auxArc != NULL ; auxArc = auxArc->sig)
            if (auxArc->marca == 3)
                suma = suma + auxArc->clave;
    return suma;
}

void listarAdyacenciaPrim(void)
{
    cout << "\n---Lista de Adyacencia---\n";
    for(aux = pri ; aux != NULL ; aux = aux->sig)
    {
        cout << "\n|\n" << aux->nod << "->";
        for( auxArc = aux->arc ; auxArc != NULL ; auxArc = auxArc->sig )
            if (auxArc->marca == 3)
                cout << auxArc->ver->nod << " ";   
    }
}

void actualizarCampos(void)
{
     for(aux = pri ; aux != NULL ; aux = aux->sig)
     {
        for(auxArc = aux->arc ; auxArc != NULL ; auxArc = auxArc->sig)
        {
            auxArc->marca = 0;
            auxArc->suma = 0;
        }
        aux->marca = 0;
    }
}

        public static void Main()
        {
            int opcion = 0;
            do
            {
		        opcion = menu();
		        if(opcion==1) 
			        crearVertice();
		        else if(opcion==2)
                    enlazarVertices();
                else if(opcion == 3)
        	        algoritmoPrim();
		        cout<<endl;
    	        system("pause");  
	        }while(opcion!=4);

        }
    }
}





    }
}
