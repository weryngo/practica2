using System;

namespace proyecto2
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			double iva = 1.16;
			double precio1,precio2,precio3;

			Console.WriteLine ("Ingresa el primer valor");
			//String y=C5onsole.ReadLine();
			float primer=float.Parse (Console.ReadLine ());
			Console.WriteLine ("Ingresa el segundo valor");
			//string x=Console.ReadLine();
			float segundo=float.Parse(Console.ReadLine ());
			Console.WriteLine ("Ingresa el tercer valor");
			//string z=Console.ReadLine();
			float tercero=float.Parse(Console.ReadLine ());


			precio1 = primer * iva;
			precio2 = segundo * iva;
			precio3 = tercero * iva;

			Console.WriteLine ("El primer precio es:"+ precio1);
			Console.WriteLine ("El segundo precio es:" + precio2);
			Console.WriteLine ("El tercer precio es:" + precio3);


		}
	}
}