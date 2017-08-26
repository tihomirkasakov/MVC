using System;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    [ValidateInput(false)]
    public class TaskController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.ToList();
                return View(task);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Task task)
        {
            if (ModelState.IsValid)
            {
                using(var db=new TeisterMaskDbContext())
                {
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using(var db= new TeisterMaskDbContext())
            {
                var task = db.Tasks.Find(id);
                if (task==null)
                {
                    return RedirectToAction("Index");
                }
                return View(task);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Task taskModel)
        {
            using (var db = new TeisterMaskDbContext())
            {
                var task = db.Tasks.Find(taskModel.Id);
                if (task==null)
                {
                    return RedirectToAction("Index");
                }
                task.Title = taskModel.Title;
                task.Status = taskModel.Status;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}