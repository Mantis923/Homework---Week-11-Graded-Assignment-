using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11Week11
{
    

    class Truck: Vehicle
    {
        public double LoadCapacity { get; set; }
        public int TowingCapacity { get; set; }
        // below I called the vehicle constructor because truck inherits from vehicle, the base is refering to vehicle because it's the base Class
        public Truck(double loadCapacity, int towingCapacity, int CylindersNumber, manufactureName TruckBrand, Person Owner): base(CylindersNumber,TruckBrand, Owner) 
        {
            this.LoadCapacity = loadCapacity;
            this.TowingCapacity = towingCapacity;
           // this.CylindersNumber = CylindersNumber;//not necessary because the cylyinder number
           // was used by base above and we already have this line in the vehicle constructor
        }
        public override string ToString()
        {
            return "The truck is " + CarType.ToString("G") + "\nThe number of cylinders "
                + CylindersNumber + "\nthe load capacity is " + LoadCapacity + "\nand the towing capacity is " 
                + TowingCapacity + "\nand the owner is " + Owner.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Truck)
            {
               Truck kindOfVehicle = (Truck)obj;
                //we are type casting obj from an object to a person so we can access it's name

                return CylindersNumber == kindOfVehicle.CylindersNumber && CarType == kindOfVehicle.CarType 
                    && Owner.Equals(kindOfVehicle.Owner) && LoadCapacity == kindOfVehicle.LoadCapacity
                    && TowingCapacity == kindOfVehicle.TowingCapacity; //
         }
            else
                return false;

        }
    }
}
