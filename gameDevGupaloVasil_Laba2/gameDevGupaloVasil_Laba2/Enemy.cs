using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameDevGupaloVasil_Laba2
{

    public abstract class Enemy : Interactable
    {
        public abstract int id { get; set; }
        public abstract string Name { get; set; }
        public abstract float HP { get; set; }
        public abstract float Speed { get; set; }
        public abstract float Damage { get; set; }


        public abstract void Attack();

        public abstract void Jump();

        public override string ToString()
        {
            return "Item: id=" + Convert.ToString(id) + " | " + Name;
        }
    }

    public class Infantryman : Enemy
    {
        public override int id { get; set; } = 1;
        public override string Name { get; set; } = "Піхотинець";
        public override float HP { get; set; } = 100;
        public override float Speed { get; set; } = 5;
        public override float Damage { get; set; } = 25;

        public override void Attack()
        {
            // Casts attack animation, does damage
        }

        public override void Jump()
        {
            // Casts jump animation, changes enemy's Y coord
        }
    }

    public class Rider : Enemy
    {
        public override int id { get; set; } = 1;
        public override string Name { get; set; } = "Вершник";
        public override float HP { get; set; } = 100;
        public override float Speed { get; set; } = 10;
        public override float Damage { get; set; } = 30;

        public override void Attack()
        {
            // Casts attack animation, does damage
        }

        public override void Jump()
        {
            // Casts jump animation, changes enemy's Y coord
        }
    }
}
