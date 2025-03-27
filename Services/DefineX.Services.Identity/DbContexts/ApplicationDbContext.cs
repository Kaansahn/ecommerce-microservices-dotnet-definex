using System;
using Microsoft.EntityFrameworkCore;

namespace DefineX.Services.Identity.DbContexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
}
