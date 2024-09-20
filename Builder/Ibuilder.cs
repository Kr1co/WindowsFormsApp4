using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp4.Com;

namespace WindowsFormsApp4.Builder
{
    public interface Ibuilder
    {
        Ibuilder AddCheese();
        Ibuilder AddBacon();
        Ibuilder AddLetuce();
        Ibuilder AddTomato();
        Ibuilder AddPickles();
        Burgers GetBurgers();
    }
}
