using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_PrototypeDesignPattern
{
    public class MotorBikePrototype : Prototype
    {
        private string _id = "MBP130";
        private string _brand = "Mototec";
        private string _model = "Xtreme";

        public MotorBikePrototype() { }

        private MotorBikePrototype(string Id, string Brand, string Model) 
        {
            _id = Id;
            _brand = Brand;
            _model = Model;
        }

        public override Prototype CreateClone()
        {
            return new MotorBikePrototype(_id, _brand, _model);
        }

        public override string PrintCloneInformation()
        {
            string Message = string.Empty;
            Message += "Motorbike clone successfully created. \n";
            Message += "Id: " + _id + "\n";
            Message += "Brand: " + _brand + "\n";
            Message += "Model: " + _model;

            return Message;
        }
    }
}
