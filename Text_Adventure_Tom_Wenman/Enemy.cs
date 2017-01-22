using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Tom_Wenman
{
    public class Enemy
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }

    }
}
