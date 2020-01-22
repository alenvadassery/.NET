using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProject.Abstract
{
	abstract class BasicTelephone
	{
		public int PhoneNo { get; set; }
		public bool ConnectionStatus { get; set; }
		public bool PowerStatus { get; set; }

		public virtual bool SwitchOn()
		{
			Console.WriteLine("Switching on feature from Basic Telephone");
			PowerStatus = true;

			return PowerStatus;
		}
		public virtual bool SwitchOff()
		{
			Console.WriteLine("Switching off feature from Basic Telephone");
			PowerStatus = false;

			return PowerStatus;
		}

		public abstract string Dial();
	}
}
