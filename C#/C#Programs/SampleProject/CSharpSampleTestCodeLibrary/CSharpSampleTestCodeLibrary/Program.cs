using CSharpSampleTestCodeLibrary.CSharpTopicClasses;
using CSharpSampleTestCodeLibrary.SampleClasses;
using CSharpSampleTestCodeLibrary.SampleClasses.ExceptionHandling;

namespace CSharpSampleTestCodeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleDataBank sampleData = new SampleDataBank();
            var temp = sampleData.sampleDoubleArray;

            //var alenCar = new Car();
            // bool carStatus = alenCar.StartEngine(true);

            // var demoConstructorChaining = new ConstructorChaining(2);

            //School mySchool = new School("HFCS", "School", "Education", 50, 2000, "English");

#region Inheritance&PolyMorphism

#endregion

#region ExpectionHandling Topics

            FeaturePhone featurePhone = new FeaturePhone("Nokia 3315", "FeaturePhone");
            featurePhone.FeatureHiding();
            ((ExceptionInvokerCellPhone)featurePhone).FeatureHiding();
#endregion




        }  
    }
}
