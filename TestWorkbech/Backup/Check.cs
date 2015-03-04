using System;

namespace SessionDemoTest
{
	/// <summary>
	/// Summary description for Check.
	/// </summary>
	public class Check
	{
		public Check()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		

		public static bool IsAuth()
		{
			System.Web.HttpContext context= System.Web.HttpContext.Current;
			if(!context.Request.IsAuthenticated)
			{
				context.Response.Redirect("webform1.aspx",true);
				return false;
			}
			
		
			return true;
		}

	}
}
