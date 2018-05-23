using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mergesort
{
    class MergeSort1{
        private int[] A;
        private const int ls = 20;
         public MergeSort1(){
             A = new int[ls];
         }
         public int[] OrdenaMerge(int[] L) {
            int n = L.Length;
 
            if (n > 1){
                int m = (int) (Math.Ceiling(n/2.0));
                int [] L1 = new int[m];
                int [] L2 = new int[n-m];
                for(int i = 0 ; i<m; i++){
                    L1[i]=L[i];
                    }
             
                for (int i = m; i < n; i++){
                    L2[i-m] = L[i];
                }
                L = merge(OrdenaMerge(L1), OrdenaMerge(L2));
            }
            return L;
        }
 
        public int[] eliminar(int [] l){
            int [] L = new int[l.Length-1];
            for(int i = 1; i < l.Length; i++){
                L[i-1] = l[i];
            }
            return L;
        }
 
        public int[] merge(int[] L1, int[] L2) {
             int[] L = new int[L1.Length+L2.Length];
             int i = 0;
             while ((L1.Length != 0) && (L2.Length != 0)) {
                 if (L1[0] < L2[0]){
                     L[i++] = L1[0];
                     L1 = eliminar(L1);
                     if (L1.Length == 0){
                         while (L2.Length != 0) {
                             L[i++] = L2[0];
                             L2 = eliminar(L2);
                         }
                     }
                 }
                 else{
                     L[i++] = L2[0];
                     L2 = eliminar(L2);
                     if (L2.Length == 0) {
                        while (L1.Length != 0) {
                             L[i++] = L1[0];
                             L1 = eliminar(L1);
                        }
                     }
                 }
             }
             return L;
        }
 
        public void generarNumeros(){
            Random ran = new Random();
            int x;
            for(int i = 0; i < A.Length; i++){
                x = (int)(ran.Next()*10000);
                A[i] = x;
            }
        }
 
        public void imprimir(){
            for(int i = 0; i < A.Length; i++){
                Console.WriteLine(A[i]);
            }
        }
 
        public int[] getA(){
            return A;
        }
 
        public void setA(int []A){
            this.A = A;
        }
    }

    public class Mergesort {
        public static void Main() {
            const int l = 20;
            int[] arr = new int[l];
            int x = l;
            for(int i = 0 ; i < l;i++){
                Console.WriteLine(x);
                arr[i] = x--;
            }
            MergeSort1 mer = new MergeSort1();
            arr=mer.OrdenaMerge(arr);
            foreach(int i in arr){
                Console.WriteLine(i);
            }
            Console.ReadKey(true);
        }
    }
}
