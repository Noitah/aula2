using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    internal class CalculaCarro
    {
    }
namespace Model
    {
        public class CalculaAluguelCarro
        {
           
            public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
            {
                double diaria = 95.00;
                double valorPorKm = 0.35;

                
                int kmPercorridos = quilometragemFinal - quilometragemInicial;

                
                double valorTotal = (diaria * dias) + (valorPorKm * kmPercorridos);
                return valorTotal;
            }
        }
    }
