using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Contexts;
using EntityLayer.Concrete;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAnnouncementsDal : GenericRepository<Announcement>, IAnnouncementsDal
    {
        public void AnnouncementChangeStatus(int id)
        {
            using var context = new AgricultureContext();
            Announcement p = context.Announcements.Find(id);
            if(p.Status == true)
            {
                p.Status = false;
            } else
            {
                p.Status = true;
            }
            context.SaveChanges();
        }
    }
}
