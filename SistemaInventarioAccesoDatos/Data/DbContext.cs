using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaInventarioAccesoDatos.Data
{
    public class DbContext: IdentityDbContext
    {
        public DbContext(DbContextOptions<DbContext> options)
           : base(options)
        {
        }
    }
}
