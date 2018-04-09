using System;

namespace FuScript {
	public struct Value {
		public const byte Null = 0, True = 1, False = 2, Number = 3, String = 4, Function = 5;

		public byte type;
		public double num;
		public object obj;

		public Value(bool b) {
			type = b ? True : False;
			num = 0;
			obj = null;
		}

		public Value(double n) {
			type = Number;
			num = n;
			obj = null;
		}

		public Value(string s) {
			type = String;
			num = 0;
			obj = s;
		}

		public override string ToString() {
			switch (type) {
			case Value.Null:        return "null";
			case Value.True:        return "true";
			case Value.False:       return "false";
			case Value.Number:      return num.ToString();
			case Value.String:      return "'" + obj + "'";
			case Value.Function:    return "function (" + ((string[])obj).Length + ") {...}";
			default:
				throw new System.Exception("Code path not possible");
			}
		}
	}

	public sealed class ValueRef {
		public Value value;

		public ValueRef(Value value) {
			this.value = value;
		}

		public override string ToString() {
			return value.ToString();
		}
	}
}

