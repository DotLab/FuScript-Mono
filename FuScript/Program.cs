using System;
using System.Text;
using System.IO;

namespace FuScript {
	class MainClass {
		static readonly StringBuilder _sb = new StringBuilder();
		static string _line;

		public static void Main(string[] args) {
			while (true) {
				_sb.Clear();
				do {
					Console.Write("FuScript> ");
					_sb.AppendLine(_line = Console.ReadLine());
				} while (_line != "");

				try {
					
				} catch (Exception e) {
					Console.WriteLine(e);
				}

				Console.WriteLine();
			}
		}
	}
}
