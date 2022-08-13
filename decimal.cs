using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_consola
{
    internal class @decimal
    {
        static int x = 1000;
        Random rnd = new Random();    
        decimal[] vecdecimal ;
        decimal[] vecdecimal1 ;

        decimal[] vecdecimal2 ;

        decimal[] vecdecimal3 ;

        decimal[] vecdecimal4;

        decimal[] vecdecimal5 ;

        public decimal[] Vecdecimal1 { get => vecdecimal1; set => vecdecimal1 = value; }
        public decimal[] Vecdecimal2 { get => vecdecimal2; set => vecdecimal2 = value; }
        public decimal[] Vecdecimal3 { get => vecdecimal3; set => vecdecimal3 = value; }
        public decimal[] Vecdecimal4 { get => vecdecimal4; set => vecdecimal4 = value; }
        public decimal[] Vecdecimal5 { get => vecdecimal5; set => vecdecimal5 = value; }

        public void crear(int indice)
        {
            vecdecimal = new decimal[indice];
            Vecdecimal1 = new decimal[indice];
            Vecdecimal2 = new decimal[indice];
            Vecdecimal3 = new decimal[indice];
            Vecdecimal4 = new decimal[indice];
            Vecdecimal5 = new decimal[indice];

            for (int i = 0; i < vecdecimal.Length; i++)
            {
                vecdecimal[i] =Convert.ToDecimal( rnd.NextDouble());
            }
            for (int i = 0; i < vecdecimal.Length; i++)
            {
                Vecdecimal1[i] = vecdecimal[i];
                Vecdecimal2[i] = vecdecimal[i];
                Vecdecimal3[i] = vecdecimal[i];
                Vecdecimal4[i] = vecdecimal[i];
                Vecdecimal5[i] = vecdecimal[i];
            }
        }
        public void burbuja()
        {
            
           decimal aux = 0;
            int contador = 0;

            for (int i = 0; i < vecdecimal.Length - 1; i++)
            {


                for (int j = i + 1; j < vecdecimal.Length; j++)
                {
                   

                    if (Vecdecimal1[i] > Vecdecimal1[j])
                    {
                       
                        aux = Vecdecimal1[i];
                        Vecdecimal1[i] = Vecdecimal1[j];
                        Vecdecimal1[j] = aux;
                    }
                    contador++;

                }
            }
           
        }
      
        public void Seleccion()
        {
            

            int minimo = 0;
           decimal temp;
            for (int i = 0; i < Vecdecimal2.Length - 1; i++)
            {
                minimo = i;
                for (int j = i + 1; j < Vecdecimal2.Length; j++)
                {
                    
                    if (Vecdecimal2[minimo] > Vecdecimal2[j])
                    {

                        minimo = j;
                    }
                }
               
                temp = Vecdecimal2[minimo];
                Vecdecimal2[minimo] = Vecdecimal2[i];
                Vecdecimal2[i] = temp;
            }
            
        }
        public void MergeSort()
        {
            
            MergeSort(0, Vecdecimal3.Length - 1);
         
        }

        private void MergeSort(int desde, int hasta)
        {
            //Condicion de parada
            if (desde == hasta)
                return;
            //Calculo la mitad del vector
            int mitad = (desde + hasta) / 2;
            //Voy a ordenar recursivamente la primera mitad
            //y luego la segunda
            MergeSort(desde, mitad);
            MergeSort(mitad + 1, hasta);
            //Mezclo las dos mitades ordenadas
            decimal[] aux = Merge(desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, Vecdecimal3, desde, aux.Length);
        }

        //Método que mezcla las dos mitades ordenadas
        private decimal[] Merge(int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            decimal[] result = new decimal[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {
                if (b != Vecdecimal3.Length)
                {
                     
                    if (a > hasta1 && b <= hasta2)
                    {
                      
                        result[i] = Vecdecimal3[b];
                        b++;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                       
                        result[i] = Vecdecimal3[a];
                        a++;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        if (Vecdecimal3[b] <= Vecdecimal3[a])
                        {
                          
                            result[i] = Vecdecimal3[b];
                            b++;
                        }
                        else
                        {
                             
                            result[i] = Vecdecimal3[a];
                            a++;
                        }
                    }
                }
                else
                {
                     
                    if (a <= hasta1)
                    {
                      
                        result[i] = Vecdecimal3[a];
                        a++;
                    }
                }
            }
            return result;

        }

        public void quickSortiterativo(decimal[] vectorIn)
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
                    decimal p = vectorIn[md];
                    decimal t;
                    while (true)
                    {
                         
                        while (vectorIn[++ll] < p) ;
                        while (vectorIn[--hh] > p) ;
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
       
            quickSortiterativo(Vecdecimal4);
          
        }

        public void quick()
        {
       
            quicksort(Vecdecimal5, 0, Vecdecimal5.Length - 1);
            
        }
        private void quicksort(decimal[] vectorIn, int primero, int ultimo)
        {
            int i, j, central;
            decimal pivote;
            central = (primero + ultimo) / 2;
            pivote = vectorIn[central];
            i = primero;
            j = ultimo;
            while (i <= j)
            {
                while (vectorIn[i] < pivote) i++;
                {
                    while (vectorIn[j] > pivote) j--;
                    {
                         
                        if (i <= j)
                        {
                            
                            decimal temp;
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

