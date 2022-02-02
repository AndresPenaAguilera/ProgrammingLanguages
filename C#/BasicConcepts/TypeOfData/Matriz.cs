using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConcepts.TypeOfData
{
    public class Matriz
    {

        public Matriz() 
        {
            Unidimensional();
            Multidimensional();
            Jagged_Escalonada();
        }

        private void Unidimensional()
        {
            double[] calification = { 1, 2, 3 };
            double[] calification2 = new double[4] { 1, 2, 3,4 };

            for (var i = 0; i < 4; i++) 
            {
                var value = calification2[i];
            }
        }
        private void Multidimensional()
        {
           //Matrix 4 X 3
            double[,] ventas = new double[4, 3] { {100, 120, 205},
                                                  {115, 196, 300},
                                                  {157, 172, 245},
                                                  {130, 180, 281} };

            //Matrix 3D
            /*
             Profundidad 1
             1  4
             7  10

             Profundidad 2
             2  5
             8  11

             Profundidad 3
             3  6
             9  12
             */
            double[,,] ventasAño = new double[2, 2, 3] { { { 1,2,3 },{ 4,5,6 } }, 
                                                         { { 7,8,9 },{ 10,11,12} } 
                                                       };

        }

        private void Jagged_Escalonada()
        {
            /*
             0= Unidimensional[3]
             1= Unidimensional[2]
             2= Unidimensional[4]
             3= Unidimensional[3]
             */

            double[][] ventas = new double[4][];
            ventas[0] = new double[3] { 155,100,170 };
            ventas[1] = new double[2] { 205, 120 };
            ventas[2] = new double[4] { 115,190,104,130 };
            ventas[3] = new double[3] { 163,218,125 };

            double[][] ventas2 = new double[][] {
                new double[3] { 155, 100, 170 },
                new double[2] { 205, 120 },
                new double[4] { 115, 190, 104, 130 },
                new double[3] { 163, 218, 125 }
            };
           



        }


    }
}
