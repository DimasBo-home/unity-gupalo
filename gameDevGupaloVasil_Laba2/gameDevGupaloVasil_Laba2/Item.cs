using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gameDevGupaloVasil_Laba2
{
    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public Size(int height, int width, int length)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
        }
        public override string ToString()
        {
            return "Size: Height=" + Convert.ToString(this.Height) + " | Width=" + Convert.ToString(this.Width) + " | Length=" + Convert.ToString(this.Length);
        }
    }

    public abstract class Item : Interactable
    {
        public abstract int id { get; set; }
        public abstract string Name { get; set; }
        public abstract Size size { get; set; }
        public abstract int Weight { get; set; }
        public abstract int Price { get; set; }
        public override string ToString()
        {
            return "Item: id=" + Convert.ToString(id) + " | " + Name;
        }
    }
    public abstract class Consumable : Item
    {
        public abstract void Consume();
    }

    public abstract class NonConsumable : Item
    {
        public abstract int Quality { get; set; }
    }

    public class FirstAidKit : Consumable
    {
        public override void Consume()
        {
            throw new System.NotImplementedException();
        }

        public override int id { get; set; } = 1;
        public override string Name { get; set; } = "Аптечка";
        public override Size size { get; set; } = new Size(1, 1, 1);
        public override int Weight { get; set; } = 5;
        public override int Price { get; set; } = 1;
    }

    public class Mace : NonConsumable
    {
        public override int id { get; set; } = 2;
        public override string Name { get; set; } = "Булова";
        public override Size size { get; set; } = new Size(1, 4, 1);
        public override int Quality { get; set; } = 100;
        public override int Weight { get; set; }
        public override int Price { get; set; }
    }

    public class Saber : NonConsumable
    {
        public override int id { get; set; } = 3;
        public override string Name { get; set; } = "Шабля";
        public override Size size { get; set; } = new Size(2, 6, 2);
        public override int Quality { get; set; } = 100;
        public override int Weight { get; set; }
        public override int Price { get; set; }
    }

    public class Dagger : NonConsumable
    {
        public override int id { get; set; } = 3;
        public override string Name { get; set; } = "Кинжал";
        public override Size size { get; set; } = new Size(1, 3, 1);
        public override int Quality { get; set; } = 100;
        public override int Weight { get; set; }
        public override int Price { get; set; }
    }
}
