using CollegeDBEF.DAL;
using System.Linq;
using System.Web.Http;

namespace Students.API.Controllers
{
    public class StudentAPIController : ApiController
    {
        public string Get(int id)
        {
            string fullName = "";

            using (var context = new CollegeContext())
            {
                var student = context.Students.Single(a => a.ID == id);
                fullName = student.FName + " " + student.LName;
            }

            return fullName;
        }
    }
}
