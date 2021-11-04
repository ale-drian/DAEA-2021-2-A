using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace SchoolEntities
{
    public class CPerson
    {
        public int PersonID { get; set; }
        public string LastName{ get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate{ get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
