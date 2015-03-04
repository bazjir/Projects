using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;





namespace SessionDemoTest
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page 
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
           
		
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			
	
			 

			// Create a custom FormsAuthenticationTicket containing
			// application specific data for the user.

			
			// user email address
			string email        = this.TextBox1.Text ; 
			//user password
			string password     = this.TextBox2.Text ; 
			bool   isPersistent = false; //Persist.Checked;

			//write down u r own methods for authentication
			//either from database or file
			
			if (Authenticat(email)) 
			{

				//if user is authunticated then

				int timeout=settimeout();
			

				//this variable will be accessible automatically
				//on each form...
				//so if you have some role base system
				//or you want to assign some data to this user
				//then put this along with this ticket
				//as done here

				//supose mubi is admin and i want store this info in ticket
				//so that i can get it on each page
					
				string username="mubi";

				string userData = setrole(username);

				FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
					1,
					email,
					System.DateTime.Now,
					System.DateTime.Now.AddMinutes(timeout),
					isPersistent,
					userData,
					FormsAuthentication.FormsCookiePath);

				// Encrypt the ticket.
				string encTicket = FormsAuthentication.Encrypt(ticket);

				// Create the cookie.
				Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

				// Redirect back to original URL.
				Response.Redirect(FormsAuthentication.GetRedirectUrl(email,isPersistent));



			}

		}




private	int settimeout()
		{
		
			//Place here the code that will get all users from database
			// or file and their predefied session time outs

			//for example here mubi has time 1 min
			// and any other has 2 mins

			if (this.TextBox1.Text.Trim ()=="mubi"  )
			{
	
			//just storing to show user and time out info on all the page
			Session["UID"]=this.TextBox1.Text.Trim () + " : " + "1";  
			//for example we give time out of 1 min to user "mubi"
			return 1; 

		    }

			else

			{        	

		    Session["UID"]=this.TextBox1.Text.Trim () + " : " + "2";  			
		    //else if there is some other user then time out is 2 min
		    return 2;
 
	        }
		}


		private	string setrole(string userName)
		{
		
			//put your code here to get role from
			//database
			if (userName=="mubi")
			{
	
				
				//get the roles for your user and 
				//return them
				return "admin"; 

			}
			return "user";
		}
	

		bool Authenticat(string username)
		{
			//put your authentication code here...
			return true;
		}
      

	}
}
