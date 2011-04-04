using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

public partial class biz_messages : UserControlBase
{
	private const string failure = " bizFailure ";
	private const string success = " bizSuccess ";
	private const string bullet = " bizBullet ";
	private const string nobullet = " bizNobullet ";

	public bool IsSuccess { get; set; }

	public bool HideBullets { get; set; }

	public object DataSource { get; set; }

	protected void Page_Load (object sender, EventArgs e) {
		pnlBizMessageWrapper.Visible = false;
	}

	public override void DataBind () {
		pnlBizMessageWrapper.CssClass = (IsSuccess ? success : failure) + (HideBullets ? nobullet : bullet);
		 
		if (DataSource is IDictionary<string, string>) {
			rptMessageList.DataSource = ((IDictionary<string, string>)DataSource).Select(x => new { Display = x.Value });
		} else if (DataSource is IEnumerable<Exception>) {
			pnlBizMessageWrapper.CssClass = failure + (HideBullets ? nobullet : bullet);
			rptMessageList.DataSource = ((IEnumerable<Exception>)DataSource).Select(x => new { Display = x.Message });
		} else if (DataSource is IEnumerable<char>) {
			rptMessageList.DataSource = (new List<string>() { (string)DataSource })
				.Select(x => new { Display = x.ToString() });
		} else if (DataSource is IEnumerable) {   
			List<string> list = new List<string>();
			foreach (var i in (IEnumerable)DataSource) {
				list.Add(i.ToString());
			}

			rptMessageList.DataSource = (list).Select(x => new { Display = x.ToString() });
		} else {
			throw new ArgumentException("DataSource must be IDictionary, IEnumerable or String");
		}

		pnlBizMessageWrapper.Visible = true;
		rptMessageList.DataBind();
		base.DataBind();
	}
}
