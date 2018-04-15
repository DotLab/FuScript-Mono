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
					Console.WriteLine("    Lexer finished\n");
				} catch (Exception e) {
					Console.WriteLine(e);
					Lexer.Reset(); 
					Console.WriteLine("    Lexer failed\n"); continue;
				}

				try {
					Parser.Parse();
					Console.WriteLine(Parser.Recant());
					Console.WriteLine("    Parser finished\n");
				} catch (Exception e) {
					Console.WriteLine(e);
					Lexer.Reset();
					Parser.Reset(); 
					Console.WriteLine("    Parser failed\n"); continue;
				}

				//try {
				//	Compiler.Compile();
				//	//Console.WriteLine(Compiler.Recant());
				//	Console.WriteLine("    Compiler finished\n");
				//} catch (Exception e) {
				//	Console.WriteLine(e);
				//	Lexer.Reset();
				//	Compiler.Reset(); 
				//	Console.WriteLine("    Compiler failed\n"); continue;
				//}
			}
		}
	}
}
