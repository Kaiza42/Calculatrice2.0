using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            bool vrai = true;
            double saisie;
            double saisieDeux;
            string espace = "";
            int hauteur = 40;
            void TableDeMultiplication()
            {

                for (int n = 0; n <= saisie; n++)
                {
                    for (int j = 0; j <= saisie - n; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int c = 0; c < n; c++)
                    {
                        Console.Write(c * saisie + " ");
                    }
                    Console.WriteLine();
                }
            }
            

            void Additioner()
            {
                double somme = saisie + saisieDeux;
                Console.WriteLine("la somme des votre calcul est : " + somme);
            }

            void Multiplier()
            {
                double somme = saisie * saisieDeux;
                Console.WriteLine("la somme des votre calcul est : " + somme);
            }

            void Diviser()
            {
                double somme = saisie / saisieDeux;
                Console.WriteLine("la somme des votre calcul est : " + somme);
            }
            void Soustraction()
            {
                double somme = saisie - saisieDeux;
                Console.WriteLine(somme);
               
            }
            void Modulo()
            {
                double somme = saisie % saisieDeux;
                Console.WriteLine("la somme des votre calcul est : " + somme);
            }



           
            while (vrai)
            {

             

                Console.WriteLine("Calculatrice\n");
                Console.WriteLine(" 1 : Addition ");
                Console.WriteLine(" 2 : Multiplication ");
                Console.WriteLine(" 3 : Division ");
                Console.WriteLine(" 4 : Soustraction ");
                Console.WriteLine(" 5 : Pourcentage ");
             saisie = double.Parse(Console.ReadLine());
             saisieDeux = double.Parse(Console.ReadLine());
                switch (saisie)
                {
                    case 0:

                        break;
                    case 1:
                        Console.Write(saisie + " + " + saisieDeux + " = ");
                        Additioner();

                        break;
                    case 2:
                        Console.Write(saisie + " x " + saisieDeux + " = ");
                        Multiplier();
                        break;
                    case 3:
                        Console.Write(saisie + " / " + saisieDeux + " = ");
                        Diviser();
                        break;
                    case 4:
                        Console.Write(saisie + " - " + saisieDeux + " = ");
                        Soustraction();
                        break;
                    case 5:
                        Console.Write(saisie + " % " + saisieDeux + " = ");
                        Modulo();

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:

                        break;
                    case '+':

                        break;
                    case '-':

                        break;
                    case '*':

                        break;
                    case '/':

                        break;



                }

            }

        }
    }
}

//for (int n = 0; n <= 10; n++)
//{

//    for (int c = 0; c <= 10; c++)
//    {
//        int j = c * n;
//        Console.WriteLine("La multiplication donne " + c + "*" + n + "=" + j);


//    }
//}
