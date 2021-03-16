using OnTopOfIt.Infrastructure;
using OnTopOfIt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using OnTopOfIt.Data;
using OnTopOfIt.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNet.Identity;

namespace OnTopOfIt.Controllers
{
    [Authorize]
    public class TodoController : Controller
    {
     
        private readonly LoginDbContext context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<OnTopOfItUser> _userManager;


        public TodoController(LoginDbContext context, Microsoft.AspNetCore.Identity.UserManager<OnTopOfItUser> userManager)
        {
            //this.context = context;
            //this._userManager = userManager;
            this.context = context;
            this._userManager = userManager;

        }

        //GET ALL LIST
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            //User ID
            OnTopOfItUser user = await _userManager.GetUserAsync(HttpContext.User);

            IQueryable<TodoItems> items = from i in context.TodoItems
                                          where i.OnTopOfItUser.Id == user.Id
                                          orderby i.Id
                                          select i;

            // List<TodoItems> todoItems = await items.ToListAsync();
            List<TodoItems> todoItems1 = await items.ToListAsync();


            return View(todoItems1);

        }

        //CREATE NEW TASK VIEW
        public IActionResult Create()
        {
            return View();
        }

        //CREATE TASK POST 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(TodoItems item)
        {
            var currentUser = await _userManager.FindByIdAsync(User.Identity.GetUserId());
            if (ModelState.IsValid)
            {
                item.OnTopOfItUser = currentUser;
                context.TodoItems.Add(item);
                await context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET /TODO/EDIT/
        public async Task<ActionResult> Edit(int id)
        {
            TodoItems item = await context.TodoItems.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);

        }

        // POST /TODO/EDIT/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(TodoItems item)
        {
            if (ModelState.IsValid)
            {
                context.Update(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been updated!";

                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET /TODO/DELETE/1
        public async Task<ActionResult> Delete(int id)
        {
            TodoItems item = await context.TodoItems.FindAsync(id);
            if (item == null)
            {
                TempData["Error"] = "The item does not exist!";
            }
            else
            {
                context.TodoItems.Remove(item);
                await context.SaveChangesAsync();

                TempData["Success"] = "The item has been deleted successfully!";
            }

            return RedirectToAction("Index");
        }
    }
}
