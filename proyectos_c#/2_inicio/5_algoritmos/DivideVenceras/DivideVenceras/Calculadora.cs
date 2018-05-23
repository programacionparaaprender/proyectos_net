using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DivideVenceras
{
    public class Calculadora {
        public Calculadora(){
            }
        private bool verificar(string a, string b){
            try{
                int ax = int.Parse(a);
                int bx = int.Parse(b);
                return true;
            }
            catch(Exception){
                return false;
            }
        }
        private bool impar(string a){
            if(a.Length%2==1){return true;}
            return false;
            }
        public long reslizarCalculo(string a,string b){
            if(verificar(a,b)){
                if(impar(a)){ a="0"+a;}
                if(impar(b)){ b="0"+b;}
                long x=0,m=a.Length-2,k = b.Length-2;
                try
                {
                    Console.WriteLine("A= " + a + " B= " + b);
                    for (int i = 0; i < a.Length - 1; i += 2)
                    {
                        k = b.Length - 2;
                        for (int j = 0; j < b.Length - 1; j += 2)
                        {
                            Console.WriteLine("A= " + a.Substring(i, i + 2) +
                                    " B= " + b.Substring(j, j + 2));
                            x = /*x + (long)(Math.Pow(10, k + m) * int.Parse(
                                    a.Substring(i, i + 2)) * int.Parse(
                                    b.Substring(j, j + 2)));
                                 */
                                x + (long)(Math.Pow(10, k + m) * 
                                (((int)a[i]-48)*10+(int)a[i+1]) -48)* (((int)b[j]-48)*10+(int)(b[j+1])-48);
                            k -= 2;
                        }
                        m -= 2;
                    }
                }
                catch (Exception)
                {
                }
                return x;
            }
            return 0;
        }
    }

}
