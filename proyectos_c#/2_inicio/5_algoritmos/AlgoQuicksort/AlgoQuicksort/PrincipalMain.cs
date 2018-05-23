using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoQuicksort
{
    public class PrincipalMain{
        public static void Main (){
            const int tamanio = 20;
            int[] arreglo=new int[tamanio];
            int x = 20;
            for(int i = 0; i < tamanio; i++){
                Console.WriteLine(x);
                arreglo[i] = x--;
            }
            Quicksort(arreglo, 0, tamanio - 1);
            Console.WriteLine("\nArreglo ordenado: ");
            for(int i = 0; i < tamanio; i++) {
                    Console.WriteLine(arreglo[i] + " ");
                }
            Console.ReadKey(true);
        }

        private static void Quicksort(int[] arr, int p, int r){
            if(p < r){
                int q = Particion(arr, p, r);
                Quicksort(arr, p, q - 1);
                Quicksort(arr, q + 1, r);
            }
        }

        private static int Particion(int[] arr, int p, int r){
            int x = arr[r];
            int i = p - 1, t;
            for(int j = p; j < r; j++){
                if(arr[j] <= x){
                    i++;
                    t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    }
                }
            t = arr[i + 1];
            arr[i + 1] = arr[r];
            arr[r] = t;
            return i + 1;
        }
    }
}
