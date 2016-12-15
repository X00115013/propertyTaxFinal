using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace propertyTaxFinal.Models
{
    public class PropertyTax
    {
        
    public enum Title
    {
        Mr,Mrs,Miss,Dr
    }
        [Required(ErrorMessage = "Please supply the title.")]
        [DisplayName("Title")]
        public Title? title { get; set; }

        [Required(ErrorMessage = "Please supply a name.")]
        [DisplayName("Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Property Value Required!")]
        [Range(0, 500000, ErrorMessage = "Invalid Property Value!")]
        [DisplayName("Property Value (€)")]
        public int amountIn { get; set; }

        // operation to calculate the propery tax
        [DisplayName("Band")]
        public String PropertyValueBand
        {
            get
            {
                string band = " ";
                if (amountIn < 100000)
                {
                    band = "Between 0 and 100,000";
                }
                else if (amountIn < 150000)
                {
                    band = "Between 100001 and 150000";
                }
                else if (amountIn < 200000)
                {
                    band = "Between 150001 and 200000";
                }
                else if (amountIn < 250000)
                {
                    band = "Between 200001 and 250000";
                }
                else if (amountIn < 300000)
                {
                    band = "Between 250001 and 300000";
                }
                else if (amountIn < 350000)
                {
                    band = "Between 300001 and 350000";
                }
                else if (amountIn < 400000)
                {
                    band = "Between 350001 and 400000";
                }
                else if (amountIn < 450000)
                {
                    band = "Between 400001 and 450000";
                }
                else if (amountIn <= 500000)
                {
                    band = "Between 450001 and 500000";
                }
                return band;
            }
        }

        // operation to calculate the propery tax
        [DisplayName("Local Property Tax (€)")]
        public double Calculate
        {
            get
            {
                //string  rate = System.Configuration.ConfigurationManager.AppSettings["TaxRate"];

                double result = (Double.Parse(System.Configuration.ConfigurationManager.AppSettings["TaxRate"]) / 100);
                double median = 0;
                if (amountIn <= 100000)
                {
                    median = 50000 * (result);
                }
                else if (amountIn <= 150000)
                {
                    median = 125000 * (result);
                }
                else if (amountIn <= 200000)
                {
                    median = 175000 * (result);
                }
                else if (amountIn <= 250000)
                {
                    median = 225000 * (result);
                }
                else if (amountIn <= 300000)
                {
                    median = 275000 * (result);
                }
                else if (amountIn < 350000)
                {
                    median = 325000 * (result);
                }
                else if (amountIn <= 400000)
                {
                    median = 375000 * (result);
                }
                else if (amountIn <= 450000)
                {
                    median = 425000 * (result);
                }
                else if (amountIn <= 500000)
                {
                    median = 475000 * (result);
                }
                return (median);
            }
        }
    }
}