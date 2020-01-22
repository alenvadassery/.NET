using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProject.Abstract
{
	abstract class CommunicationDevice
	{
		public bool PowerStatus { get; set; }
		public abstract bool SwitchOn();

		public abstract bool SwitchOff();

		public virtual void SelfDiagnose()
		{
			Console.WriteLine("Running self diagnosis using basic CommunicationDevice kernel");
		}
	}
}
