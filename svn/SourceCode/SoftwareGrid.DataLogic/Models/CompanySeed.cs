using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.Seed
{



    public sealed class SalesProductServiceCategorySeed

    {
        public static List<SalesProductServiceCategory> SalesProductServiceCategories
        {
            get
            {
                List<SalesProductServiceCategory> items = new List<SalesProductServiceCategory>();

                items.Add(new SalesProductServiceCategory { SalesProductServiceCategoryID = 1, Name = "Software", Description = string.Empty });
                items.Add(new SalesProductServiceCategory { SalesProductServiceCategoryID = 2, Name = "Recruitment Service", Description = string.Empty });
                items.Add(new SalesProductServiceCategory { SalesProductServiceCategoryID = 3, Name = "Staffing Service", Description = string.Empty });

                return items;
            }
        }
    
    }
   
    public sealed class SalesProductServiceCatelogSeed

    {
    
    }
       
    public sealed class CompanyAddressCategorySeed

    {
        public static List<CompanyAddressCategory> CompanyAddressCategories
        {
            get
            {
                List<CompanyAddressCategory> items = new List<CompanyAddressCategory>();

                items.Add(new CompanyAddressCategory { CompanyAddressCategoryID = 1, Name = "Billing Address" });
                items.Add(new CompanyAddressCategory { CompanyAddressCategoryID = 2, Name = "Delivery Address" });
                items.Add(new CompanyAddressCategory { CompanyAddressCategoryID = 3, Name = "Warehouse Address" });

                return items;
            }
        }
    }
    
    public sealed class CompanyStatusCategorySeed

    {
     public static List<CompanyStatusCategory> CompanyStatusCategories
        {
            get
            {
                List<CompanyStatusCategory> items = new List<CompanyStatusCategory>();

                items.Add(new CompanyStatusCategory { CompanyStatusCategoryID = 1, Name = "Contact Only" });
                items.Add(new CompanyStatusCategory { CompanyStatusCategoryID = 2, Name = "Prospective Client" });
                items.Add(new CompanyStatusCategory { CompanyStatusCategoryID = 3, Name = "Client" });
                items.Add(new CompanyStatusCategory { CompanyStatusCategoryID = 4, Name = "Paid Client" });
                items.Add(new CompanyStatusCategory { CompanyStatusCategoryID = 5, Name = "Highly Paid Client" });


                return items;
            }
        }
    }
  
    public sealed class SalesCampaignStatusCategorySeed

    {

        public static List<SalesCampaignStatusCategory> SalesCampaignStatusCategories
        {
            get
            {
                List<SalesCampaignStatusCategory> items = new List<SalesCampaignStatusCategory>();

                items.Add(new SalesCampaignStatusCategory { SalesCampaignStatusCategoryID = 1, Name = "Planned", });
                items.Add(new SalesCampaignStatusCategory { SalesCampaignStatusCategoryID = 1, Name = "In-Progress", });
                items.Add(new SalesCampaignStatusCategory { SalesCampaignStatusCategoryID = 2, Name = "Closed", });

                return items;
            }
        }
    
    }

    public sealed class SalesLeadStatusCategorySeed
    {
        public static List<SalesLeadStatusCategory> SalesLeadStatusCategories
        {
            get
            {
                List<SalesLeadStatusCategory> items = new List<SalesLeadStatusCategory>();

                items.Add(new SalesLeadStatusCategory { SalesLeadStatusCategoryID = 1, Name = "Open", });
                items.Add(new SalesLeadStatusCategory { SalesLeadStatusCategoryID = 2, Name = "Closed" });

                return items;
            }
        }
    }


}































