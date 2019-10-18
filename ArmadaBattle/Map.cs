using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArmadaBot.ArmadaBattle
{
    public class Map
    {
        string ID;
        string number;
        bool[,] coords = new bool[400, 400];
        int Island_x;
        int Island_y;
    }
}
