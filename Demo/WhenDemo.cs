using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace Demo
{
	class WhenDemo
	{
		//static void Main()
		//{
		//	Console.WriteLine(MakeRequest().Result);
		//}

		//public static async Task<string> MakeRequest()
		//{
		//	var client = new HttpClient();
		//	var streamTask = client.GetStringAsync("https://localHost:10000");
		//	try
		//	{
		//		var responseText = await streamTask;
		//		return responseText;
		//	}
		//	catch (HttpRequestException e) when (e.Message.Contains("301"))
		//	{

		//		return "site moved";
		//	}
		//	catch (HttpRequestException e) when (e.Message.Contains("404"))
		//	{
		//		return "Page not Found";
		//	}
		//	catch (HttpRequestException e)
		//	{
		//		return e.Message;
		//	}
		//}
	}
}
