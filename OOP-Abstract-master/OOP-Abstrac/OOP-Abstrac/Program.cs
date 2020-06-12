using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOP_Abstrac
{
	class Program
	{
		public static void Main(string[] args)
		{
			Implementasi imple = new Implementasi();
			string nama = "Muhammad Qoamruz";
			string almt = "Bekasi";
			string NIM = "2683";
			string Jurusan = "S1 Informatika";

			imple.ShowKTP(nama, almt);
			imple.ShowMHS(nama, NIM, Jurusan);

			Console.ReadKey(true);
		}
	}
}