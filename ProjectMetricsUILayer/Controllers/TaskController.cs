using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Helpers;
using Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Models;
using Cognizant.Tools.ProjectMetrics.DataLayer.PM_EDMX;
using Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Filters;

namespace Cognizant.Tools.ProjectMetrics.ProjectMetricsUILayer.Controllers
{
    [CustomAuthorization]
    public class TaskController : Controller
    {
        private PMEntities db = new PMEntities();
        //
        // GET: /Task/

        public ActionResult Index()
        {
            var taskItems = Gateway.GetAllTasks();
            return View(taskItems);
        }

        //
        // GET: /Task/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Task/Create

        public ActionResult Create()
        {
            var taskModel = new TaskModel();
            taskModel.Teams = Gateway.GetAllTeams().AsQueryable<Team>().Select(x =>
                                                            new SelectListItem()
                                                            {
                                                                Text = x.Name,
                                                                Value = x.TeamID.ToString()
                                                            });
            taskModel.TeamMemebrs = Gateway.GetAllTeams().AsQueryable<Team>().Select(x =>
                                                            new SelectListItem()
                                                            {
                                                                Text = x.Name,
                                                                Value = x.TeamID.ToString()
                                                            });
            taskModel.TaskType = Gateway.GetAllTeams().AsQueryable<Team>().Select(x =>
                                                            new SelectListItem()
                                                            {
                                                                Text = x.Name,
                                                                Value = x.TeamID.ToString()
                                                            });
            taskModel.CreationDate = DateTime.Now;
            return View(taskModel);
        }

        //public ActionResult Create()
        //{
        //    ViewBag.EmpID = new SelectList(db.Employees, "EmpID", "Name");
        //    ViewBag.ProcessID = new SelectList(db.Processes, "ProcessID", "Description");
        //    ViewBag.PrjID = new SelectList(db.Projects, "PrjID", "Description");
        //    ViewBag.PrjID = new SelectList(db.Projects, "PrjID", "Description");
        //    ViewBag.ReqID = new SelectList(db.Requirements, "ReqID", "Description");
        //    return View();
        //}
        //
        // POST: /Task/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Task/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Task/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Task/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Task/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
