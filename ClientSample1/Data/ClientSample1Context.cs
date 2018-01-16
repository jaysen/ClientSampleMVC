using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClientSample1.Models
{
    public class ClientSample1Context : DbContext
    {
        public ClientSample1Context (DbContextOptions<ClientSample1Context> options)
            : base(options)
        {
        }

        public DbSet<ClientSample1.Models.Client> Client { get; set; }
    }
}
