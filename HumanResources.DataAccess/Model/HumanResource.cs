using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess.Model
{
    /// <summary>
    ///  Represents a human resource. 
    /// </summary>
    public class HumanResource : BaseModel
    {
        /// <summary>
        /// Gets or sets a human resource name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a human resource position.
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Gets or sets a date of birth of human resource.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets a human resource email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a human resource phone number.
        /// </summary>
        public string Phone { get; set; }
    }
}
