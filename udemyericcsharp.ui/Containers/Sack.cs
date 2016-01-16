using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyEricCsharp.Containers
{
    class Sack:Bag
    {
        public Sack(int capacity) : base(capacity)
        {
        }
        public override void AddItem(Items.Item ItemtoAdd)
        {
            if (ItemtoAdd.Weight > 1)
            {
                Console.WriteLine("That item is too big for the sack");
            }
            else
            {
                base.AddItem(ItemtoAdd);
            }
        }
    }
}
