using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StudentRegistration
{
    public class StudentData
    {
        public static DataTable newValues { get; set; }
        public static DataTable oldValues { get; set; }
        public static Int64 nextId { get; set; }
    }
}
