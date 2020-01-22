using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept
{
	public class BaseChildConcept
	{
		public void ExecuteConceptProgram()
		{

		}
	}

	public abstract class AbstractParent
	{
		public void Method_1()
		{
			Console.WriteLine("I am Method_1 from AbstractParent class");
		}
		public abstract void Method_2();
		public virtual void Method_3()
		{
			Console.WriteLine("I am Method_3 from AbstractParent class");
		}

		public virtual void Method_4()
		{
			Console.WriteLine("I am Method_4 from AbstractParent class");
		}

		public virtual void Method_11()
		{
			Console.WriteLine("I am Method_11 from AbstractParent class");
		}
	}

	public class Parent: AbstractParent
	{
		public void Method_1()
		{
			Console.WriteLine("I am Method_1 from Parent class");
		}

		public override void Method_2()
		{
			Console.WriteLine("I am Method_2 from Parent class");
		}

		public override void Method_3()
		{
			Console.WriteLine("I am Method_3 from Parent class");
		}

		public virtual void Method_4()
		{
			Console.WriteLine("I am Method_4 from Parent class");
		}

		public void Method_5()
		{
			Console.WriteLine("I am Method_5 from Parent class");
		}

		public void Method_6()
		{
			Console.WriteLine("I am Method_6 from Parent class");
		}

		public virtual void Method_11()
		{
			Console.WriteLine("I am Method_11 from Parent class");
		}
	}

	public class Child : Parent
	{
		public void Method_1()
		{
			Console.WriteLine("I am Method_1 from Child class");
		}

		public void Method_2()
		{
			Console.WriteLine("I am Method_2 from Child class");
		}

		public override void Method_3()
		{
			Console.WriteLine("I am Method_3 from Child class");
		}

		public new void Method_4()
		{
			Console.WriteLine("I am Method_4 from Child class");
		}

		public new void Method_5()
		{
			Console.WriteLine("I am Method_5 from Child class");
		}

		public void Method_6()
		{
			Console.WriteLine("I am Method_6 from Child class");
		}

	}

	public class SubChild : Child
	{ 
		public void Method_1()
		{
			Console.WriteLine("I am Method_1 from SubChild class");
		}

		public void Method_2()
		{
			Console.WriteLine("I am Method_2 from SubChild class");
		}

		public override void Method_3()
		{
			Console.WriteLine("I am Method_3 from SubChild class");
		}

		public new void Method_4()
		{
			Console.WriteLine("I am Method_4 from SubChild class");
		}

		public new void Method_5()
		{
			Console.WriteLine("I am Method_5 from SubChild class");
		}

		public void Method_6()
		{
			Console.WriteLine("I am Method_6 from SubChild class");
		}


	}
}
