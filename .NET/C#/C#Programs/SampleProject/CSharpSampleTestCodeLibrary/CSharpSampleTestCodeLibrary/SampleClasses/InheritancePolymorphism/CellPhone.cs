using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSampleTestCodeLibrary.SampleClasses.InheritancePolymorphism
{
    public abstract class CellPhone
    {

        //CellPhone Propeties
        public string Brand { get; set; }
        public string Type { get; set; }

        public CellPhone() { }
        public CellPhone(string brand, string type)
        {
            this.Brand = brand;
            this.Type = type;
        }

        public virtual void Call(int callingNumber)
        {
            Console.WriteLine("Hi Sir i am calling to:" + callingNumber);
        }
        public virtual void Sms(int callingNumber)
        {
            Console.WriteLine("Hi Sir i am sending SMS to:" + callingNumber);
        }

        public virtual void FeatureHiding()
        {
            Console.WriteLine("I am in Abstract Parent class method. I have a bad child");
        }

        public abstract void Display();
        public abstract void Charging();
        //This method will throw exception.
        public abstract void DontTouchMeIWillCry();
    }

    public class FeaturePhone : CellPhone
    {
        public FeaturePhone(string brand, string type) : base("Nokia", "FeaturePhone")
        {
            // Class specific fields will be intialized here
        }
        public FeaturePhone()
        { }

        public override void Call(int callingNumber)
        {
            Console.WriteLine("Hi i am child class, Transfering your request to parent class with basic feature");
            base.Call(callingNumber);
            Console.WriteLine("Thanks, Use" + base.Brand + "'s feature phone again for calling servies :-)");
        }

        public override void Sms(int callingNumber)
        {
            Console.WriteLine("Hi i am child class, Transfering your request to parent class with basic feature");
            base.Sms(callingNumber);
            Console.WriteLine("Thanks, Use this" + base.Brand + "'s feature phone again for sms servies :-)");
        }

        public override void Display()
        {
            Console.WriteLine("Hi," + base.Brand + "'s feature phone's display is Black and White... :-(");
        }

        public override void Charging()
        {
            Console.WriteLine("Hi," + base.Brand + "'s feature phone doesn't support turbo charging.. i will cry now, Dont ask me more..");
        }

        public override void DontTouchMeIWillCry()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public new void FeatureHiding()
        {
            Console.WriteLine("I am in child class method, Will hide my Parent, I Don't like them.");
            Console.WriteLine("Ok for you guys i will once call my Parents......");
            base.FeatureHiding();
            Console.Read();
        }
    }
}
}
