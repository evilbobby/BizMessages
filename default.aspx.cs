using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 

public partial class default : System.Web.UI.Page
{
	protected void Page_Load (object sender, EventArgs e) { 	
		 
	}
	 
	private Dictionary<string, string> GetMessages () {
		Dictionary<string, string> msgs = new Dictionary<string, string>();
		msgs.Add("FirstName", "First Name is required.");
		msgs.Add("LastName", "Last Name is required.");
		msgs.Add("RunLength", "Run Length must be in proper format.");
		return msgs;
	}

	private List<Exception> GetErrors () {
		List<Exception> errors = new List<Exception>();
		errors.Add(new Exception("Error text 1"));
		errors.Add(new Exception("Error text 2"));
		errors.Add(new Exception("Error text 3"));
		return errors;
	}

	private List<int> GetList () {
		List<int> ilist = new List<int>();
		ilist.Add(5);
		ilist.Add(22);
		ilist.Add(19);
		return ilist;
	}
	 
	protected void btnShowFailures1_Click (object sender, EventArgs e) {
		bizMessages1.DataSource = GetMessages();
		bizMessages1.DataBind();
	}

	protected void btnShowSuccess1_Click (object sender, EventArgs e) {
		bizMessages2.IsSuccess = true;
		bizMessages2.DataSource = GetMessages();
		bizMessages2.DataBind();
	}

	protected void btnShowFailures2_Click (object sender, EventArgs e) {
		bizMessages3.HideBullets = true;
		bizMessages3.DataSource = GetMessages();
		bizMessages3.DataBind();
	}

	protected void btnShowSuccess2_Click (object sender, EventArgs e) {
		bizMessages4.HideBullets = true;
		bizMessages4.IsSuccess = true;
		bizMessages4.DataSource = GetMessages();
		bizMessages4.DataBind();
	}

	protected void btnShowErrors_Click (object sender, EventArgs e) {
		bizErrors.DataSource = GetErrors();
		bizErrors.DataBind();
	}

	protected void btnShowList_Click (object sender, EventArgs e) {
		bizIList.DataSource = GetList();
		bizIList.DataBind();
	}
	
}