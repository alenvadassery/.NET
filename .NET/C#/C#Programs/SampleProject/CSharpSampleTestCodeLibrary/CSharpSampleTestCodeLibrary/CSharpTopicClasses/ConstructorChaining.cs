using System;

namespace CSharpSampleTestCodeLibrary.CSharpTopicClasses
{
    public class ConstructorChaining
    {
        // Members should ideally not be exposed to outside world.
        public int intergerValue1;
        public string stringValue2;

        // No return type for Constructor
        public ConstructorChaining()
        {
            Console.WriteLine("I am a default constructor.");
            Console.Read();
        }

        public ConstructorChaining(int val1) : this(val1, "")
        {
            Console.WriteLine("I am a constructor taking int value.");
            Console.Read();
        }
        public ConstructorChaining(string val2) : this(0, val2)
        {
            Console.WriteLine("I am a constructor taking string value.");
            Console.Read();
        }

        //Master Constructor
        public ConstructorChaining(int val1, string val2)
        {
            Console.WriteLine("Hey guys i am MASTER constructor.");
            if (val1 > 100)
            {
                Console.WriteLine("Your are rich .... :-)");
            }
            else
            {
                Console.WriteLine("Your are poor..... :-(");
            }
        }
    }
}
