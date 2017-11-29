using Guestbooks_MVC_Z2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guestbooks_MVC_Z2.Service
{
    public class GuestbooksDBService
    {
        //宣告資料庫實體模型物件
        MyGuestbookEntities db = new MyGuestbookEntities();

        //取得陣列資料方法
        public List<Guestbooks> GetDataList()
        {
            //回傳全部資料
            return db.Guestbooks.ToList();            
        }
    }

   
}