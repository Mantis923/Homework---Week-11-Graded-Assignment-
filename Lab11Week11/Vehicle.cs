namespace HW11Week11
{
    public enum manufactureName
    {
        Nissan_Skyline_GTR_R34 ,
        Porche911_Turbo,
        Mercedes_G_Class,
        ROLLS_ROYCE_CULLINAN

    }

    class Vehicle
    {
       public int CylindersNumber { get; set; } //this makes cylyinder number a property it gives it a public getter and setter

        public manufactureName CarType { get; set; }

        public Person Owner { get; set; }

        public Vehicle(int Cylinder, manufactureName manufacture, Person owner)
        {
            this.CylindersNumber = Cylinder;
            this.CarType = manufacture;
            this.Owner = owner;
        }

      public override string ToString()
        {
         return "The car is " + CarType.ToString("G") + "\nThe number of cylinders " + CylindersNumber + "\nand the owner is " + Owner.ToString();                        //capital G uses the general format of 
        }

        public override bool Equals(object obj)
        {
            if (obj is Vehicle)
            {
                Vehicle kindOfVehicle = (Vehicle)obj;
                 //we are type casting obj from an object to a person so we can access it's name
                return CylindersNumber==kindOfVehicle.CylindersNumber &&  CarType == kindOfVehicle.CarType && Owner.Equals(kindOfVehicle.Owner); //
            }
            else
                return false;
            
        }





    }
}
