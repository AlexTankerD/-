using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using static ServicAPI.Models.Model;

namespace aawd.Controllers
{
	public class IgorController : BaseController
	{
		public IgorController(string connectionstring) : base(connectionstring) 
		{}

		public RestResponse Authorization(User user)
		{
			Request = new RestRequest("/Auth/Login", Method.Post);
			Request.AddBody(user);
			Response = Client.Execute(Request);
			return Response;
		}
		public RestResponse Registration(User User)
		{
			Request = new RestRequest("/Auth/Register", Method.Post);
			Request.AddBody(User);
			Response = Client.Execute(Request);
			return Response;
		}

	}
}
