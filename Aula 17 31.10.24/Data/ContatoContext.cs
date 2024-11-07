using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_17_31._10._24.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula_17_31._10._24.Data
{
    public class ContatoContext : DbContext
    {
        public ContatoContext (DbContextOptions<ContatoContext> options) : base(options) {
            
        }
        public DbSet<ContatoModel> Contatos {get; set;}
    }
}