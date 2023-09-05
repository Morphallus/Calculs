/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse=0; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct=false; //ajout d'une variable de vérification d'erreur
            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                // affichage du menu et saisie du choix
               
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.Write("erreur de saisie : saisissez un nombre entier ; ");
                    }
                }
                
                // traitement des choix
                if (choix != 0)
                {
                    //Génération des 2 valeurs aléatoires
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);
                    if (choix == 1)
                    {
                        // choix de l'addition
                        // saisie de la réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " + " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.Write("erreur de saisie : saisissez un nombre entier ; ");
                            }
                        }
                        
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else if (choix ==2)
                    {
                        // choix de la multiplication
                        // saisie de la réponse
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                Console.Write(val1 + " x " + val2 + " = ");
                                reponse = int.Parse(Console.ReadLine());
                                correct = true;
                            }
                            catch
                            {
                                Console.Write("erreur de saisie : saisissez un nombre entier ; ");
                            }
                        }
                        
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saisie incorrecte ; entrez un choix compris entre 0 et 2 ");
                    }
                } 
            }
        }
    }
}
