using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace pruebas_consola
{
    internal class @string
    {
        string[] Vecpalabra = new string[500];
        string[] Vecpalabra1 = new string[500];
        string[] Vecpalabra2 = new string[500];
        string[] Vecpalabra3 = new string[500];
        string[] Vecpalabra4 = new string[500];
        string[] Vecpalabra5 = new string[500];

        public string[] Vecpalabra6 { get => Vecpalabra; set => Vecpalabra = value; }
        public string[] Vecpalabra11 { get => Vecpalabra1; set => Vecpalabra1 = value; }
        public string[] Vecpalabra21 { get => Vecpalabra2; set => Vecpalabra2 = value; }
        public string[] Vecpalabra31 { get => Vecpalabra3; set => Vecpalabra3 = value; }
        public string[] Vecpalabra41 { get => Vecpalabra4; set => Vecpalabra4 = value; }
        public string[] Vecpalabra51 { get => Vecpalabra5; set => Vecpalabra5 = value; }

        public void crear()
        {
            
            Random rnd = new Random();
            Console.WriteLine();
            Stopwatch tiempo = new Stopwatch();
            for (int i = 0; i < Vecpalabra6.Length; i++)
            {
                string palabra = "";
                for (int j = 0; j < 32; j++)
                {
                    palabra += (rnd.Next(10));
                }
                Vecpalabra6[i] = palabra;
            }
            for (int i = 0; i < Vecpalabra6.Length; i++)
            {
                Vecpalabra11[i] = Vecpalabra6[i];
                Vecpalabra21[i] = Vecpalabra6[i];
                Vecpalabra31[i] = Vecpalabra6[i];
                Vecpalabra41[i] = Vecpalabra6[i];
                Vecpalabra51[i] = Vecpalabra6[i];

            }
        }
        //burbuja
        public void burbuja2()
        {
            string aux;
            int contador = 0;
            bool bandera = false;
            for (int i = 0; i < Vecpalabra6.Length - 1; i++)
            {
                if (bandera)
                {
                    break;
                }
                bandera = true;
                for (int j = 0; j < Vecpalabra6.Length - i - 1; j++)
                {
                    if (float.Parse(Vecpalabra6[j]) < float.Parse(Vecpalabra6[j + 1]))
                    {
                        bandera = false;
                        aux = Vecpalabra6[j];
                        Vecpalabra6[j] = Vecpalabra6[j + 1];
                        Vecpalabra6[j + 1] = aux;
                    }
                    contador++;
                }
            }
        }
        
        
        
        //quick iterativo
        public void quickSortiterativo(string[] vectorIn)
        {

            int[] copiaVector = new int[vectorIn.Length];            // stack
            int sti = 0;                        // stack index
            copiaVector[sti++] = vectorIn.Length - 1;
            copiaVector[sti++] = 0;
            while (sti != 0)
            {
                int lo = copiaVector[--sti];
                int hi = copiaVector[--sti];
                while (lo < hi)
                {
                    // Hoare partition
                    int md = lo + (hi - lo) / 2;
                    int ll = lo - 1;
                    int hh = hi + 1;
                    string p = vectorIn[md];
                    string t;
                    while (true)
                    {
                         while (float.Parse(vectorIn[++ll]) < float.Parse( p)) ;
                        while (float.Parse(vectorIn[--hh]) > float.Parse( p)) ;
                        if (ll >= hh)
                            break;
                         t = vectorIn[ll];
                        vectorIn[ll] = vectorIn[hh];
                        vectorIn[hh] = t;
                    }
                    ll = hh++;
                    // ll = last left index, hh = first right index
                    // push larger partition indexes onto stack
                    // loop back for smaller partition
                    if ((ll - lo) > (hi - hh))
                    {
                        copiaVector[sti++] = ll;
                        copiaVector[sti++] = lo;
                        lo = hh;
                    }
                    else
                    {
                        copiaVector[sti++] = hi;
                        copiaVector[sti++] = hh;
                        hi = ll;
                    }
                }
            }
        }
        public void quickiterativo()
        {
            quickSortiterativo(Vecpalabra41);
    
        }




        //quick recursivo
        public void quick()
        {
             
            quicksort(Vecpalabra51, 0, Vecpalabra51.Length - 1);
            
        }
        private void quicksort(string[] vectorIn, int primero, int ultimo)
        {
            int i, j, central;
            string pivote;
            central = (primero + ultimo) / 2;
            pivote = vectorIn[central];
            i = primero;
            j = ultimo;
            while (i <= j)
            {
                while (float.Parse(vectorIn[i]) < float.Parse((pivote)) )i++;
                {
                    while (float.Parse(vectorIn[j] )> float.Parse(pivote)) j--;
                    {
                         
                        if (i <= j)
                        {
                         
                            string temp;
                            temp = vectorIn[i];
                            vectorIn[i] = vectorIn[j];
                            vectorIn[j] = temp;
                            i++;
                            j--;
                        }
                    }
                }
            }

            if (primero < j)
            {
                quicksort(vectorIn, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vectorIn, i, ultimo);
            }
        }

    }
}
