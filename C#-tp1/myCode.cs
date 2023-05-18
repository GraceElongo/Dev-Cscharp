
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

        Console.WriteLine("Veuillez saisir 5 nombres entiers :");

        for (int i = 0; i < nombres.Length; i++)
        {
            Console.Write($"Nombre {i + 1}: ");
            nombres[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Les nombres pairs saisis sont :");

        foreach (int nombre in nombres)
        {
            if (nombre % 2 == 0)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}

