using System;

namespace LectorXml
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LectorXml lector = new LectorXml ("bank.xml");
			lector.LlegirFitxer();
		}
	}
}
