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
using System.Web.Security ; 

namespace SessionDemoTest
{
	/// <summary>
	/// Summary description for WebForm2.
	/// </summary>
	public class WebForm2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Button Button3;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			
          //SET THIS FORM STARTUP FORM			
			
			
			try
			{
				this.Label1.Text =Session["UID"].ToString ()  ;
			}
			catch(Exception ex)
			{}
			
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
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			//FOODS selected			
			Session["MID"]="1";
			//Go to the page details.aspx to show the foods
			Response.Redirect ("details.aspx");
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			  //sign out from form authentication
			  FormsAuthentication.SignOut();
			  //abandon session
              Session.Abandon();
              Response.Redirect("logon.aspx");		
 
		
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			//Games selected
			Session["MID"]="2";
			//Go to the page details.aspx to show the games
			Response.Redirect("details.aspx");
		}
	}
}
