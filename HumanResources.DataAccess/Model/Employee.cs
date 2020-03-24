using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Model
{
    /// <summary>
    /// Represents an employee.
    /// </summary>
    public class Employee : HumanResource
    {
        /// <summary>
        /// Gets or sets a human resource phone number.
        /// </summary>
        public DateTime StartDate { get; set; }
    }
}
