using CourseSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace CourseSystem.services
{
    interface AdminServices
    {
        bool login(string email , string password);
        bool ChangePassword(string email, string password);
        bool ForgetPassword(string email);
    }
    public class Admin : AdminServices
    {
        public OnlineCoursesSystemDBEntities Context { set; get; }
        public Admin()
        {
            Context = new OnlineCoursesSystemDBEntities(); 
        }
        
        public bool ChangePassword(string email, string password)
        {
            try
            {

            Context.Admins.FirstOrDefault(i => i.Email == email).Password=password;
            return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ForgetPassword(string email)
        {
            throw new NotImplementedException();
        }

        public bool login(string email, string password)
        {
            try
            {
                if (Context.Admins.Find(email) == null)
                    return false;
                var item = Context.Admins.Find(email);
                return (item.Password == password);
            }
            catch { return false; }
        }
    }
}