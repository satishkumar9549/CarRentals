﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Toyota : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Booking.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Hyundai.aspx");

    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Nissan.aspx");

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}