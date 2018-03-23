using System.Collections.Generic;

namespace CSharpSampleTestCodeLibrary
{
    public class SampleDataBank
    {
        public int SingleIntegerValue = 5;
        public int FirstIntegerValue = 10;
        public int SecondIntegerValue = 20;
        public double SingleDoubleValue = 25.25;
        public string SampleString = "This is a sample string with UPPERCASE and lowercase words.";
        public int[] sampleIntegerArray = new int[]{ 1, 2, 3, 4, 5 ,6, 9, 12, 66, 99, 125 ,25, 32, 6, 148, 1, 5, 6, 2, 100 };
        public double[] sampleDoubleArray = new double[] { 1.232, 2.25, 3.65, 4.265, 5.265, 6.2, 9.1, 12.12, 66.3, 99.32, 125.25, 25.98, 32.02, 6.98, 148.69, 1.23, 5.98, 6.25, 2.85, 100.00 };
        public char[] sampleCharArray = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'a' };
        public string[] sampleStringArray = new string[] {"sample0", "sample1", "sample2", "sample3", "sample4", "sample5"};
        public List<int> sampleIntegerList = new List<int> { 1, 2, 3, 4, 5, 6, 9, 12, 66, 99, 125, 25, 32, 6, 148, 1, 5, 6, 2, 100 };
        public List<double> sampleDoubleList = new List<double> { 1.232, 2.25, 3.65, 4.265, 5.265, 6.2, 9.1, 12.12, 66.3, 99.32, 125.25, 25.98, 32.02, 6.98, 148.69, 1.23, 5.98, 6.25, 2.85, 100.00 };
        public List<string> sampleStringList = new List<string> { "sample0", "sample1", "sample2", "sample3", "sample4", "sample5" };
        
        // ------------------------------------------- //
        public List<int> sampleIntegerCompareListA = new List<int> { 1, 2, 3, 4, 5, 6, 9, 12, 66, 99, 125, 25, 32, 6, 148, 1, 5, 6, 2, 100 };
        public List<int> sampleIntegerCompareListB = new List<int> { 1, 2, 3, 4, 5, 6, 9, 12, 66, 99, 125, 25, 32, 6, 148, 1, 5, 6, 2, 100 };
        public List<string> sampleStringCompareListA = new List<string> { "sample0", "sample1", "sample2", "sample3", "sample4", "sample5" };
        public List<string> sampleStringCompareListB = new List<string> { "sample0", "sample1", "sample2", "sample3", "sample4", "sample5" };
    }
}
