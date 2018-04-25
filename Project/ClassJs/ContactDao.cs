using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Models;

namespace Project.ClassJs
{
    public class ContactDao
    {
        ShopOnlineEntities1 db = null;
        public ContactDao()
        {
            db = new ShopOnlineEntities1();
        }

        public Contact GetActiveContact()
        {
            return db.Contacts.Single(x => x.status == true); 
        }
        
        public int InsertFeedBack(Feedback fb)
        {
            db.Feedbacks.Add(fb);
            db.SaveChanges();
            return fb.id;
        }
    }
}