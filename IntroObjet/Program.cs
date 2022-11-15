using System;

namespace IntroObjet 
{
    class Program
    {
        static void insertChien(int nbrChien, out Chien[] mesChiens)
        {
            mesChiens = new Chien[nbrChien];
            for (int i = 0; i < nbrChien; i++)
            {
                Console.WriteLine("Quel est le nom du chien ?");
                string nomChien = Console.ReadLine();
                Console.WriteLine("Quelle est la race ?");
                string raceChien = Console.ReadLine();
                Console.WriteLine("Quel l'age du chien ?");
                int ageChien = int.Parse(Console.ReadLine());
                mesChiens[i] = new Chien(nomChien, raceChien, ageChien);
            }   

        }

        static void afficheChien(Chien[] mesChiens)
        {
            for (int i = 0; i < mesChiens.Length; i++)
            {
                Console.WriteLine(mesChiens[i].AfficherCaracteristiques());
            }
        }

        static void moyenneAge(int nbrChien, Chien[] mesChiens, out int resultMoyenne)
        {
            resultMoyenne = 0;
            int totalAge = 0;
            for(int i = 0; i < mesChiens.Length; i++)
            {
                totalAge = totalAge + mesChiens[i].Age;
            }
            resultMoyenne = totalAge / nbrChien;
        }
        static void modifAge(Chien[] mesChiens)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans notre chenil !");
            int nbrChien = 0;
            int agetotal = 0;
            int resultMoyenne;
            string modifAge;
            int choixChien;
            int ajoutAge;
            Chien[] mesChiens;
            Console.WriteLine("Combien de chiens voulez vous insérer ?");
            nbrChien = int.Parse(Console.ReadLine());
            insertChien(nbrChien, out mesChiens);
            afficheChien(mesChiens);
            Console.WriteLine("Voulez vous modifier l'âge d'un chien ?");
            modifAge = Console.ReadLine();

            while (modifAge == "Y" || modifAge == "y")
            {
                Console.WriteLine("Quel est le chien que vous voulez modifier ?");
                if(int.TryParse(Console.ReadLine(), out choixChien) && choixChien <= mesChiens.Length)
                {
                    Console.WriteLine("Quel est l'âge du chien ?");
                    if(int.TryParse(Console.ReadLine(), out ajoutAge))
                    {
                        mesChiens[choixChien].Age = ajoutAge;
                        
                    }
                    else
                    {
                        Console.WriteLine("Vous devez obligatoirement entré un nombre");
                    }
                }
                else
                {
                    Console.WriteLine("Vous devez obligatoirement introduire un chiffre qui correspond à l'id d'un chien !");
                }
                afficheChien(mesChiens);
                Console.WriteLine("Voulez vous à nouveau moddifier l'age d'un chien ?");
                modifAge= Console.ReadLine();

            }

            moyenneAge(nbrChien, mesChiens, out resultMoyenne);
            Console.WriteLine("La moyenne d'age des chien est :" + " " + resultMoyenne);
            
        }
    }
}