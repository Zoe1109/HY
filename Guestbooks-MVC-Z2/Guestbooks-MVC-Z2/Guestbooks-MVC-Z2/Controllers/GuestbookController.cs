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
    }
}