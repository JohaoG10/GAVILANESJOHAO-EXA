using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GAVILANESJOHAO_EXAMEN.Models;

    public class GAVILANESJOHAO_EXAContext : DbContext
    {
        public GAVILANESJOHAO_EXAContext (DbContextOptions<GAVILANESJOHAO_EXAContext> options)
            : base(options)
        {
        }

        public DbSet<GAVILANESJOHAO_EXAMEN.Models.EGavilanes> EGavilanes { get; set; } = default!;

public DbSet<GAVILANESJOHAO_EXAMEN.Models.Celular> Celular { get; set; } = default!;
    }
