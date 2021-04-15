﻿using Microsoft.EntityFrameworkCore;
using ProvaExLivro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaExLivro.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }
        public DbSet<Livro> Livros { get; set; }
    }
}
