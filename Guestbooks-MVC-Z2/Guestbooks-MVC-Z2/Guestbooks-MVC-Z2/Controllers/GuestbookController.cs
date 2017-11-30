using Guestbooks_MVC_Z2.Models;
using Guestbooks_MVC_Z2.Service;
using Guestbooks_MVC_Z2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Guestbooks_MVC_Z2.Controllers
{
    public class GuestbookController : Controller
    {
        //宣告Guestbooks 資料表的Service物件
        GuestbooksDBService guestbookservice = new GuestbooksDBService();


        // GET: Guestbook
        public ActionResult Index()
        {
            //宣告一個新頁面模型
            GuestbookView Data = new GuestbookView();

            //從Service 中取得頁面所需陣列資料
            Data.DataList = guestbookservice.GetDataList();

            //將頁面資料傳入View中
            return View(Data);
        }

        #region

        //新增留言一開始載入畫面
        public ActionResult Create()
        {
            //因此頁面用於載入至開始頁面中
            //故使用部分檢視回傳
            return PartialView();
            
        }

        //新增留言傳入資料時的Action
        [HttpPost]
        //使用Bind的Include來定義只接受的欄位,用來避免傳入其他不相干的值
        public ActionResult Add ([Bind(Include ="Name,Content")]Guestbooks Data)
        {
            //使用Service來新增一筆資料
            guestbookservice.InsertGuestbooks(Data);

            //重新導向頁面至開始頁面
            return RedirectToAction("Index");
        }


        #endregion



    }
}