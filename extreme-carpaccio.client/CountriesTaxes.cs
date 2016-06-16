using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace xCarpaccio.client
{
    public class CountriesTaxes
    {
        public Dictionary<string, decimal> Taxes { get; set; }

        public CountriesTaxes()
        {
            Taxes = new Dictionary<string, decimal>();
            Taxes.Add("DE", (decimal)1.20);
            Taxes.Add("UK", (decimal)1.21);
            Taxes.Add("FR", (decimal)1.20);
            Taxes.Add("IT", (decimal)1.25);
            Taxes.Add("ES", (decimal)1.19);
            Taxes.Add("PL", (decimal)1.21);
            Taxes.Add("RO", (decimal)1.20);
            Taxes.Add("NL", (decimal)1.20);
            Taxes.Add("BE", (decimal)1.24);
            //Taxes.Add("Greece", 20);
            //Taxes.Add("Czech Republic", 20);
            //Taxes.Add("Portugal", 20);
            //Taxes.Add("Hungary", 20);
            //Taxes.Add("Sweden", 20);
            //Taxes.Add("Austria", 20);
            //Taxes.Add("Bulgaria", 20);
            //Taxes.Add("Denmark", 20);
            //Taxes.Add("Finland", 20);
            //Taxes.Add("Slovakia", 20);
            //Taxes.Add("Ireland", 20);
            //Taxes.Add("Croatia", 20);
            //Taxes.Add("Lithuania", 20);
            //Taxes.Add("Slovenia", 20);
            //Taxes.Add("Latvia", 20);
            //Taxes.Add("Estonia", 20);
            //Taxes.Add("Cyprus", 20);
            //Taxes.Add("Luxembourg", 20);
            //Taxes.Add("Malta", 20);
        }
    }
}
