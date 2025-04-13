using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    class Matriz
    {
        public static double[] Homogenar(double[][] M1, double[] M2)
        {
            double[] res = new double[M2.Length];
            for(int i = 0; i < M2.Length; i++)
            {
                bool flag = true;
                for(int j = 0; j < M2.Length; j++)
                {
                    if (flag)
                    {
                        res[i] = M1[i][j] * M2[j];
                        flag = !flag;
                    }
                    else
                        res[i] += M1[i][j] * M2[j];
                }
            }
            return res;
        }
    }
}
