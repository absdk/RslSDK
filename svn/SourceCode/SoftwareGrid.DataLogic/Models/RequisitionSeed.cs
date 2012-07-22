using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.Seed
 {
        public sealed class RequisitionApprovalStatusCategorySeed
        {
            public static List<RequisitionApprovalStatusCategory> RequisitionApprovalStatusCategories
            {
                get
                {
                    List<RequisitionApprovalStatusCategory> items = new List<RequisitionApprovalStatusCategory>();

                    items.Add(new RequisitionApprovalStatusCategory { RequisitionApprovalStatusCategoryID = 1, Name = "Submitted for Approval" });
                    items.Add(new RequisitionApprovalStatusCategory { RequisitionApprovalStatusCategoryID = 2, Name = "Approved" });
                    items.Add(new RequisitionApprovalStatusCategory { RequisitionApprovalStatusCategoryID = 3, Name = "Rejected" });
                    items.Add(new RequisitionApprovalStatusCategory { RequisitionApprovalStatusCategoryID = 4, Name = "Approval On Hold" });
                  

                    return items;
                }
            }
        }
        public sealed class RequisitionApprovalTeamCategorySeed
            {
               public static List<RequisitionTeamCategory> RequisitionTeamCategories
               {
              get
                {
                List<RequisitionTeamCategory> items = new List<RequisitionTeamCategory>();

                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 1, Name = "Human Resource Department" });
                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 2, Name = "Porject Management Office " });
                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 3, Name = "Senior Management " });
                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 4, Name = "Department Head " });
                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 5, Name = "Vendor Management Office " });
                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 6, Name = "Finance Department " });
                items.Add(new RequisitionTeamCategory { RequisitionTeamCategoryID = 7, Name = "Applicant Sourcing Team" });
                  return items;
            }
        }
    }
    
        public sealed class RequisitionStatusCategorySeed
    {
        public static List<RequisitionStatusCategory> RequisitionStatusCategories
        {
            get
            {
                List<RequisitionStatusCategory> items = new List<RequisitionStatusCategory>();

                items.Add(new RequisitionStatusCategory { RequisitionStatusCategoryID = 1, Name = "Draft" });
                items.Add(new RequisitionStatusCategory { RequisitionStatusCategoryID = 2, Name = "Open" });
                items.Add(new RequisitionStatusCategory { RequisitionStatusCategoryID = 3, Name = "Planned" });
                items.Add(new RequisitionStatusCategory { RequisitionStatusCategoryID = 4, Name = "On Hold" });
                items.Add(new RequisitionStatusCategory { RequisitionStatusCategoryID = 5, Name = "Closed & Successful Hire" });
                items.Add(new RequisitionStatusCategory { RequisitionStatusCategoryID = 6, Name = "Closed Without Hire" });
              

                return items;
            }
        }
    }

        public sealed class RequisitionInterviewTypeSeed
    {
        public static List<RequisitionInterviewType> RequisitionInterviewTypes
        {
            get
            {
                List<RequisitionInterviewType> items = new List<RequisitionInterviewType>();

                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 1, Name = "Initial Screening" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 2, Name = "Technical Interview" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 3, Name = "Telephonic Screening" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 4, Name = "Face to Face Interview" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 5, Name = "Medical Test" });
                 items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 6, Name = "Trade Test" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 6, Name = "Backgrouck Check" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 8, Name = "Final Interview" });
                items.Add(new RequisitionInterviewType { RequisitionInterviewTypeID = 9, Name = "Hire List" });

                return items;
            }
        }
    }









}


































