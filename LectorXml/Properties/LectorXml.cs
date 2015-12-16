using System;
using System.Xml;

namespace LectorXml
{
	public class LectorXml:XmlTextReader
	{
		//String url;
		XmlTextReader fitxer;
		public int profunditat=1;
		XmlDeclaration declaration = fitxer.ChildNodes
			.OfType<XmlDeclaration>()
				.FirstOrDefault();

		public LectorXml (String url)
		{
			fitxer = new XmlTextReader (url);

		}

		public void LlegirFitxer (){
			while (fitxer.Read()) 
			{

				switch (fitxer.NodeType) 
				{
				case XmlNodeType.Element: // The node is an element.
					Console.Write ("Entrant al node: " + fitxer.Name + "\n" );

					Console.WriteLine ("Profunditat: " + profunditat);
					profunditat ++;

						if (fitxer.HasAttributes) {
							while (fitxer.MoveToNextAttribute()) {
							Console.Write ("" +" " + fitxer.Name + "='" + fitxer.Value + "'"+ "\n");
							}
						} else{
						Console.Write ("No té atributs" + "\n");
						}
					break;
					case XmlNodeType.Text: //Display the text in each element.
					Console.WriteLine ("Valor: " + fitxer.Value );
					break;
					case XmlNodeType.EndElement: //Display the end of the element.
					profunditat --;
					break;
				}
			}
			Console.ReadLine();
			Console.WriteLine ();
		}
	}
}

