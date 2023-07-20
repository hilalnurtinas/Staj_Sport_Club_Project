using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubProject
{
    public class Member
    {
        private string name;
        private double credit;
        ClubCard card;

        public Member(string name, double credit)
        {
            this.Name = name;
            this.Credit = credit;

            card = new ClubCard(credit);
        }

        public string Name { get => name; set => name = value; }
        public double Credit { get => credit; set => credit = value; }
        public ClubCard Card { get => card; set => card = value; }


        public void registerCourse(Sports sport)
        {
            card.registerCourse(sport);
        }

        public void listCourse()
        {
            card.listCourses();
        }

        public void getInfo()
        {
            Console.WriteLine(" Uye Adı: " + Name + "\t Card ID: " + card.Id);
        }
    }
}
