using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Demo
{
	class SaltedHashDemo
	{
		//public static void Main(string[] args)
		//{
		//	Console.Write("Enter a password: ");
		//	string password = Console.ReadLine();

		//	// generate a 128-bit salt 
		//	byte[] salt = new byte[16];
		//	using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
		//	{
		//		rngCsp.GetBytes(salt);
		//	}
		//	Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

		//	var pbkdf2 = new Rfc2898DeriveBytes(password,salt,10000);
		//	byte[] hash = pbkdf2.GetBytes(20);
		//	byte[] hashBytes = new byte[36];
		//	Array.Copy(salt, 0, hashBytes, 0, 16);
		//	Array.Copy(hash, 0, hashBytes, 16, 20);

		//	string savedPasswordHash = Convert.ToBase64String(hashBytes);
		
		//	Console.WriteLine($"Hashed: {savedPasswordHash}");
		//}
	}
}
