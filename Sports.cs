using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClubProject
{
    public class Sports
    {

        private string name;
        private int session;
        private double price;

        public Sports(string name, int session, double price)
        {
            this.name = name;
            this.session = session;
            this.price = price;

        }

        public string Name { get => name; set => name = value; }
        public int Session { get => session; set => session = value; }
        public double Price { get => price; set => price = value; }


    }
}
