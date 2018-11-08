using System;
using Microsoft.EntityFrameworkCore;

namespace NanaDoor.Models
{
    public class NanaDoorContext : DbContext
    {
        public NanaDoorContext(DbContextOptions<NanaDoorContext> options) : base(options) { }
    }
}