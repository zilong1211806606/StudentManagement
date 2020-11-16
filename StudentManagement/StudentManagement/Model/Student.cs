using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Model
{

    /// <summary>
    /// Student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 序号
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 班级名称
        /// </summary>
        public string classname { get; set; }
        /// <summary>
        /// email
        /// </summary>
        public string email { get; set; }
    }
}
