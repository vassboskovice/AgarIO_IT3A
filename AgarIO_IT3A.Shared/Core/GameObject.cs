using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgarIO_IT3A.Shared.Core
{
    public abstract class GameObject
    {
        public Point Location { get; set; }
        public string Color { get; set; }
    }
}
