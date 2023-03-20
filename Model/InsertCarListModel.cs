using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRentosaSystem.Model
{
    public class InsertCarListModel
    {
		public string car_name { get; set; }
		public string description { get; set; }
		public string car_image { get; set; }
		public decimal car_mileage { get; set; }
		public string transmission_type { get; set; }
		public int car_model_year { get; set; }
		public string car_brand { get; set; }
		public string color { get; set; }
		public decimal capacity_cc { get; set; }
		public string plate_number { get; set; }
		public decimal rate_per_hour { get; set; }
	}

	
}