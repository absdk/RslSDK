using System.Collections.Generic;
using SoftwareGrid.DataLogic.Models;

namespace SoftwareGrid.DataLogic.Seed
{

    public sealed class SkillsExpEduCategorySeed
    {
        public static List<SkillsExpEduCategory> SkillsExpEduCategories
        {
            get
            {
                List<SkillsExpEduCategory> items = new List<SkillsExpEduCategory>();

                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 1, Name = "Skills", ParentSkillsExpEduCategoryID = null,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 2, Name = "Managerial Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 3, Name = "Software Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 4, Name = "Hardware Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 5, Name = "Communication Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 6, Name = " Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 7, Name = "Managerial Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 8, Name = "Managerial Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 9, Name = "Managerial Skills", ParentSkillsExpEduCategoryID = 1,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 10, Name = "Managerial Skills", ParentSkillsExpEduCategoryID = 1,});


                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 11, Name = "Education", ParentSkillsExpEduCategoryID = null,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 12, Name = "Certification", ParentSkillsExpEduCategoryID = null,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 13, Name = "License", ParentSkillsExpEduCategoryID = null,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 14, Name = "Languges", ParentSkillsExpEduCategoryID = null,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 15, Name = "Experiences", ParentSkillsExpEduCategoryID = null,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 16, Name = "Industry Experience", ParentSkillsExpEduCategoryID = 15,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 17, Name = "Line of Business or Subject Matter Expertise", ParentSkillsExpEduCategoryID = 15,});
                items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 18, Name = "Regional Experience", ParentSkillsExpEduCategoryID = 15,});
                //items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 19, Name = "Experience", ParentSkillsExpEduCategoryID = null,});
                //items.Add(new SkillsExpEduCategory { SkillsExpEduCategoryID = 20, Name = "Experience", ParentSkillsExpEduCategoryID = null,});

               


                return items;
            }
        }
    }

    public partial class SkillsExpEduSeed
    {
        public static List<SkillsExpEdu> Competencies
        {
            get
            {
                List<SkillsExpEdu> items = new List<SkillsExpEdu>();

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });

                items.Add(new SkillsExpEdu
                {
                    SkillsExpEduID = 1,
                    SkillsExpEduCategoryID = 1,
                    Title = "asp.net",
                    Description = ""
                });


                return items;
            }
        }
    }


    #region Education

    public partial class SkillsExpEduSeed
    {
        public static List<SkillsExpEdu> SkillsExpEdu
        {
            get
            {
                List<SkillsExpEdu> items = new List<SkillsExpEdu>();


                items.Add(new SkillsExpEdu { SkillsExpEduID = 1, SkillsExpEduCategoryID = 11, Title = "High School", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 2, SkillsExpEduCategoryID = 11, Title = "Diploma", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 3, SkillsExpEduCategoryID = 11, Title = "GED", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 4, SkillsExpEduCategoryID = 11, Title = "Bachelor Degree", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 5, SkillsExpEduCategoryID = 11, Title = "Masters Degree", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 6, SkillsExpEduCategoryID = 11, Title = "PhD", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 7, SkillsExpEduCategoryID = 11, Title = "MBA", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 8, SkillsExpEduCategoryID = 11, Title = "BS-Computer Science", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 9, SkillsExpEduCategoryID = 11, Title = "BS-Electrical Engineering", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 10, SkillsExpEduCategoryID = 11, Title = "BS-Civil Engineering", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 11, SkillsExpEduCategoryID = 11, Title = "BS-Mechanical Engineering", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 12, SkillsExpEduCategoryID = 11, Title = "BA-Commerce", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 13, SkillsExpEduCategoryID = 11, Title = "Medical Doctor", Description = null, });




                return items;
            }
        }
    }

    #endregion Education

    #region Certificate

    public partial class SkillsExpEduSeed
    {
        public static List<SkillsExpEdu> SkillsCertificate
        {
            get
            {
                List<SkillsExpEdu> items = new List<SkillsExpEdu>();

                items.Add(new SkillsExpEdu { SkillsExpEduID = 21, SkillsExpEduCategoryID = 12, Title = "CCNA", Description = "Cisco Computer Network Associate, Issuance Institute Cisco", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 22, SkillsExpEduCategoryID = 12, Title = "CCNP", Description = "Cisco Computer Network Professional, Issuance Institute Cisco", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 23, SkillsExpEduCategoryID = 12, Title = "CCDA", Description = "Cisco Certified Design Associate, Issuance Institute Cisco", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 24, SkillsExpEduCategoryID = 12, Title = "CCSP", Description = "CISCO Certified Security Professional, Issuance Institute Cisco", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 25, SkillsExpEduCategoryID = 12, Title = "CCNA", Description = "Cisco Computer Network Associate by Cisco, Issuance Institute Cisco", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 26, SkillsExpEduCategoryID = 12, Title = "VCP", Description = "VMware Certified Professional, Issuance Institute Microsoft", });
               
                items.Add(new SkillsExpEdu { SkillsExpEduID = 27, SkillsExpEduCategoryID = 12, Title = "MCP", Description = "Microsoft Certified Professional, Issuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 28, SkillsExpEduCategoryID = 12, Title = "MCITP-EMA", Description = "Exchange Server 2010 – (Enterprise Messaging Administrator 2010)Issuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 29, SkillsExpEduCategoryID = 12, Title = "MCITP-SAT", Description = "Windows Server 2008 – (Server Administrator Track)Issuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 30, SkillsExpEduCategoryID = 12, Title = "MCITP-EAT", Description = "Windows Server 2008 – (Enterprise Administrator Track) Issuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 31, SkillsExpEduCategoryID = 12, Title = "MCITP-EDST", Description = " Windows 7: Enterprise Desktop Support Technician 7Issuance InstituteMicrosoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 32, SkillsExpEduCategoryID = 12, Title = "MOSC", Description = "Microsoft Office Specialist CertificateIssuance InstituteMicrosoft ", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 33, SkillsExpEduCategoryID = 12, Title = "MCTS-ASP.Net", Description = " .NET Framework 3.5  ASP.NetIssuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 34, SkillsExpEduCategoryID = 12, Title = "MCTS-ADO.Net", Description = ".NET Framework 3.5 ADO.NetIssuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 35, SkillsExpEduCategoryID = 12, Title = "MCTS-SQLIM", Description = "Microsoft SQL Server 2008 (Implementation and Maintenance)Issuance Institute Microsoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 36, SkillsExpEduCategoryID = 12, Title = "MCTS-MES", Description = " Windows 7: Enterprise Desktop Support Technician 7Issuance InstituteMicrosoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 37, SkillsExpEduCategoryID = 12, Title = "MCTS-WSNIC", Description = " Windows 7: Enterprise Desktop Support Technician 7Issuance InstituteMicrosoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 38, SkillsExpEduCategoryID = 12, Title = "MBTS", Description = "Microsoft BizTalk Server 2010, Issuance Institute Microsoft", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 39, SkillsExpEduCategoryID = 12, Title = "ISA", Description = "Microsoft Internet Security and Acceleration Server 2006, Issuance InstituteMicrosoft", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 40, SkillsExpEduCategoryID = 12, Title = "MCAS", Description = "Microsoft Certified Application Specialist, Issuance InstituteMicrosoft", });
               
                items.Add(new SkillsExpEdu { SkillsExpEduID = 40, SkillsExpEduCategoryID = 12, Title = "OCP", Description = "Oracle Certified Professional, Issuance Institute ORACLE", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 41, SkillsExpEduCategoryID = 12, Title = "ODA", Description = "Oracle Database Administrator, Issuance Institute ORACLE", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 42, SkillsExpEduCategoryID = 12, Title = "ODD", Description = "OracleDatabase Developer, Issuance Institute ORACLE", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 43, SkillsExpEduCategoryID = 12, Title = "CAPM", Description = "Certified Associate in  Project ManagementIssuance InstituteProject Management Institute (PMI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 44, SkillsExpEduCategoryID = 12, Title = "PMP", Description = "Project Management ProfessionalIssuance InstituteProject Management Institute (PMI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 45, SkillsExpEduCategoryID = 12, Title = "PgMP", Description = "Program Management ProfessionalIssuance InstituteProject Management Institute (PMI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 46, SkillsExpEduCategoryID = 12, Title = "PMI-ACP", Description = "PMI Agile Certified Practitioner Issuance InstituteProject Management Institute (PMI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 47, SkillsExpEduCategoryID = 12, Title = "PMI-RMP", Description = "Risk Management Professional Issuance InstituteProject Management Institute (PMI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 48, SkillsExpEduCategoryID = 12, Title = "PMI-SP", Description = "Scheduling Professional Issuance InstituteProject Management Institute (PMI)", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 49, SkillsExpEduCategoryID = 12, Title = "SPHR", Description = "Professional in Human ResourcesIssuance InstituteThe Society for Human Resource Management(SHRM )", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 50, SkillsExpEduCategoryID = 12, Title = "CHRP", Description = "Certificate in Human Resources Practice Issuance InstituteThe Chartered Institute of Personnel and Development(CIPD)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 51, SkillsExpEduCategoryID = 12, Title = "HRM", Description = "Certificate in Human Resources Management, Issuance InstituteThe Chartered Institute of Personnel and Development(CIPD)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 52, SkillsExpEduCategoryID = 12, Title = "PHR", Description = "Professional in Human Resources, Issuance InstituteThe Society for Human Resource Management(SHRM )", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 53, SkillsExpEduCategoryID = 12, Title = "HRD", Description = "Certificate in Human Resources Development, Issuance InstituteThe Chartered Institute of Personnel and Development(CIPD)", });

               
                items.Add(new SkillsExpEdu { SkillsExpEduID = 54, SkillsExpEduCategoryID = 12, Title = "CeMA", Description = "Certified eMarketing AssociateIssuance InstituteThe eMarketing Association(eMA)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 55, SkillsExpEduCategoryID = 12, Title = "CFMP", Description = "Certified Financial Marketing ProfessionalIssuance InstituteThe  American Bankers Association(ABA)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 56, SkillsExpEduCategoryID = 12, Title = "PCM", Description = "Professional Certificate in Marketing Issuance InstituteThe Chartered Institute of Marketing (CIM)", });

                
               
                items.Add(new SkillsExpEdu { SkillsExpEduID = 57, SkillsExpEduCategoryID = 12, Title = "CMA", Description = "Certified Management Accountant, Issuance InstituteInstitute of Management Accountants(IMA)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 58, SkillsExpEduCategoryID = 12, Title = "CIF", Description = "Certificate in Islamic Finance, Issuance InstituteThe Chartered Institute of Management Accountants(CIMA)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 59, SkillsExpEduCategoryID = 12, Title = "CIMA", Description = "Chartered Institute of Management Accountants, Issuance InstituteThe Chartered Institute of Management Accountants(CIMA)", });
             
                items.Add(new SkillsExpEdu { SkillsExpEduID = 60, SkillsExpEduCategoryID = 12, Title = "CISI", Description = " Islamic Finance Qualification Issuance InstituteThe Chartered Institute for Securities & Investment (CISI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 61, SkillsExpEduCategoryID = 12, Title = "ICWM", Description = "International Certificate in Wealth Management, Issuance InstituteThe Chartered Institute for Securities & Investment (CISI)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 62, SkillsExpEduCategoryID = 12, Title = "IISI", Description = "International Introduction to Securities & Invesment, Issuance Institute The Chartered Institute for Securities & Investment (CISI)", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 63, SkillsExpEduCategoryID = 12, Title = "CBA", Description = "Certified Bank Auditor, Issuance Institute BAI", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 64, SkillsExpEduCategoryID = 12, Title = "CFA", Description = "Chartered Financial Analyst, Issuance Institute CFA Institute ", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 65, SkillsExpEduCategoryID = 12, Title = "CPA", Description = "Certified Public Accountant, Issuance Institute The American Institute of Certified Public  Accountants(AICPA)", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 66, SkillsExpEduCategoryID = 12, Title = "CQA", Description = "Certified Quality Auditor Issuance Institute ISO", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 67, SkillsExpEduCategoryID = 12, Title = "SSH", Description = "Specialists in Safety and HealthIssuance InstituteOccupational Safety and Health Administration(OSHA)", });

                items.Add(new SkillsExpEdu { SkillsExpEduID = 68, SkillsExpEduCategoryID = 12, Title = "CE", Description = "Chartered Engineer, Issuance InstituteThe Engineering Council", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 69, SkillsExpEduCategoryID = 12, Title = "PE", Description = "Professional Engineer, Issuance Institutehe National Council of Examiners for Engineering and Surveying(NCEES)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 70, SkillsExpEduCategoryID = 12, Title = "CCP", Description = "Certified Construction Professional, Issuance InstituteThe American Institute of Constructors(AIC)", });
                        

                items.Add(new SkillsExpEdu { SkillsExpEduID = 71, SkillsExpEduCategoryID = 12, Title = "CSCP", Description = "Certified Supply Chain Professional, Issuance InstituteThe Association for Operations Management(AIPICS)", });
           
                items.Add(new SkillsExpEdu { SkillsExpEduID = 72, SkillsExpEduCategoryID = 12, Title = "CWD", Description = "Web Design SpecialistIssuance InstituteCertified Internet Web Professional(CIW)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 72, SkillsExpEduCategoryID = 12, Title = "CIW", Description = "Certified Internet Web Professional, Issuance Institute Certified Internet Web Professional(CIW)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 74, SkillsExpEduCategoryID = 12, Title = "CISSP", Description = "Certified Information Systems Security Professional, Issuance Institute ISACA", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 75, SkillsExpEduCategoryID = 12, Title = "CITP", Description = "Chartered IT Professional Issuance Institute The Chartered Institute for IT(BCS)", });
              
                items.Add(new SkillsExpEdu { SkillsExpEduID = 76, SkillsExpEduCategoryID = 12, Title = "CTIAOSH", Description = "CompTIA A+ (Operating System & Hardware)Issuance InstituteThe Computing Technology Industry Association (CompTIA)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 77, SkillsExpEduCategoryID = 12, Title = "CTIAN", Description = "CompTIA Network +Issuance InstituteThe Computing Technology Industry Association (CompTIA)", });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 78, SkillsExpEduCategoryID = 12, Title = "CTIAS", Description = "CompTIA Security +Issuance InstituteThe Computing Technology Industry Association (CompTIA)", });


                return items;
            }
        }
    }

    #endregion

    #region Language

    public partial class SkillsExpEduSeed
    {
        public static List<SkillsExpEdu> SkillsExpEdues
        {
            get
            {
                List<SkillsExpEdu> items = new List<SkillsExpEdu>();


                items.Add(new SkillsExpEdu { SkillsExpEduID = 101, SkillsExpEduCategoryID = 14, Title = "English", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 102, SkillsExpEduCategoryID = 14, Title = "Spanish", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 103, SkillsExpEduCategoryID = 14, Title = "Hindi", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 104, SkillsExpEduCategoryID = 14, Title = "Arabic", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 105, SkillsExpEduCategoryID = 14, Title = "Urdu", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 106, SkillsExpEduCategoryID = 14, Title = "Afrikaans", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 107, SkillsExpEduCategoryID = 14, Title = "Azeri", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 108, SkillsExpEduCategoryID = 14, Title = "Bengali", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 109, SkillsExpEduCategoryID = 14, Title = "Burmese", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 110, SkillsExpEduCategoryID = 14, Title = "Cantonese", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 111, SkillsExpEduCategoryID = 14, Title = "Czech", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 112, SkillsExpEduCategoryID = 14, Title = "Dutch-Flemish", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 113, SkillsExpEduCategoryID = 14, Title = "Filipino", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 114, SkillsExpEduCategoryID = 14, Title = "French", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 115, SkillsExpEduCategoryID = 14, Title = "German", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 116, SkillsExpEduCategoryID = 14, Title = "Greek", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 117, SkillsExpEduCategoryID = 14, Title = "Gujarati", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 118, SkillsExpEduCategoryID = 14, Title = "Hungarian", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 119, SkillsExpEduCategoryID = 14, Title = "Italian", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 120, SkillsExpEduCategoryID = 14, Title = "Japanese", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 121, SkillsExpEduCategoryID = 14, Title = "Kannada", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 122, SkillsExpEduCategoryID = 14, Title = "Korean", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 123, SkillsExpEduCategoryID = 14, Title = "Kurdish", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 124, SkillsExpEduCategoryID = 14, Title = "Malayalam", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 125, SkillsExpEduCategoryID = 14, Title = "Mandarin", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 126, SkillsExpEduCategoryID = 14, Title = "Marathi", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 127, SkillsExpEduCategoryID = 14, Title = "Nepali", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 128, SkillsExpEduCategoryID = 14, Title = "Oriya", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 129, SkillsExpEduCategoryID = 14, Title = "Persian", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 130, SkillsExpEduCategoryID = 14, Title = "Portuguese", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 131, SkillsExpEduCategoryID = 14, Title = "Punjabi", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 132, SkillsExpEduCategoryID = 14, Title = "Romanian", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 133, SkillsExpEduCategoryID = 14, Title = "Russian", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 134, SkillsExpEduCategoryID = 14, Title = "Sindhi", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 135, SkillsExpEduCategoryID = 14, Title = "Sudanese", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 136, SkillsExpEduCategoryID = 14, Title = "Swedish", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 137, SkillsExpEduCategoryID = 14, Title = "Tamil", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 138, SkillsExpEduCategoryID = 14, Title = "Telugu", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 139, SkillsExpEduCategoryID = 14, Title = "Thai", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 140, SkillsExpEduCategoryID = 14, Title = "Turkish", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 141, SkillsExpEduCategoryID = 14, Title = "Ukrainian", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 142, SkillsExpEduCategoryID = 14, Title = "Uzbek", Description = null, });
                items.Add(new SkillsExpEdu { SkillsExpEduID = 143, SkillsExpEduCategoryID = 14, Title = "Not Listed", Description = null, });
                
                return items;
            }
        }
    }

    #endregion 


      

    public sealed class BusinessDivisionSeed
    {
        public static List<BusinessDivision> BusinessDivisions
        {
            get
            {
                List<BusinessDivision> items = new List<BusinessDivision>();

                items.Add(new BusinessDivision { BusinessDivisionID = 1, Name = "Test1" });
               

                return items;
            }
        }
    }
    public sealed class DepartmentSeed
    {
        public static List<Department> Departments
        {
            get
            {
                List<Department> items = new List<Department>();

                items.Add(new Department { DepartmentID = 1, Name = "Accounting and Finance" });
                items.Add(new Department { DepartmentID = 2, Name = "Management" });
                items.Add(new Department { DepartmentID = 2, Name = "Human Resource" });
                items.Add(new Department { DepartmentID = 2, Name = "Information Technology" });
                items.Add(new Department { DepartmentID = 2, Name = "Sales & Marketing" });
                items.Add(new Department { DepartmentID = 2, Name = "Management" });
                items.Add(new Department { DepartmentID = 2, Name = "Management" });
                items.Add(new Department { DepartmentID = 2, Name = "Management" });

                return items;
            }
        }
    }
    public sealed class PositionSeed
    {
        public static List<Position> Positions
        {
            get
            {
                List<Position> items = new List<Position>();

                items.Add(new Position
                    {
                         PositionID =1, 
                         DepartmentID = 1,
                         Name = "", 
                         JobDescription = "",
                          
                     });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });

                items.Add(new Position
                {
                    PositionID = 1,
                    DepartmentID = 1,
                    Name = "",
                    JobDescription = "",

                });
               
                return items;
            }
        }



    }




    //<select name="jobFunctions">
    //    <option selected="selected" value="acct">Accounting/Auditing</option>
    //    <option value="adm">Administrative</option>
    //    <option value="advr">Advertising</option>
    //    <option value="anls">Analyst</option>
    //    <option value="art">Art/Creative</option>
    //    <option value="bd">Business Development</option>
    //    <option value="cnsl">Consulting</option>
    //    <option value="cust">Customer Service</option>
    //    <option value="dsgn">Design</option>
    //    <option value="dist">Distribution</option>
    //    <option value="edu">Education</option>
    //    <option value="eng">Engineering</option>
    //    <option value="fin">Finance</option>
    //    <option value="genb">General Business</option>
    //    <option value="hcpr">Health Care Provider</option>
    //    <option value="hr">Human Resources</option>
    //    <option value="it">Information Technology</option>
    //    <option value="lgl">Legal</option>
    //    <option value="mgmt">Management</option>
    //    <option value="mnfc">Manufacturing</option>
    //    <option value="mrkt">Marketing</option>
    //    <option value="prod">Production</option>
    //    <option value="prdm">Product Management</option>
    //    <option value="prjm">Project Management</option>
    //    <option value="pr">Public Relations</option>
    //    <option value="prch">Purchasing</option>
    //    <option value="qa">Quality Assurance</option>
    //    <option value="rsch">Research</option>
    //    <option value="sale">Sales</option>
    //    <option value="sci">Science</option>
    //    <option value="stra">Strategy/Planning</option>
    //    <option value="supl">Supply Chain</option>
    //    <option value="trng">Training</option>
    //    <option value="wrt">Writing/Editing</option>
    //    <option value="othr">Other</option>


    //Line of Business
    //Buildings and Industrial Plants
    //Roads & Highway
    //Airports
    //Water and Environment
    //Oil and Gas
    //Information Technology
    //Transport
    //Infrastructure
    //Project Development and Management
    //Site Supervision
    //Interdisciplinary Services
    //Master Planning and Urban Design


    //items.Add(new MdmCompetencyCategory { MdmCompetencyCategoryID = 1, Name = "Technical" });
    //items.Add(new MdmCompetencyCategory { MdmCompetencyCategoryID = 2, Name = "Sales & Marketing" });
    //items.Add(new MdmCompetencyCategory { MdmCompetencyCategoryID = 3, Name = "Production" });
    //items.Add(new MdmCompetencyCategory { MdmCompetencyCategoryID = 4, Name = "Communication" });
    //items.Add(new MdmCompetencyCategory { MdmCompetencyCategoryID = 5, Name = "Medical" });
    //items.Add(new MdmCompetencyCategory { MdmCompetencyCategoryID = 6, Name = "Construction" });





    //public sealed class IndustrySeed
    //{
    //    public static List<Industry> Industries
    //    {
    //        get
    //        {
    //            List<Industry> items = new List<Industry>();

    //            items.Add(new Industry { IndustryID = 1, Name = "Accounting" });
    //            items.Add(new Industry { IndustryID = 2, Name = "Airlines/Aviation" });
    //            items.Add(new Industry { IndustryID = 3, Name = "Alternative Dispute Resolution" });
    //            items.Add(new Industry { IndustryID = 4, Name = "Alternative Medicine" });
    //            items.Add(new Industry { IndustryID = 5, Name = "Animation" });
    //            items.Add(new Industry { IndustryID = 6, Name = "Apparel Fashion" });
    //            items.Add(new Industry { IndustryID = 7, Name = "Architecture Planning" });
    //            items.Add(new Industry { IndustryID = 8, Name = "Arts and Crafts" });
    //            items.Add(new Industry { IndustryID = 9, Name = "Automotive" });
    //            items.Add(new Industry { IndustryID = 10, Name = "Aviation  Aerospace" });
    //            items.Add(new Industry { IndustryID = 11, Name = "Banking" });
    //            items.Add(new Industry { IndustryID = 12, Name = "Biotechnology" });
    //            items.Add(new Industry { IndustryID = 13, Name = "Broadcast Media" });
    //            items.Add(new Industry { IndustryID = 14, Name = "Building Materials" });
    //            items.Add(new Industry { IndustryID = 14, Name = "Business Supplies and Equipment" });
    //            items.Add(new Industry { IndustryID = 15, Name = "Capital Markets" });
    //            items.Add(new Industry { IndustryID = 16, Name = "Chemicals" });
    //            items.Add(new Industry { IndustryID = 17, Name = "Civic Social Organization" });
    //            items.Add(new Industry { IndustryID = 18, Name = "Civil Engineering" });
    //            items.Add(new Industry { IndustryID = 19, Name = "Commercial Real Estate" });
    //            items.Add(new Industry { IndustryID = 20, Name = "Computer Network Security" });
    //            items.Add(new Industry { IndustryID = 21, Name = "Computer Games" });
    //            items.Add(new Industry { IndustryID = 22, Name = "Computer Hardware" });
    //            items.Add(new Industry { IndustryID = 23, Name = "Computer Networking" });
    //            items.Add(new Industry { IndustryID = 24, Name = "Computer Software" });
    //            items.Add(new Industry { IndustryID = 25, Name = "Construction" });
    //            items.Add(new Industry { IndustryID = 26, Name = "Consumer Electronics" });
    //            items.Add(new Industry { IndustryID = 27, Name = "Consumer Goods" });
    //            items.Add(new Industry { IndustryID = 28, Name = "Consumer Services" });
    //            items.Add(new Industry { IndustryID = 29, Name = "Cosmetics" });
    //            items.Add(new Industry { IndustryID = 30, Name = "Dairy" });
    //            items.Add(new Industry { IndustryID = 31, Name = "Defense  Space" });
    //            items.Add(new Industry { IndustryID = 32, Name = "Design" });
    //            items.Add(new Industry { IndustryID = 33, Name = "Education Management" });
    //            items.Add(new Industry { IndustryID = 34, Name = "E-Learning" });
    //            items.Add(new Industry { IndustryID = 35, Name = "Electrical/Electronic Manufacturing" });
    //            items.Add(new Industry { IndustryID = 36, Name = "Entertainment" });
    //            items.Add(new Industry { IndustryID = 37, Name = "Environmental Services" });
    //            items.Add(new Industry { IndustryID = 38, Name = "Events Services" });
    //            items.Add(new Industry { IndustryID = 39, Name = "Executive Office" });
    //            items.Add(new Industry { IndustryID = 40, Name = "Facilities Services" });
    //            items.Add(new Industry { IndustryID = 41, Name = "Farming" });
    //            items.Add(new Industry { IndustryID = 42, Name = "Financial Services" });
    //            items.Add(new Industry { IndustryID = 43, Name = "Fine Art" });
    //            items.Add(new Industry { IndustryID = 44, Name = "Fishery" });
    //            items.Add(new Industry { IndustryID = 45, Name = "Food  Beverages" });
    //            items.Add(new Industry { IndustryID = 46, Name = "Food Production" });
    //            items.Add(new Industry { IndustryID = 47, Name = "Fund-Raising" });
    //            items.Add(new Industry { IndustryID = 48, Name = "Furniture" });
    //            items.Add(new Industry { IndustryID = 49, Name = "Gambling  Casinos" });
    //            items.Add(new Industry { IndustryID = 50, Name = "Glass, Ceramics Concrete" });
    //            items.Add(new Industry { IndustryID = 51, Name = "Government Administration" });
    //            items.Add(new Industry { IndustryID = 52, Name = "Government Relations" });
    //            items.Add(new Industry { IndustryID = 53, Name = "Graphic Design" });
    //            items.Add(new Industry { IndustryID = 54, Name = "Health, Wellness and Fitness" });
    //            items.Add(new Industry { IndustryID = 55, Name = "Fund-Raising" });
    //            items.Add(new Industry { IndustryID = 56, Name = "Furniture" });
    //            items.Add(new Industry { IndustryID = 57, Name = "Gambling  Casinos" });
    //            items.Add(new Industry { IndustryID = 58, Name = "Glass, Ceramics Concrete" });
    //            items.Add(new Industry { IndustryID = 59, Name = "Government Administration" });
    //            items.Add(new Industry { IndustryID = 60, Name = "Government Relations" });
    //            items.Add(new Industry { IndustryID = 61, Name = "Graphic Design" });
    //            items.Add(new Industry { IndustryID = 62, Name = "Health, Wellness and Fitness" });
    //            items.Add(new Industry { IndustryID = 63, Name = "Higher Education" });
    //            items.Add(new Industry { IndustryID = 64, Name = "Hospital  Health Care" });
    //            items.Add(new Industry { IndustryID = 65, Name = "Hospitality" });
    //            items.Add(new Industry { IndustryID = 66, Name = "Human Resources" });
    //            items.Add(new Industry { IndustryID = 67, Name = "Import and Export" });
    //            items.Add(new Industry { IndustryID = 68, Name = "Individual  Family Services" });
    //            items.Add(new Industry { IndustryID = 69, Name = "Industrial Automation" });
    //            items.Add(new Industry { IndustryID = 70, Name = "Information Services" });
    //            items.Add(new Industry { IndustryID = 71, Name = "Information Technology and Services" });
    //            items.Add(new Industry { IndustryID = 72, Name = "Insurance" });
    //            items.Add(new Industry { IndustryID = 73, Name = "International Affairs" });
    //            items.Add(new Industry { IndustryID = 74, Name = "International Trade and Development" });
    //            items.Add(new Industry { IndustryID = 75, Name = "Internet" });
    //            items.Add(new Industry { IndustryID = 76, Name = "Investment Banking" });
    //            items.Add(new Industry { IndustryID = 77, Name = "Investment Management" });
    //            items.Add(new Industry { IndustryID = 78, Name = "Judiciary" });
    //            items.Add(new Industry { IndustryID = 79, Name = "Law Enforcement" });
    //            items.Add(new Industry { IndustryID = 80, Name = "Law Practice" });
    //            items.Add(new Industry { IndustryID = 81, Name = "Legal Services" });
    //            items.Add(new Industry { IndustryID = 82, Name = "Legislative Office" });
    //            items.Add(new Industry { IndustryID = 83, Name = "Leisure, Travel  Tourism" });
    //            items.Add(new Industry { IndustryID = 84, Name = "Libraries" });
    //            items.Add(new Industry { IndustryID = 85, Name = "Logistics and Supply Chain" });
    //            items.Add(new Industry { IndustryID = 86, Name = "Luxury Goods Jewelry" });
    //            items.Add(new Industry { IndustryID = 87, Name = "Machinery" });
    //            items.Add(new Industry { IndustryID = 88, Name = "Management Consulting" });
    //            items.Add(new Industry { IndustryID = 89, Name = "Maritime" });
    //            items.Add(new Industry { IndustryID = 90, Name = "Marketing and Advertising" });
    //            items.Add(new Industry { IndustryID = 91, Name = "Market Research" });
    //            items.Add(new Industry { IndustryID = 92, Name = "Mechanical or Industrial Engineering" }); 
    //            items.Add(new Industry { IndustryID = 93, Name = "Media Production" });
    //            items.Add(new Industry { IndustryID = 94, Name = "Medical Devices" });
    //            items.Add(new Industry { IndustryID = 95, Name = "Medical Practice" });
    //            items.Add(new Industry { IndustryID = 96, Name = "Mental Health Care" });
    //            items.Add(new Industry { IndustryID = 97, Name = "Military" });
    //            items.Add(new Industry { IndustryID = 98, Name = "Mining  Metals" });
    //            items.Add(new Industry { IndustryID = 99, Name = "Motion Pictures and Film" });
    //            items.Add(new Industry { IndustryID = 100, Name = "Museums and Institutions" });
    //            items.Add(new Industry { IndustryID = 101, Name = "Music" });
    //            items.Add(new Industry { IndustryID = 102, Name = "Nanotechnology" });
    //            items.Add(new Industry { IndustryID = 103, Name = "Newspapers" });
    //            items.Add(new Industry { IndustryID = 104, Name = "Nonprofit Organization Management" });
    //            items.Add(new Industry { IndustryID = 105, Name = "Oil  Energy" });
    //            items.Add(new Industry { IndustryID = 106, Name = "Online Media" });
    //            items.Add(new Industry { IndustryID = 107, Name = "Outsourcing/Offshoring" });
    //            items.Add(new Industry { IndustryID = 108, Name = "Package/Freight Delivery" });
    //            items.Add(new Industry { IndustryID = 109, Name = "Packaging and Containers" });
    //            items.Add(new Industry { IndustryID = 110, Name = "Paper  Forest Products" });
    //            items.Add(new Industry { IndustryID = 111, Name = "Performing Arts" });
    //            items.Add(new Industry { IndustryID = 112, Name = "Pharmaceuticals" });
    //            items.Add(new Industry { IndustryID = 113, Name = "Philanthropy" });
    //            items.Add(new Industry { IndustryID = 114, Name = "Photography" });
    //            items.Add(new Industry { IndustryID = 115, Name = "Plastics" });
    //            items.Add(new Industry { IndustryID = 116, Name = "Political Organization" });
    //            items.Add(new Industry { IndustryID = 117, Name = "Primary/Secondary Education" });
    //            items.Add(new Industry { IndustryID = 118, Name = "Printing" });
    //            items.Add(new Industry { IndustryID = 119, Name = "Professional Training  Coaching" });
    //            items.Add(new Industry { IndustryID = 120, Name = "Program Development" });
    //            items.Add(new Industry { IndustryID = 121, Name = "Public Policy" });
    //            items.Add(new Industry { IndustryID = 122, Name = "Public Relations and Communications" });
    //            items.Add(new Industry { IndustryID = 123, Name = "Public Safety" });
    //            items.Add(new Industry { IndustryID = 124, Name = "Publishing" });
    //            items.Add(new Industry { IndustryID = 125, Name = "Railroad Manufacture" });
    //            items.Add(new Industry { IndustryID = 126, Name = "Ranching" });
    //            items.Add(new Industry { IndustryID = 127, Name = "Real Estate" });
    //            items.Add(new Industry { IndustryID = 128, Name = "Recreational Facilities and Services" });
    //            items.Add(new Industry { IndustryID = 129, Name = "Religious Institutions" });
    //            items.Add(new Industry { IndustryID = 130, Name = "Renewables  Environment" });
    //            items.Add(new Industry { IndustryID = 131, Name = "Research" });
    //            items.Add(new Industry { IndustryID = 132, Name = "Restaurants" });
    //            items.Add(new Industry { IndustryID = 133, Name = "Retail" });
    //            items.Add(new Industry { IndustryID = 134, Name = "Security and Investigations" });
    //            items.Add(new Industry { IndustryID = 135, Name = "Semiconductors" });
    //            items.Add(new Industry { IndustryID = 136, Name = "Shipbuilding" });
    //            items.Add(new Industry { IndustryID = 137, Name = "Sporting Goods" });
    //            items.Add(new Industry { IndustryID = 138, Name = "Sports" });
    //            items.Add(new Industry { IndustryID = 139, Name = "Staffing and Recruiting" });
    //            items.Add(new Industry { IndustryID = 140, Name = "Supermarkets" });
    //            items.Add(new Industry { IndustryID = 141, Name = "Telecommunications" });
    //            items.Add(new Industry { IndustryID = 142, Name = "Textiles" });
    //            items.Add(new Industry { IndustryID = 143, Name = "Think Tanks" });
    //            items.Add(new Industry { IndustryID = 144, Name = "Tobacco" });
    //            items.Add(new Industry { IndustryID = 145, Name = "Translation and Localization" });
    //            items.Add(new Industry { IndustryID = 146, Name = "Transportation/Trucking/Railroad" });
    //            items.Add(new Industry { IndustryID = 147, Name = "Utilities" });
    //            items.Add(new Industry { IndustryID = 148, Name = "Venture Capital  Private Equity" });
    //            items.Add(new Industry { IndustryID = 149, Name = "Veterinary" });
    //            items.Add(new Industry { IndustryID = 150, Name = "Warehousing" });
    //            items.Add(new Industry { IndustryID = 151, Name = "Wholesale" });
    //            items.Add(new Industry { IndustryID = 152, Name = "Wine and Spirits" });
    //            items.Add(new Industry { IndustryID = 153, Name = "Wireless" });
    //            items.Add(new Industry { IndustryID = 154, Name = "Writing and Editing" });
                
    //            return items;
    //        }
    //    }
















}































