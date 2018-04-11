using System;
using System.Text;

using FuScript;

namespace FuScriptMono {
	class MainClass {
		static readonly StringBuilder sb = new StringBuilder();
		static string line;

		public static void Main(string[] args) {
			while (true) {
				sb.Clear();
				do {
					Console.Write("FuScript> ");
					sb.AppendLine(line = Console.ReadLine());
					if (line == "exit") return;
				} while (line != "");

				try {
					Lexer.Scan(sb.ToString());
					Console.WriteLine(Lexer.Recant());
				} catch (LexerException e) {
					Console.WriteLine(e);
					Lexer.Reset();
				}

				Console.WriteLine();
			}
		}
	}
}
