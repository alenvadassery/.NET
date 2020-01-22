using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProject.Abstract
{
	abstract class Telephone : CommunicationDevice
	{
		public int PhoneNo { get; set; }
		public bool ConnectionStatus { get; set; }
		//public bool PowerStatus { get; set; }
		public bool IsDialing { get; set; }

		public override bool SwitchOn()
		{
			Console.WriteLine("Switching on feature from Basic Telephone using Power Button");
			
			return base.PowerStatus = true;
		}
		public override bool SwitchOff()
		{
			Console.WriteLine("Switching off feature from Basic Telephone using Power Button");
			
			return base.PowerStatus = false;
		}

		public virtual bool Dial(int phoneNo)
		{
			if (!IsDialing)
			{
				Console.WriteLine("Dilaing " + phoneNo + " from Basic Telephone");

				IsDialing = true;
			}

			return IsDialing;
		}
	}
}
