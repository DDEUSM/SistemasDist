using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Exercicio.Models;

namespace Exercicio.Data
{
    public class ExercicioContext : DbContext
    {
        public ExercicioContext (DbContextOptions<ExercicioContext> options)
            : base(options)
        {
        }

        public DbSet<Exercicio.Models.UserModel> UserModel { get; set; } = default!;
    }
}
