using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAdvance
{
   abstract class Car
    {

        public string brand;
        public string model;
        public int mileage;

        public abstract string getCarDetails();
       

    }

    class BMW : Car
    {
        public string specialfeatures;

        public override string getCarDetails()
        {
            return this.brand + " is launched a model " + this.model + " with new features: " 
                + this.specialfeatures;
        }

    }

    class Mercedez : Car
    {
        public string specialfeatures;
        public override string getCarDetails()
        {
            return this.brand + " is launched a model " + this.model + " with the mileage of "+this.mileage
               + this.specialfeatures;
        }
    }
}
