using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElencoDelNucleoFamigliare.Controllers
{
    public class FamilyMembersController : Controller
    {
        // GET: FamilyMembersController
        public ActionResult GetMembers()
        {
            return View();
        }

        // GET: FamilyMembersController/GetMemberDetails/5
        public ActionResult GetMemberDetails(int id)
        {
            return View();
        }

        // GET: FamilyMembersController/CreateMember
        public ActionResult CreateMember()
        {
            return View();
        }

        // POST: FamilyMembersController/CreateMember
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMember(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetMembers));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilyMembersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FamilyMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetMembers));
            }
            catch
            {
                return View();
            }
        }

        // GET: FamilyMembersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FamilyMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(GetMembers));
            }
            catch
            {
                return View();
            }
        }
    }
}
