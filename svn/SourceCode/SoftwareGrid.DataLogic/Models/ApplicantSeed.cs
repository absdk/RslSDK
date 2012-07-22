using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.Seed
{
    public sealed class ApplicantSourceCategorySeed
    {
     public static List<ApplicantSourceCategory> ApplicantSourceCategories
        {
            get
            {
                List<ApplicantSourceCategory> items = new List<ApplicantSourceCategory>();

                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 1, Name = "HR Department" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 2, Name = "Career Portal" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 3, Name = "Vendor Portal" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 4, Name = "Referral Program" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 5, Name = "FaceBook" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 6, Name = "LinkedIn" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 7, Name = "Resume Parser" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 8, Name = "Job Portal" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 9, Name = "Job Portal Monster" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 10, Name = "Job Portal CareerBuilder" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 11, Name = "Job Portal Dice" });
                items.Add(new ApplicantSourceCategory { ApplicantSourceCategoryID = 12, Name = "Job Portal Naukri" });
                
                return items;
            }
        }
    }

    public sealed class ApplicantAvailabilityStatusCategorySeed
    {
        public static List<ApplicantAvailabilityStatusCategory> ApplicantAvailabilityStatusCategories
        {
            get
            {
                List<ApplicantAvailabilityStatusCategory> items = new List<ApplicantAvailabilityStatusCategory>();

                items.Add(new ApplicantAvailabilityStatusCategory { ApplicantAvailabilityStatusCategoryID = 1, Name = "Actively Seeking Job" });
                items.Add(new ApplicantAvailabilityStatusCategory { ApplicantAvailabilityStatusCategoryID = 2, Name = "Passively Seeking Job" });
                items.Add(new ApplicantAvailabilityStatusCategory { ApplicantAvailabilityStatusCategoryID = 3, Name = "Not Avaialble" });

                return items;
            }
        }
    }

    public sealed class ApplicantSubmissionFeedbackCategorySeed
    {
        public static List<ApplicantSubmissionFeedbackCategory> ApplicantSubmissionFeedbackCategories
        {
            get
            {
                List<ApplicantSubmissionFeedbackCategory> items = new List<ApplicantSubmissionFeedbackCategory>();

                items.Add(new ApplicantSubmissionFeedbackCategory { ApplicantSubmissionFeedbackCategoryID = 1, Name = "Submitted" });
                items.Add(new ApplicantSubmissionFeedbackCategory { ApplicantSubmissionFeedbackCategoryID = 2, Name = "Short-Listed" });
                items.Add(new ApplicantSubmissionFeedbackCategory { ApplicantSubmissionFeedbackCategoryID = 3, Name = "Interview In Progress" });
                items.Add(new ApplicantSubmissionFeedbackCategory { ApplicantSubmissionFeedbackCategoryID = 4, Name = "Rejected" });
                items.Add(new ApplicantSubmissionFeedbackCategory { ApplicantSubmissionFeedbackCategoryID = 5, Name = "No Answer" });

                return items;
            }
        }
    }

    public sealed class ApplicantInterviewFeedbackCategorySeed
    {
        public static List<ApplicantInterviewFeedbackCategory> ApplicantInterviewFeedbackCategories
        {
            get
            {
                List<ApplicantInterviewFeedbackCategory> items = new List<ApplicantInterviewFeedbackCategory>();

                items.Add(new ApplicantInterviewFeedbackCategory { ApplicantInterviewFeedbackCategoryID = 1, Name = "Strongly Hire" });
                items.Add(new ApplicantInterviewFeedbackCategory { ApplicantInterviewFeedbackCategoryID = 2, Name = "Hire" });
                items.Add(new ApplicantInterviewFeedbackCategory { ApplicantInterviewFeedbackCategoryID = 3, Name = "Second Preference" });
                items.Add(new ApplicantInterviewFeedbackCategory { ApplicantInterviewFeedbackCategoryID = 4, Name = "Hold" });
                items.Add(new ApplicantInterviewFeedbackCategory { ApplicantInterviewFeedbackCategoryID = 5, Name = "Rejected" });

                return items;
            }
        }
    }

    public sealed class ApplicantRecruitmentCostCategorySeed
    {
        public static List<ApplicantRecruitmentCostCategory> ApplicantRecruitmentCostCategories
        {
            get
            {
                List<ApplicantRecruitmentCostCategory> items = new List<ApplicantRecruitmentCostCategory>();

                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 1, Name = "Recruitment Agency", CostCode ="1111" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 2, Name = "Relocation", CostCode = "1111" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 3, Name = "Transportation", CostCode = "1113" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 4, Name = "Visa", CostCode = "1114" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 5, Name = "Interview Trip", CostCode = "1115" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 6, Name = "Joining Ticket", CostCode = "1116" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 7, Name = "Background Checking", CostCode = "1117" });
                items.Add(new ApplicantRecruitmentCostCategory { ApplicantRecruitmentCostCategoryID = 8, Name = "Job Portal", CostCode = "1118" });
           

                return items;
            }
        }
    }

    public sealed class ApplicantDocumentCategorySeed
    {
        public static List<ApplicantDocumentCategory> ApplicantDocumentCategories
        {
            get
            {
                List<ApplicantDocumentCategory> items = new List<ApplicantDocumentCategory>();

                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 1, Name = "Professional Certificate" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 2, Name = "Employment Contract" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 3, Name = "Driver's License" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 4, Name = "Educational Certificate" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 5, Name = "Experience Certificate" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 6, Name = "Medical Report" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 6, Name = "Offer Letter" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 7, Name = "Passport" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 8, Name = "Reference letters" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 9, Name = "Travel Tickets" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 10, Name = "Trade Test Report" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 11, Name = "Visa Copy" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 12, Name = "Training Certificate" });
                items.Add(new ApplicantDocumentCategory { ApplicantDocumentCategoryID = 13, Name = "Non-Discloser Agreement" });
                return items;
            }
        }
    }
    

}































