/****** Object:  Table [dbo].[OrganizationPositionCompetency]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationPositionCompetency]
GO
/****** Object:  Table [dbo].[OrganizationPositionSalaryStaffingRate]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationPositionSalaryStaffingRate]
GO
/****** Object:  Table [dbo].[OrganizationWorkforcePlanDetail]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationWorkforcePlanDetail]
GO
/****** Object:  Table [dbo].[OrganizationPosition]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationPosition]
GO
/****** Object:  Table [dbo].[OrganizationDepartment]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationDepartment]
GO
/****** Object:  Table [dbo].[OrganizationDocument]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationDocument]
GO
/****** Object:  Table [dbo].[OrganizationBusinessDivision]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationBusinessDivision]
GO
/****** Object:  Table [dbo].[OrganizationDocumentFolder]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationDocumentFolder]
GO
/****** Object:  Table [dbo].[OrganizationNote]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationNote]
GO
/****** Object:  Table [dbo].[OrganizationProject]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationProject]
GO
/****** Object:  Table [dbo].[OrganizationWorkforcePlan]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[OrganizationWorkforcePlan]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 06/12/2012 09:40:08 ******/
DELETE FROM [dbo].[Organization]
GO
/****** Object:  Table [dbo].[Organization]    Script Date: 06/12/2012 09:40:08 ******/
SET IDENTITY_INSERT [dbo].[Organization] ON
INSERT [dbo].[Organization] ([OrganizationID], [ParentOrganizationID], [Name], [LegalBusinessName], [OrganizationCodeNumber], [OrganizationCategoryID], [AboutTheOrganization], [WebAddress], [Logo], [OrgChartSequenceNumber]) VALUES (1, NULL, N'Software Grid', N'Software', N'00001', 1, N'this is the parent organization ', N'www.softwaregird.com', NULL, 1)
SET IDENTITY_INSERT [dbo].[Organization] OFF
/****** Object:  Table [dbo].[OrganizationWorkforcePlan]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationProject]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationNote]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationDocumentFolder]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationBusinessDivision]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationDocument]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationDepartment]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationPosition]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationWorkforcePlanDetail]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationPositionSalaryStaffingRate]    Script Date: 06/12/2012 09:40:08 ******/
/****** Object:  Table [dbo].[OrganizationPositionCompetency]    Script Date: 06/12/2012 09:40:08 ******/
