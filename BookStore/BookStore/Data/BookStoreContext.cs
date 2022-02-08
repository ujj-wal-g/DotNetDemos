﻿using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class BookStoreContext:DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext>options):base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
    }
}
