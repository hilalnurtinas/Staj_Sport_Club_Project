using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubProject
{
    public class ClubCard
    {
        private static int counter = 20230001;
        private int id;
        private double credit; //para miktarı
        Sports[] sports = new Sports[7]; //7 tane spor dalı tanımlanabilir  //hoca private yazmadı neden?

        public ClubCard(double credit)
        {
            this.credit = credit;   

            id = Counter++;    
        }

        public int Id { get => id; set => id = value; }
        public double Credit { get => credit; set => credit = value; }
        public Sports[] Sports { get => sports; set => sports = value; }
        public static int Counter { get => counter; set => counter = value; }

        public void registerCourse(Sports sport)
        {
            int i = 0;

            while (i < sports.Length && sports[i] != null)
            {
                i++;
            }
            
            if (i < sports.Length)
            {
                if (sport.Price <= credit)
                {
                    sports[i] = sport;
                    Console.WriteLine("{0} kursu basariyla eklendi.", sport.Name);
                    credit = credit - sport.Price;
                }
                else
                {
                    Console.WriteLine("Bakiye yetersiz!!!");
                }
            }
            else
            {
                Console.WriteLine("Üzgünüz. Maximum spor sayısına ulastınız...");
            }

        }

        public void listCourses()
        {
            int i = 0;

            while (i < sports.Length && sports[i] != null)
            {
                Console.WriteLine(sports[i].Name);
                i++;
            }
        }

    }
}
