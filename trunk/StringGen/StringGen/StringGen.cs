using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringGen
{
	class StringGen
	{

		internal void Run()
		{
			DataManager dm = new DataManager();
			Processor proc = new Processor();

			// NOTE: example usage
			string str = proc.generateStringIterativeFormat(10, 30, "[", "]");
			dm.SaveFile("../../out/output.txt", str);
		}
	}
}
