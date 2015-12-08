using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    public class Adventurer
    {
        // stats, egenskaper och utrustning som brukar finnas i rpg
        private string title;
        private string name;
        private Spaceship ourAdventurersSpaceship;
        private Weapon ourAdventurersWeapon;

        public void SetTitle(string title)
        {
            this.title = title;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSpaceship(Spaceship spaceship)
        {
            this.ourAdventurersSpaceship = spaceship;
        }
        public Spaceship GetSpaceship()
        {
            return ourAdventurersSpaceship;
        }
        public void SetWeapon(Weapon weapon)
        {
            this.ourAdventurersWeapon = weapon;
        }
        public Weapon GetWeapon()
        {
            return ourAdventurersWeapon;
        }
    }
}
