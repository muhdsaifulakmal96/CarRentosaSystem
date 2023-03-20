using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRental.DBStore;

namespace CarRental
{
    public partial class _Default : Page
    {
        CarCombo _CarCombo = new CarCombo();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindCarTilesRepeater();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertEditCarList.aspx?type=insert");
        }

        protected void lnkOrder_Click(object sender, CommandEventArgs e)
        {
            Response.Redirect("OrderCar.aspx?car_id=" + e.CommandArgument.ToString());          
        }

        protected void lnkEdit_Click(object sender, CommandEventArgs e)
        {
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "myScript", "YourFuncition();", true)
            string car_id = e.CommandArgument.ToString();            
            Response.Redirect("InsertEditCarList.aspx?type=edit&car_id=" + car_id);
        }

        

        public void OnConfirm(object sender, EventArgs e)
        {
            RepeaterItem item= (sender as LinkButton).NamingContainer as RepeaterItem;
            HiddenField car_id_hiddenfield = item.FindControl("car_id_hiddenfield") as HiddenField;

            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                _CarCombo.DeleteCarList(Convert.ToInt32(car_id_hiddenfield.Value));

                DataTable dtcarlist = _CarCombo.GetCarListByID(Convert.ToInt32(car_id_hiddenfield.Value));
                if (dtcarlist.Rows.Count > 0)
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Kenderaan Tidak Boleh Dipadam Kerana Kenderaan Ini Sedang Ditempah ');window.location = 'Default.aspx';", true);
                }
                else
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Kenderaan Telah Berjaya Dipadam ');window.location = 'Default.aspx';", true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Tidak')", true);
            }
        }

        protected void BindCarTilesRepeater()
        {
            CarCombo dbObj = new CarCombo();
            DataTable carlist = dbObj.GetCarList();
            repeatCarTiles.DataSource = carlist;
            repeatCarTiles.DataBind();
        }

        protected string formatMileageTxt(decimal car_mileage)
        {
            string mileageTxt = Convert.ToString(Math.Floor(car_mileage / 1000)) + "K";
            return mileageTxt;
        }

    }
}