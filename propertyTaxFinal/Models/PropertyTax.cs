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
                for (int i = 50000; i < 500000; i = (i + 50000))
                {
                    if (amountIn <= i)
                    {
                        band = "Between " + (i - 50000) + " and " + i + "";
                        return band;
                    }
                }
                return "ERROR";
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
                int min, max;

                for (int i = 50000; i < 500000; i = (i + 50000))
                {
                    if (amountIn <= i)
                    {
                        min = i - 50000;
                        max = i;
                        median = (min + (min - max)/2) * (result);
                        return median;
                    }
                }
                return 0.0;
            }
        }
    }
}