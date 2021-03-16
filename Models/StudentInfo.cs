using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NgoVanChien_5951071004.Models
{
    public class StudentInfo
    {
        [DataMember(Name = "mssv")]
        public string MSSV { get; set; }
        [DataMember(Name = "hoten")]
        public string Hoten { get; set; }
        [DataMember(Name = "ngaysinh")]
        public DateTime Ngaysinh{ get; set; }
        [DataMember(Name = "lop")]
        public string Lop { get; set; }
    }
}