//*********************************************************
//
//    Copyright (c) SoftwareGrid LLC. All rights reserved.
//	  Contact: Faisal Alam, sal@softwaregrid.com
//	  http://www.softwaregrid.com
//
//*********************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoftwareGrid.DataLogic.Models;
using SoftwareGrid.BusinessLogic.Repositories;
using SoftwareGrid.BusinessLogic.Helpers;
namespace SoftwareGrid.Areas.MasterData.Controllers
{   
    public class DepartmentsController : Controller
    {
		private readonly IBusinessDivisionRepository businessdivisionRepository;
		private readonly IDepartmentRepository departmentRepository;
        public DepartmentsController(IBusinessDivisionRepository businessdivisionRepository, IDepartmentRepository departmentRepository)
        {
			this.businessdivisionRepository = businessdivisionRepository;
			this.departmentRepository = departmentRepository;
        }

        //
        // GET: /Departments/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(departmentRepository.AllIncluding(department => department.BusinessDivision));
        }
		
		public ViewResult Search(Department searchDepartment)
        {
			if(searchDepartment!=null)
			{
							}
						return View("Index",departmentRepository.AllIncluding(department => department.BusinessDivision));
		}

        //
        // GET: /Departments/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(departmentRepository.Find(id));
        }

        //
        // GET: /Departments/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Department department = new Department();
			ViewBag.PossibleBusinessDivisions = businessdivisionRepository.All;
            return View(department);
        } 

        //
        // POST: /Departments/Create
        [HttpPost]
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid) {
                departmentRepository.InsertOrUpdate(department);
                departmentRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleBusinessDivisions = businessdivisionRepository.All;
				return View(department);
			}
        }
        
        //
        // GET: /Departments/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleBusinessDivisions = businessdivisionRepository.All;
             return View(departmentRepository.Find(id));
        }

        //
        // POST: /Departments/Edit/5
        [HttpPost]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid) {
                departmentRepository.InsertOrUpdate(department);
                departmentRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleBusinessDivisions = businessdivisionRepository.All;
				return View(department);
			}
        }

        //
        // GET: /Departments/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(departmentRepository.Find(id));
        }

        //
        // POST: /Departments/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            departmentRepository.Delete(id);
            departmentRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

