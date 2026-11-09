using System;
using System.Collections.Generic;
using System.Text;

namespace tappancshotel.Models
{
    public class Dog : Pet
    {
        public Dog(string name) : base(name, "Kutya", "🐶")
        {
        }

        public override string Speak()
        {
            return "Vau-vau! Jöhet az érettségi?";
        }
        public override string Play()
        {
            ChangeStats(-14, 30, -24);
            return $"{Name} Boldogan labdázott! +30 jókedv";
        }
    }
}
