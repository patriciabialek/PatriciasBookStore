using PatriciasBooks.DataAccess.Repository.IRepository;
using PatriciasBooks.DataAccess.Repository;
using PatriciasBooks.Models;
using PatriciasBooks.Utility; /*new part 4*/
using Dapper; /*new part 4*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatriciasBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id) //action method for upsert
        {
            CoverType covertype = new CoverType();
            if (id == null)
            {
                //this is for create
                return View(covertype);
            }
            //this is ffor the edit
            //covertype = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            var parameter = new DynamicParameters();
            parameter.Add("@Id", id);
            covertype = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);
            if (covertype == null)
            {
                return NotFound();
            }
            return View(covertype);
        }

        //use HTTP POST to define the post-action method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid) //checks all validation in the model to increase security
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Name", covertype.Name);

                if (covertype.Id == 0)
                {
                    //_unitOfWork.CoverType.Add(covertype);
                    //_unitOfWork.Save();
                    _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Create, parameter);
                }
                else
                {
                    //_unitOfWork.CoverType.Update(covertype);
                    parameter.Add("@Id", covertype.Id);
                    _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Update, parameter);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index)); //to see all the categories
            }
            return View(covertype);

            //API calls here
            #region API CALLS
            [HttpGet]
            public IActionResult GetAll()
            {
                //return not found
                //var allObj = _unitOfWork.CoverType.GetAll();
                var allObj = _unitOfWork.SP_Call.List<CoverType>(SD.Proc_CoverType_GetAll, null);
                return Json(new { data = allObj });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                //var objFromDb = _unitOfWork.CoverType.Get(id);
                var parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                var objFromDb = _unitOfWork.SP_Call.OneRecord<CoverType>(SD.Proc_CoverType_Get, parameter);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting" });
                }
                //_unitOfWork.CoverType.Remove(objFromDb);
                _unitOfWork.SP_Call.Execute(SD.Proc_CoverType_Delete, parameter);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete successful" });
            }
            #endregion
        }
    }
}
