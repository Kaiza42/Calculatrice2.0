using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stocke le resultat 
            double resultat = 0;
            //permet de fermer la boucle
            bool vrai = true;
            //variable de saisie utilisateur
            double saisie;
            //deuxieme variable de saisie utilisateur
            double saisieDeux;
            //Cette fonction va devenir un carrer 
            
            
            // fonction d'addition
            void Additioner()
            {
                // la boucle gere la saisie si la saisie ne correspond pas a ce qui est attendue alors recomencez 
                while (!double.TryParse(Console.ReadLine(), out saisieDeux))
                {
                    Console.WriteLine("La saisie n'est pas ce qui est attendue. ");
                    Console.Write("\tEntrez un nombre : ");
                }
                //calcul de l'addition
                resultat = saisie + saisieDeux;
            }
            // Multiplication
            void Multiplier()
            {
                // la boucle gere la saisie si la saisie ne correspond pas a ce qui est attendue alors recomencez 
                while (!double.TryParse(Console.ReadLine(), out saisieDeux))
                {
                    Console.WriteLine("La saisie n'est pas ce qui est attendue.");
                    Console.Write("\tEntrez un nombre : ");
                }
                //Calcul de la multiplication
                resultat = saisie * saisieDeux;
            }
            //  division
            void Diviser()
            {
                // la boucle gere la saisie si la saisie ne correspond pas a ce qui est attendue alors recomencez 
                while (!double.TryParse(Console.ReadLine(), out saisieDeux))
                {
                    Console.Clear();
                    Console.WriteLine("La saisie n'est pas ce qui est attendue.");
                    Console.Write("\tEntrez un nombre : ");
                }
                //condition pour éviter les 0 dans la saisie de la division 
                if (saisieDeux == 0 || saisie == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Je ne divise pas par 0");
                }
                else
                {
                    // calcul de la division 
                    resultat = saisie / saisieDeux;

                }
            }
            //Cette fonction sert a que je puisse clear et refaire aparaitre mon menu 
            void Affichage(){
                //De l'affichage et de la gestion de couleur 
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\t\t\t\t╔═════════════════════════════════╗");
                Console.WriteLine("\t\t\t\t║ + : Addition                    ║");
                Console.WriteLine("\t\t\t\t║ x : Multiplication              ║");
                Console.WriteLine("\t\t\t\t║ / : Division                    ║");
                Console.WriteLine("\t\t\t\t║ - : Soustraction                ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\t\t\t\t║ 0 : Arreter la calculatrice     ║");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\t\t║ 1 : Recomencez                  ║");
                Console.WriteLine("\t\t\t\t╚═════════════════════════════════╝ \n");
                Console.ResetColor();
            }
            //  soustraction
            void Soustraction()
            {
                // la boucle gere la saisie si la saisie ne correspond pas a ce qui est attendue alors recomencez 
                while (!double.TryParse(Console.ReadLine(), out saisieDeux))
                {
                    Console.WriteLine("Erreur de saisie. Veuillez entrer un nombre valide.");
                    Console.Write("\tEntrez un nombre : ");
                }
                resultat = saisie - saisieDeux;
            }
            // La boucle infinie
            while (vrai)
            {
                Affichage();
                //Si resultat est différent de 0 
                if (resultat != 0)
                {
                    Console.WriteLine("Le dernier resulat est : " + resultat);
                    Console.WriteLine("Appuyer sur 'o' si vous souhaitez garder votre resultat, si vous choisissez cette option votre resultat seras effacer");
                    // Je precise cet affichage ca rje n'ai reussi a corriger une erreure ce qui mene l'utilisateur sa ne pas rencontrer cette erreure
                    Console.WriteLine("Ou appuyer une fois sur n'importe quel autre touche pour recomencez au debut pour un nouveau calcul");
                    Console.Write("Votre choix est : ");
                    // j'ai pas reussi a gerer cette erreure j'ai fait de multiple essaie mais celle ci me pose probleme Je pense que c'est le tout qui devrais etre changer 
                    char reponse = Convert.ToChar(Console.ReadLine());
                    //o pour OUI 
                    if (reponse == 'o' || reponse == 'O')
                    {
                        Console.WriteLine("Vous avez choisie de garder votre resultat " + resultat);
                        // j'utilise le dernier resultat a la place de Saisie Pour ne prendre en compte qu'une seule saisie
                        saisie = resultat;
                    }
                    //le else c'est n pour NON 
                    else
                    {
                        //Je clear car j'aime pas voir ce que je fesais avant je trouve que sa fait un peu "bordelique"
                        Console.Clear();
                        // du coup j'appel ma fonction pour avoir mon menu 
                        Affichage();
                        Console.Write("\tEntrez un nombre : ");
                        // boucle pour dire que si la saisie attendue n'est pas bonne il recomence 
                        while (!double.TryParse(Console.ReadLine(), out saisie))
                        {
                            Console.WriteLine("Erreur de saisie. Veuillez entrer un nombre valide.");
                            Console.Write("\tEntrez un nombre : ");
                        }
                    }
                }
                // si resultat = 0 entrez un nombre 
                else
                {
                    Console.Write("\tEntrez un nombre : ");
                    // la boucle sert a gerer la saisie si la saisie ne correspond pas recomencez en gros
                    while (!double.TryParse(Console.ReadLine(), out saisie))
                    {
                        Console.WriteLine("Erreur de saisie. Veuillez entrer un nombre valide.");
                        Console.Write("\tEntrez un nombre : ");
                    }
                }
                Console.Write("saisissez un des choix proposer : ");
                //Cette partie je la trouve interessante a la base je fesais une gestion de chiffre pour mon switch case 
                // sa a évoluer dans un simple "char" a cause ou grace a la gestion d'erreure sa a un peu évoluer 
                // je ne souhaiter pas faire trop compliquer donc j'ai rechercher quelque choses de simple 
                // Du coup ma saisie se fait en format string 
                string saisieOperation = Console.ReadLine();
                // mais si ma saisie n'est pas strictement egal a 1 
                if (saisieOperation.Length == 1)
                {  
                    // mais si la saisie est strictement egal a 1 alors je convertie saisieoperation en operation qui est un char 
                    char operation = Convert.ToChar(saisieOperation);
                    //le switch prends en compte Operation qui est un char 
                    switch (operation)
                    {
                        // a titre personnel je n'aime pas trop Bourrer mes case ce que j'entend par bourrer c'est mettre tout et rien 
                        case '+':
                            //afichage pour entrer un nombre
                            Console.Write("\tEntrez un nombre : ");
                            // la fonction additioner
                            Additioner();
                            Console.Clear();
                            Console.WriteLine($" Le resultat de votre Addition est : {saisie} + {saisieDeux} = {resultat}\n");
                            break;
                        case 'x':
                            Console.Write("\tEntrez un nombre : ");
                            Multiplier();
                            Console.Clear();
                            Console.WriteLine($"Le resultat de votre Multiplication est : {saisie} x {saisieDeux} = {resultat}\n");
                            break;
                        case '/':
                            Console.Write("\tEntrez un nombre : ");
                            Diviser();
                            Console.Clear();
                            Console.WriteLine($"Le resultat de votre division est : {saisie} / {saisieDeux} = {resultat}\n");
                            break;
                        case '-':
                            Console.Write("\tEntrez un nombre : ");
                            Soustraction();
                            Console.Clear();
                            Console.WriteLine($"Le resultat de votre Soustraction est : {saisie} - {saisieDeux} = {resultat}\n");
                            break;
                        case '0':
                            Console.Write("Vous nous quittez deja ? choqué et deçue ...");
                            vrai = false;
                            break;
                        case '1':
                            Console.Clear();
                            Console.Write("vous souhaitez recomencez  ");
                            break;
                        // gere les certaine erreure de saisie pas toute
                        default:
                            Console.Clear();
                            Console.WriteLine("Erreure de saisie Veuillez recomencer la parmis les choix proposer :");
                            break;
                    }
                }
                // alors sa fait une erreure en disant que la saisie n'est pas prise en compte
                else
                {
                    Console.Clear();
                    Console.WriteLine("Veuillez saisir un caractère pris en compte.");
                }
            }
        }
    }
}