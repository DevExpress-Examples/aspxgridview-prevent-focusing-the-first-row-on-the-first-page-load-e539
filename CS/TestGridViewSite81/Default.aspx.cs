using System;
using System.Data;
using DevExpress.Web.ASPxEditors;
using DevExpress.Data;
using DevExpress.Web.ASPxGridView;


public partial class _Default : System.Web.UI.Page {

    protected void Page_Load(object sender, EventArgs e) {
    }

    protected void ASPxGridView1_DataBound(object sender, EventArgs e) {
        if(!IsPostBack)
            ((ASPxGridView)sender).FocusedRowIndex = -1;
    }
}
