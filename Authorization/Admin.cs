using Microsoft.AspNetCore.Authorization;
using NowonMedical.Context;
using NowonMedical.Models;

namespace NowonMedical.Authorization
{
	public class Admin : IAuthorizationRequirement
	{
		public Admin(string ip) 
		{ 
			
		}
	}
}
