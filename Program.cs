using System;

namespace combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            string ops, uops;
            int rep;
            float gl, al;
            double  vg, va, vdg, vda, vdg2, vda2, vta, vtg, vfa, vfg;

            va = 4.90;
            vg = 5.30;
            rep = 1;
            do
            {
                Console.WriteLine("Abastecendo\n-----------------\nVocê deseja abastecer com álcool ou gasolina?\n[A] Álcool\n[G] Gasolina");
                ops = Console.ReadLine();
                uops = ops.ToUpper();
                while (uops != "A" && uops != "G")
                {
                    Console.WriteLine("Opção inválida.\n[A] Álcool\n[G] Gasolina");
                }
                switch (uops)
                {
                    case "A":
                        Console.WriteLine($"Quantos litros de álcool você deseja abastecer?");
                        al = int.Parse(Console.ReadLine());
                        if (al <= 20)
                        {
                            Console.WriteLine("Você ganhou 3% de desconto por litro no álcool!");
                            vda = (3 / 100) * va;
                            vda2 = vda * al;
                            vta = al * va; 
                            vfa = vta - vda2;
                            Console.WriteLine($"Valor total com desconto: R$ {vfa}");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou 5% de desconto por litro no álcool!");
                            vda = (5 / 100) * va;
                            vda2 = vda * al;
                            vta = al * va; 
                            vfa = vta - vda2;
                            Console.WriteLine($"Valor total com desconto: R$ {vfa}");
                        }
                    break;

                    default:
                        Console.WriteLine($"Quantos litros de gasolina você deseja abastecer?");
                        gl = int.Parse(Console.ReadLine());
                        if (gl <= 20)
                        {
                            Console.WriteLine("Você ganhou 3% de desconto por litro no álcool!");
                            vdg = (3 / 100) * va;
                            vdg2 = vdg * gl;
                            vtg = gl * vg; 
                            vfg = vtg - vdg2;
                            Console.WriteLine($"Valor total com desconto: R$ {vfg}");
                        }
                        else
                        {
                            Console.WriteLine("Você ganhou 5% de desconto por litro no álcool!");
                            vdg = (5 / 100) * vg;
                            vdg2 = vdg * gl;
                            vtg = gl * vg; 
                            vfg = vtg - vdg2;
                            Console.WriteLine($"Valor total com desconto: R$ {vfg}");
                        }
                    break;
                }
                Console.WriteLine("Deseja reabastecer novamente?\n[1] SIM\n[2] NÃO");
                rep = int.Parse(Console.ReadLine());
                while (rep != 1 && rep !=2)
                {
                    Console.WriteLine("Opção inválida\n[1] SIM\n[2] NÃO");
                }
            } while (rep == 1);
            Console.WriteLine($"Obrigado! Tchau");
        }
    }
}
