using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgarIO_IT3A.Shared.Core
{
    public class Player : GameObject
    {
        public string Name { get; set; }

        public Player(string color, string name) : base()
        {
            Color = color;
            Location = new Point(0, 0);
            Name = name;
        }
    }
}
