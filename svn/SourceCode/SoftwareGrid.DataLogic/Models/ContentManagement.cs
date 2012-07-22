

//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System;
using System.ComponentModel.DataAnnotations;
using SoftwareGrid.DataLogic.Attributes;

namespace SoftwareGrid.DataLogic.Models
{
    #region Web Site Builder, Photo & Video Library, Theme and layout Manager

    public class CmsContentEditor
    {
        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CmsContentEditorID { get; set; }
        
        [Display(Name = "Page Title")]
        [StringLength(64)]
        public String PageTitle { get; set; }


        [Display(Name = "Page Header Title")]
        [StringLength(128)]
        public String PageHeaderTitle { get; set; }
       
        [Display(Name = "Content")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String PageContent { get; set; }

        [Display(Name = "SEO Meta Tags")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String SeoMetaTags { get; set; }

        [ForeignKey("CmsImage")]      
        [Display(Name = "Image")]
        public Int32? CmsImageID { get; set; }
       //list

        [ForeignKey("CmsVideo")]
        [Display(Name = "Video")]
        public Int32? CmsVideoID { get; set; }
        //list


        [Display(Name = "Content Author Internal Remarks")]
        [StringLength(512)]
        public String ContentInternalRemarks { get; set; }
 

        [Display(Name = "Written By")]
        [ForeignKey("WrittenByUser")]
        public Int32 WrittenByUserID { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
       
    
        [Display(Name = "Last Update Date")]
        [DataType(DataType.Date)]
        public DateTime LastUpdateDate { get; set; }

        
        [Display(Name = "Is Content Verified")]
        [DataType ("Verified")]
        public Boolean IsVerified { get; set; }
        
        [Display(Name = "Verified By")]
        [ForeignKey("VerifiedByUser")]
        public Int32? VerifiedByUserID { get; set; }

        [Display(Name = "Verification Date")]
        [DataType(DataType.Date)]
        public DateTime? VerificationDate { get; set; }

        [Display(Name = "Is Published")]
        public Boolean IsPublished { get; set; }
       

        public virtual User WrittenByUser { get; set; }
        public virtual User VerifiedByUser { get; set; }
        public virtual CmsVideo CmsVideo { get; set; }
        public virtual CmsImage CmsImage { get; set; }
       
    }
    public class WebContentViewer
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ApplicantProfileViewerID { get; set; }

        [Required]
        [ForeignKey("CmsContentEditor")]
        public Int32 CmsContentEditorID { get; set; }

        [Required(ErrorMessage = "User is required")]
        [Display(Name = "Viewed By")]
        [ForeignKey("ViewedByUser")]
        public Int32 ViewedByUserID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime ViewDateTime { get; set; }

        public virtual CmsContentEditor CmsContentEditor { get; set; }
        public virtual User ViewedByUser { get; set; }

    }
    public class WebContentComment
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 ApplicantProfileRequestListID { get; set; }

        [Required]
        [ForeignKey("CmsContentEditor")]
        public Int32 CmsContentEditorID { get; set; }

        [Required]
        [ForeignKey("WrittenByUser")]
        [Display(AutoGenerateField = false)]
        public Int32 WrittenByUserID { get; set; }

        [DataType(DataType.DateTime)]
        [Display(AutoGenerateField = false)]
        public DateTime DateTime { get; set; }

        [Required(ErrorMessage = "Notes is required")]
        [Display(Name = "Comments")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String Comments { get; set; }

        public virtual CmsContentEditor CmsContentEditor { get; set; }
        public virtual User WrittenByUser { get; set; }
       

    }

    public class CmsFolder
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CmsFolderID { get; set; }

        [Display(Name = "Parent Folder")]
        [ForeignKey("ParentCmsFolder")]
        public Int32? ParentCmsFolderID { get; set; }


        [Required(ErrorMessage = "Folder Name is required")]
        [Display(Name = "Folder Name")]
        [StringLength(256)]
        public String FolderName { get; set; }



        public virtual CmsFolder ParentCmsFolder { get; set; }



    }
    public class CmsImage
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CmsImageID { get; set; }

       


        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        [StringLength(128)]
        public String ImageTitle { get; set; }

        [Display(Name = "Brief Description")]
        [StringLength(512)]
        public String BriefDescription { get; set; }

        [Display(Name = "SEO Meta Tags")]
        [MaxLength]
        [DataType(DataType.Html)]
        public String SeoMetaTags { get; set; }

        [Display(Name = "Upload File")]
        public Byte[] Image { get; set; }

        [Display(Name = "Original File Name, Extension and Size")]
        [StringLength(256)]
        public String OriginalFileInfo { get; set; }

     }
    public class CmsVideo
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CmsVideoLibraryID { get; set; }

        [Required]
        [ForeignKey("CmsFolder")]
        public Int32 CmsFolderID { get; set; }

        [Display(Name = "Video Title")]
        [StringLength(256)]
        public String VideoTitle { get; set; }

        [Display(Name = "YouTube Video Link or Title")]
        [StringLength(128)]
        public String YouTubeVideoLink { get; set; }

        [Display(Name = "Video Description")]
        [StringLength(512)]
        public String BriefDescription { get; set; }

        [Display(Name = "Upload Video File")]
        public Byte[] VideoFile { get; set; }

        [Display(Name = "Original Video File Info")]
        [StringLength(256)]
        public String OriginalFileInfo { get; set; }

        public virtual CmsFolder CmsFolder  { get; set; }

    }
    
    public class CmsLayout
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CmsLayoutID { get; set; }

        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

    }
    public class CmsTheme
    {

        [Required]
        [Display(AutoGenerateField = false)]
        [Key]
        public Int32 CmsThemeID { get; set; }

        [Display(Name = "Name")]
        [StringLength(64)]
        public String Name { get; set; }

        [Display(Name = "Description")]
        [StringLength(512)]
        public String Description { get; set; }

    }


//facebook like

    //share content



    

   
 #endregion

   

}
 