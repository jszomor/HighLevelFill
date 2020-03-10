using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLevelFill
{
	class Program
	{
		static void Main(string[] args)
		{
			string fillName = "itv.txt";
			string fileW = "itvCopy.txt";
			Encoding e = Encoding.GetEncoding(1250);//kelet európai kódolás
			StreamReader fileToRead = new StreamReader(fillName, e);
			string sor;
			string ujSor = "";
			StreamWriter fileToWrite = new StreamWriter(fileW, true, e);
			while((sor = fileToRead.ReadLine()) != null)
			{
				ujSor = "";
				for (int i = 0; i < sor.Length; i++)
				{
					ujSor += sor[sor.Length-i-1];
				}
				fileToWrite.WriteLine(ujSor);

				Console.WriteLine(sor);
			}
			fileToWrite.Close();
			Console.ReadKey();
		}
	}
}
