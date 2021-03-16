using NgoVanChien_5951071004.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NgoVanChien_5951071004.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var studentInfList = new List<StudentInfo>();
            for (int i = 0; i < 10; i++)
            {
                var studentInfo = new StudentInfo
                {
                    MSSV = $"{5951071004 + i}",
                    Hoten = "Ngo Van Chien",
                    Ngaysinh = DateTime.Parse("2000/03/11"),
                    Lop = "CNTTK59"
                };
                studentInfList.Add(studentInfo);
            }
            return studentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                MSSV = $"{id}",
                Hoten = "Ngo Van Chien",
                Ngaysinh = DateTime.Parse("2000/03/11"),
                 Lop = "CNTTK59"
            };
        }

    }
}
