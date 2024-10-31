using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_pbl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double L, Vrel, Varr, vetVrel_i, vetVrel_j, theta;

            try
            {
                while (true)
                {
                    Console.Write("Digite a largura L do rio (escolha entre 20 m a 100 m): ");
                    L = double.Parse(Console.ReadLine());

                    if (L < 20 || L > 100)
                    {
                        Console.WriteLine("Digite um valor entre o intervalo de 20 m a 100 m!");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Digite o valor da velocidade relativa (Vrel) do motor em relação a água (escolha entre 2 m/s a 10 m/s): ");
                    Vrel = double.Parse(Console.ReadLine());

                    if (Vrel < 2 || Vrel > 10)
                    {
                        Console.WriteLine("Digite um valor entre o intervalo de 2 m/s a 10 m/s!");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Digite o valor da velocidade de arrastamento (Varr) da correnteza (escolha entre 1 m/s a 4 m/s): ");
                    Varr = double.Parse(Console.ReadLine());

                    if (Varr < 1 || Varr > 4)
                    {
                        Console.WriteLine("Digite um valor entre o intervalo de 1 m/s a 4 m/s!");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.Write("Digite o ângulo Theta do barco em relação a margem de origem (considere 20° < θ < 160°): ");
                    theta = int.Parse(Console.ReadLine());
                    if (theta < 20 || Varr > 160)
                    {
                        Console.WriteLine("Digite um valor entre o intervalo 20° < θ < 160°!");
                    }
                    else
                    {
                        break;
                    }
                }

                theta = theta * (Math.PI / 180);
                vetVrel_i = Vrel * Math.Cos(theta);
                vetVrel_j = Vrel * Math.Sin(theta);

                double Vres_i = vetVrel_i + Varr;
                double Vres_j = vetVrel_j;

                double thetaRes = Math.Atan(Vres_j / Vres_i) * (Math.PI / 180);

                double tempo_travessia = L / vetVrel_j;

                double Xf = Vres_i * tempo_travessia;
                double Yf = Vres_j * tempo_travessia;

                Console.WriteLine($"Vres = {Vres_i.ToString("f4")}i + {Vres_j.ToString("f4")}j; Tempo = {tempo_travessia.ToString("f3")}s; Xf = {Xf.ToString("f2")}m; Yf = {Yf}m");


                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Digite um número válido!");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }

    }
}
