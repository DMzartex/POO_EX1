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
                totalAge = totalAge + mesChiens[i].AfficheAge();
            }
            resultMoyenne = totalAge / nbrChien;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenu dans notre chenil !");
            int nbrChien = 0;
            int agetotal = 0;
            int resultMoyenne;
            Chien[] mesChiens;
            Console.WriteLine("Combien de chiens voulez vous insérer ?");
            nbrChien = int.Parse(Console.ReadLine());

            insertChien(nbrChien, out mesChiens);
            afficheChien(mesChiens);
            moyenneAge(nbrChien,mesChiens,out resultMoyenne);
            Console.WriteLine("La moyenne d'age des chiens est de :" + resultMoyenne);

            
        }
    }
}