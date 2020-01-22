using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProject.Interface
{
	public interface IBaiscTelephone
	{
		 int PhoneNo { get; set; }
		 bool ConnectionStatus { get; set; }
		bool PowerStatus { get; set; }

		bool SwitchOn();
		bool SwitchOff();
		string Dial();
	}
}
