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
    public class PositionsController : Controller
    {
		private readonly IDepartmentRepository departmentRepository;
		private readonly IPositionRepository positionRepository;
        public PositionsController(IDepartmentRepository departmentRepository, IPositionRepository positionRepository)
        {
			this.departmentRepository = departmentRepository;
			this.positionRepository = positionRepository;
        }

        //
        // GET: /Positions/
		[UserAuthorize]
        public ViewResult Index()
        {
						            return View(positionRepository.AllIncluding(position => position.Department));
        }
		
		public ViewResult Search(Position searchPosition)
        {
			if(searchPosition!=null)
			{
							}
						return View("Index",positionRepository.AllIncluding(position => position.Department));
		}

        //
        // GET: /Positions/Details/5
		[UserAuthorize]
        public ViewResult Details(int id)
        {
            return View(positionRepository.Find(id));
        }

        //
        // GET: /Positions/Create
		[UserAuthorize]
        public ActionResult Create()
        {
			Position position = new Position();
			ViewBag.PossibleDepartments = departmentRepository.All;
            return View(position);
        } 

        //
        // POST: /Positions/Create
        [HttpPost]
        public ActionResult Create(Position position)
        {
            if (ModelState.IsValid) {
                positionRepository.InsertOrUpdate(position);
                positionRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleDepartments = departmentRepository.All;
				return View(position);
			}
        }
        
        //
        // GET: /Positions/Edit/5
		[UserAuthorize]
        public ActionResult Edit(int id)
        {
			ViewBag.PossibleDepartments = departmentRepository.All;
             return View(positionRepository.Find(id));
        }

        //
        // POST: /Positions/Edit/5
        [HttpPost]
        public ActionResult Edit(Position position)
        {
            if (ModelState.IsValid) {
                positionRepository.InsertOrUpdate(position);
                positionRepository.Save();
                return RedirectToAction("Index");
            } else {
				ViewBag.PossibleDepartments = departmentRepository.All;
				return View(position);
			}
        }

        //
        // GET: /Positions/Delete/5
		[UserAuthorize]
        public ActionResult Delete(int id)
        {
            return View(positionRepository.Find(id));
        }

        //
        // POST: /Positions/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            positionRepository.Delete(id);
            positionRepository.Save();

            return RedirectToAction("Index");
        }
    }
}

