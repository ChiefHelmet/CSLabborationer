using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb3_1._1
{
    public class Spaceship
    {
        private string shipModel;
        private int cargoCapacity;
        private string maxSpeed;
        private Weapon theShipsWeapon;

        public void SetShipModel(string shipModel)
        {
            this.shipModel = shipModel;
        }
        public string GetShipModel()
        {
            return shipModel;
        }
        public void SetCargoCapacity(int cargoCapacity)
        {
            this.cargoCapacity = cargoCapacity;
        }
        public int GetCargoCapacity()
        {
            return cargoCapacity;
        }
        public void SetMaxSpeed(string maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
        public string GetMaxSpeed()
        {
            return maxSpeed;
        }
        public void SetShipWeapon(Weapon shipWeapon)
        {
            this.theShipsWeapon = shipWeapon;
        }
        public Weapon GetShipWeapon()
        {
            return theShipsWeapon;
        }
    }
}
