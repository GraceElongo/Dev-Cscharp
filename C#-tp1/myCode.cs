
#  Permiere Question 
#=====================

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int nombreMystere = random.Next(0, 101);
        int tentative = 0;
        int nombreDevine = -1;

        Console.WriteLine("Bienvenue dans mon jeu de devinette d'un nombre !");
        Console.WriteLine("mon système à imager un nombre entre 0 et 100. À vous de deviner !");
        Console.WriteLine();

        while (nombreDevine != nombreMystere)
        {
            Console.Write("Entrez un nombre : ");
            string saisie = Console.ReadLine();

            if (!int.TryParse(saisie, out nombreDevine))
            {
                Console.WriteLine("Le nombre taper n'est pas valide (entier)");
                continue;
            }

            tentative++;

            if (nombreDevine < nombreMystere)
            {
                Console.WriteLine("Plus grand !");
            }
            else if (nombreDevine > nombreMystere)
            {
                Console.WriteLine("Plus petit !");
            }
            else
            {
                Console.WriteLine("Félicitations ! Vous avez trouvé pour votre reussite en {0} tentative(s).", tentative);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter...");
        Console.ReadKey();
    }
}



#  Deuxieme Question 
#=====================


using System;

class Program
{
    static void Main()
    {
        int[] nombres = new int[5];
        bool nombrePairSaisi = false;

        Console.WriteLine("Veuillez saisir 5 nombres entiers :");

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int nombre))
            {
                nombres[i] = nombre;
                if (nombre % 2 == 0)
                {
                    nombrePairSaisi = true;
                }
            }
            else
            {
                Console.WriteLine("Veuillez saisir un nombre entier. Réessayez.");
                i--; // Décrémente i pour répéter la saisie du nombre
            }
        }

        if (nombrePairSaisi)
        {
            Console.WriteLine("Les nombres pairs saisis sont :");
            foreach (int nombre in nombres)
            {
                if (nombre % 2 == 0)
                {
                    Console.WriteLine(nombre);
                }
            }
        }
        else
        {
            Console.WriteLine("Aucun nombre pair n'a été saisi.");
        }
    }
}


