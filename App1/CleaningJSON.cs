using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace LogicProblems
{
	public class CleaningJSON
    {
		public static void Start()
		{
			string responseMessage = string.Empty;
			WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
			WebResponse response = request.GetResponse();

			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream);
				responseMessage = reader.ReadToEnd();
			}

			response.Close();

			Console.WriteLine(responseMessage);
			responseMessage = responseMessage.Replace("N\\/A", "-");
            Console.WriteLine(responseMessage);
			responseMessage = Regex.Replace(responseMessage, ",\"\\w+\":(\"\"|\"-\")", "");
			Console.WriteLine(responseMessage);
			responseMessage = Regex.Replace(responseMessage, "{\"\\w+\":(\"\"|\"-\"),", "{");
			Console.WriteLine(responseMessage);

			//To clean a whole key that have one invalid value:
			responseMessage = Regex.Replace(responseMessage, ",\"\\w+\":[[]\".*\"-\".*[]]", "");

			// Justo to quit the invalid value:
			//responseMessage = Regex.Replace(responseMessage, ",(\"-\")", "");
			Console.WriteLine(responseMessage);
		}
	}
}
