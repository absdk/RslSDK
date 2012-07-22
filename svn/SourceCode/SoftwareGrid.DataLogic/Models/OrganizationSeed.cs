using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.Seed
{

    public sealed class OrganizationAddressCategorySeed
    {
        public static List<OrganizationAddressCategory> OrganizationAddressCategories
        {
            get
            {
                List<OrganizationAddressCategory> items = new List<OrganizationAddressCategory>();

                items.Add(new OrganizationAddressCategory { OrganizationAddressCategoryID = 1, Name = "Business Office" });
                items.Add(new OrganizationAddressCategory { OrganizationAddressCategoryID = 2, Name = "Billing Address" });
                items.Add(new OrganizationAddressCategory { OrganizationAddressCategoryID = 3, Name = "Delivery Address" });
                items.Add(new OrganizationAddressCategory { OrganizationAddressCategoryID = 4, Name = "Warehouse Address" });
                items.Add(new OrganizationAddressCategory { OrganizationAddressCategoryID = 5, Name = "Temporary Address" });


                return items;
            }
        }
    }

    public sealed class OrganizationCategorySeed
    {
        public static List<OrganizationCategory> OrganizationCategories
        {
            get
            {
                List<OrganizationCategory> items = new List<OrganizationCategory>();

                items.Add(new OrganizationCategory { OrganizationCategoryID = 1, Name = "Parent Organization" });
                items.Add(new OrganizationCategory { OrganizationCategoryID = 2, Name = "Subsidiary" });
                items.Add(new OrganizationCategory { OrganizationCategoryID = 3, Name = "Branch Office" });
                items.Add(new OrganizationCategory { OrganizationCategoryID = 4, Name = "Country Head Office" });
                items.Add(new OrganizationCategory { OrganizationCategoryID = 5, Name = "Regional Office" });
                items.Add(new OrganizationCategory { OrganizationCategoryID = 6, Name = "Sales Office" });

                return items;
            }
        }
    }

    public sealed class OrganizationNoteCategorySeed
    {
        public static List<OrganizationNoteCategory> OrganizationNoteCategories
        {
            get
            {
                List<OrganizationNoteCategory> items = new List<OrganizationNoteCategory>();

                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 1, Name = "Lease Agreement" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 2, Name = "Workforce" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 3, Name = "Infrastructure" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 4, Name = "Legal Issue" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 5, Name = "Revenue" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 6, Name = "License" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 7, Name = "Payment" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 8, Name = "Invoice" });
                items.Add(new OrganizationNoteCategory { OrganizationNoteCategoryID = 9, Name = "Bills" });
                return items;
            }
        }
    }

    public sealed class OrganizationDocumentCategorySeed
    {
        public static List<OrganizationDocumentCategory> OrganizationDocumentCategories
        {
            get
            {
                List<OrganizationDocumentCategory> items = new List<OrganizationDocumentCategory>();

                items.Add(new OrganizationDocumentCategory { OrganizationDocumentCategoryID = 1, Name = "Lease" });
                items.Add(new OrganizationDocumentCategory { OrganizationDocumentCategoryID = 2, Name = "Invoice" });
                items.Add(new OrganizationDocumentCategory { OrganizationDocumentCategoryID = 3, Name = "Business Agreement" });
                items.Add(new OrganizationDocumentCategory { OrganizationDocumentCategoryID = 4, Name = "Payment Slips" });
                items.Add(new OrganizationDocumentCategory { OrganizationDocumentCategoryID = 5, Name = "Business Certificate" });
                items.Add(new OrganizationDocumentCategory { OrganizationDocumentCategoryID = 6, Name = "Corporate Profiles" });
             
                return items;
            }
        }
    }
}
































