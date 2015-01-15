using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StringGen
{
	class DataManager
	{

		internal string LoadFile(string path)
		{
			FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
			StreamReader reader = new StreamReader(file);
			string res = reader.ReadToEnd();
			reader.Close();
			file.Close();

			return res;
		}

		internal void SaveFile(string filename, string content)
		{
			string path = "../../out/" + filename;
			FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
			StreamWriter writer = new StreamWriter(file);

			// NOTE: optional formatting of the output file can be done here...
			writer.WriteLine(content);

			writer.Close();
			file.Close();
		}

	}
}
