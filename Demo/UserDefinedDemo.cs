﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
	class UserDefinedDemo
	{
		//public readonly struct Digit
		//{
		//	private readonly byte digit;

		//	public Digit(byte digit)
		//	{
		//		if (digit > 9)
		//		{
		//			throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
		//		}
		//		this.digit = digit;
		//	}
		

		//	public static implicit operator byte(Digit d) => d.digit;
		//	public static explicit operator Digit(byte b) => new Digit(b);

		//	public override string ToString() => $"digit";
		//}

		//public static class UserDefinedConversions
		//{
		//	public static void Main()
		//	{
		//		var d = new Digit(7);

		//		byte number = d;
		//		Console.WriteLine(number);

		//		Digit digit = (Digit)number;
		//		Console.WriteLine(digit);
		//	}
		//}
	}
}