using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Builder;

namespace WindowsFormsApp4.Builder
{
    public class BDirector
    {
        private readonly Ibuilder _builder;
        public BDirector(Ibuilder builder)
        {
            _builder = builder;
        }
        public void BuildDefault()
        {
            _builder
                .AddCheese()
                .AddTomato().
                AddPickles();
        }
        public void BuildWith() 
        {
            _builder
                .AddTomato()
                .AddBacon()
                .AddLetuce();
        }
    }
}
