using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_PrototypeDesignPattern
{
    public class CarPrototype : Prototype
    {
        private string _id = "CP200";
        private string _brand = "Hyundai";
        private string _model = "Elantra";

        public CarPrototype() { }

        private CarPrototype(string Id, string Brand, string Model) 
        {
            _id = Id;
            _brand = Brand;
            _model = Model;
        }

        public override Prototype CreateClone()
        {
            return new CarPrototype(_id, _brand, _model);
        }

        public override string PrintCloneInformation()
        {
            string Message = string.Empty;

            Message += "Car clone successfully created. \n";
            Message += "Id: " + _id + "\n";
            Message += "Brand: " + _brand + "\n";
            Message += "Model: " + _model;

            return Message;
        }
    }
}
