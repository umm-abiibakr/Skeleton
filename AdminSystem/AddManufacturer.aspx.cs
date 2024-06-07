using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnAddManufacturer_Click(object sender, EventArgs e)
    {
        ClsManufacturersCollection manufacturersCollection = new ClsManufacturersCollection();
        ClsManufacturers newManufacturer = new ClsManufacturers();

        string validationMessage = newManufacturer.Valid(
            txtName.Text,
            txtCountry.Text,
            chkIsActive.Checked.ToString(),
            txtCreatedAt.Text
        );

        if (string.IsNullOrEmpty(validationMessage))
        {
            newManufacturer.Name = txtName.Text;
            newManufacturer.Country = txtCountry.Text;
            newManufacturer.IsActive = chkIsActive.Checked;
            newManufacturer.CreatedAt = DateTime.Parse(txtCreatedAt.Text);

            manufacturersCollection.ThisManufacturer = newManufacturer;
            manufacturersCollection.Add();

            lblMessage.ForeColor = System.Drawing.Color.Green;
            lblMessage.Text = "Manufacturer added successfully!";
            ClearForm();
        }
        else
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = validationMessage;
        }
    }

    private void ClearForm()
    {
        txtName.Text = string.Empty;
        txtCountry.Text = string.Empty;
        chkIsActive.Checked = false;
        txtCreatedAt.Text = string.Empty;
    }
}