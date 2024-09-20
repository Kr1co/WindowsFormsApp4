using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Com;

namespace WindowsFormsApp4.Builder
{
    public class Bbuilder : Ibuilder
    {
        private Burgers _burger;
        public Bbuilder()
        {
            _burger = new Burgers();
        }
        public Ibuilder AddBacon()
        {
            _burger.Bacon = true;
            return this;
        }

        public Ibuilder AddCheese()
        {
            _burger.Cheese = true;
            return this;
        }

        public Ibuilder AddLetuce()
        {
            _burger.Letuce = true;
            return this;
        }

        public Ibuilder AddPickles()
        {
            _burger.Pickles = true;
            return this;
        }

        public Ibuilder AddTomato()
        {
            _burger.Tomato = true;
            return this;
        }

        public Burgers GetBurgers()
        {
            Burgers burger = _burger;
            _burger = new Burgers();
            return burger;
        }
    }
}
