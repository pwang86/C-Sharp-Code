using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
// using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Demo
{
	class SaltedHashDemo
	{
		//public static void Main(string[] args)
		//{
		//	Console.Write("Enter a password: ");
		//	string password = Console.ReadLine();

		//	// generate a 128-bit salt using a secure PRNG
		//	byte[] salt = new byte[128 / 8];
		//	using (var rng = RandomNumberGenerator.Create())
		//	{
		//		rng.GetBytes(salt);
		//	}
		//	Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

		//	string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
		//   password: password,
		//   salt: salt,
		//   prf: KeyDerivationPrf.HMACSHA1,
		//   iterationCount: 10000,
		//   numBytesRequested: 256 / 8));
		//	Console.WriteLine($"Hashed: {hashed}");
		//}
	}
}
