
using System;

namespace pruebatorreshanoi
{

    class TorresDeHanoi
    {

        private int numDiscos; //numero de discos a mover

        public TorresDeHanoi(int discos)
        {

            this.numDiscos = discos;

        }

        public void resolverTorres(int discos, int agujaOrigen,
        int agujaDestino, int agujaTemp)
        {
        
            //caso base -- solo hay que mover un disco
        
            if(discos == 1)
            {

                Console.WriteLine("\n" + agujaOrigen + " --> " + agujaDestino);
            
                return;
            
            }
            //paso recursivo -- mueve(disco -1) discos de agujaOrigen
            //a agujaTemp usando agujaDestino
        
            resolverTorres(discos-1,agujaOrigen,agujaTemp,agujaDestino);
        
            //mueve el ultimo disco de agujaOrigen a agujaDestino

            Console.WriteLine("\n"+agujaOrigen+" --> "+agujaDestino);
        
            resolverTorres(discos-1,agujaTemp,agujaDestino,agujaOrigen);
        
        }

    }

    public class PruebaTorresHanoi
    {

        public static void Main(string[] args)
        {

            int agujaInicial = 1;
            int agujaFinal = 3;
            int agujaTemp = 2;
            int totalDiscos = 3;

            TorresDeHanoi torresDeHanoi = new TorresDeHanoi(totalDiscos);

            torresDeHanoi.resolverTorres(totalDiscos, agujaInicial, agujaFinal, agujaTemp);
            Console.ReadKey(true);
        }

    }
}