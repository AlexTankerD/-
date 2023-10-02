using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
namespace aawd.Controllers
{
	public class BaseController
	{
		protected string connectionstring;
		protected RestClient Client;
		protected RestResponse Response;
		protected RestRequest Request;
		public BaseController(string connectionstring)
		{
			this.connectionstring = connectionstring;
			Client = new RestClient(connectionstring);	
		}
	}
}
