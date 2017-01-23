using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    class Cat : Animal
    {
        private string breed;
        private string furLength;

        private bool declawed;

        public Cat(string breed, string furLength, bool declawed)  :base(4, 3, 3)
        {
            this.breed = breed;
            this.furLength = furLength;
            this.declawed = declawed;

        }
    }
}
