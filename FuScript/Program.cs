using System;
using System.Text;
using System.IO;

namespace FuScript {
	class MainClass {
		static readonly StringBuilder sb = new StringBuilder();
		static string line;

		public static void Main(string[] args) {
			while (true) {
				sb.Clear();
				do {
					Console.Write("FuScript> ");
					sb.AppendLine(line = Console.ReadLine());
				} while (line != "");



				Console.WriteLine();
			}
		}
	}
}
