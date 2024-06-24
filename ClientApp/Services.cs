using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
	public static class Services
	{
		public static async Task<bool> Login(string username, string password)
		{
			HttpClient client = new HttpClient();
			var parametersDict = new Dictionary<string, string> { { "username", username }, { "password", password } };
			var parameters = new FormUrlEncodedContent(parametersDict);
			try
			{
				var response = await client.PostAsync("http://localhost/ApiLiveChatApp/login.php", parameters);
				bool content = bool.Parse(await response.Content.ReadAsStringAsync());
				if (!content)
				{
					return false;
				}
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}
	}
}
