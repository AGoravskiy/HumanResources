using HumanResources.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.DataAccess
{
    /// <summary>
    /// Represents an application database context.
    /// </summary>
    internal sealed class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        public ApplicationDbContext() : base("DefaultConnection") { }

        /// <summary>
        /// Gets or sets a <see cref="DbSet"/> for <see cref="Employee"/>.
        /// </summary>
        public DbSet<Employee> Employees { get; set; }

        /// <summary>
        /// Gets or sets a <see cref="DbSet"/> for <see cref="Candidate"/>.
        /// </summary>
        public DbSet<Candidate> Candidates { get; set; }
    }
}
