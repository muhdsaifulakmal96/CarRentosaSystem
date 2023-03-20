using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentosaSystem.Model;

namespace CarRentosaSystem
{
    public partial class InsertEditCarList : System.Web.UI.Page
    {
        InsertCarListModel _InsertCarListModel = InsertCarListModel();

        private static InsertCarListModel InsertCarListModel()
        {
            throw new NotImplementedException();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void PreparedCarInfo() 
        {
            _InsertCarListModel.car_name = txtCarName.Text;
            _InsertCarListModel.description = txtCarDescription.Text;
            _InsertCarListModel.car_image = fileUploadKereta.FileName;
            _InsertCarListModel.car_mileage = Convert.ToDecimal(formatMileageTxt.Text);
            _InsertCarListModel.transmission_type = txtTransmission.Text;
            _InsertCarListModel.car_model_year = Convert.ToInt16(txtmodelYear.Text);
            _InsertCarListModel.car_brand = txtCarBrand.Text;
            _InsertCarListModel.color = txtColor.Text;
            _InsertCarListModel.capacity_cc = Convert.ToDecimal(txtCC.Text);
            _InsertCarListModel.rate_per_hour = Convert.ToDecimal(txtRatepHour.Text);
        }
        private void UploadCarImage()
        {
            //bytes[] fileSize = 
        }
    }
}