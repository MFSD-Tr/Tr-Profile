using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TracktiveDataObjectLayer.Web.DTO.Category.Utility
{
    public class CategpryRateDTO
    {

        public decimal BillableRate { get; set; }

        public decimal OTBillableRate { get; set; }

        public decimal  PremiumBillableRate { get; set; }

        public decimal Tax1 { get; set; }

        public decimal Tax2 { get; set; }

        public decimal Tax3 { get; set; }

        public decimal Tax4 { get; set; }

        public List<CategoryRateGlAccount> GlService { get; set; }
    }
    public class CategoryRateGlAccount
    {

        public long GlAccountId { get; set; }

        public string  GlPurchase { get; set; }

        public string GlAsset { get; set; }

        public string  GlExpense { get; set; }

        public string  GlIncome { get; set; }
    }
}
