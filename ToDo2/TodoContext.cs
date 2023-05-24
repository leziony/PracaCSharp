using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoList3.ToDo2;

public partial class TodoContext : DbContext //Tutaj konfigurujemy kontekst. Z tego powstanie baza danych jeśli jej nie mamy.
{
    public TodoContext()
    {
    }

    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Lister> Listers { get; set; } //contener bazy Listers

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Połączenie to bazy MySQL.
        => optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=Tester12#;database=todo");

    protected override void OnModelCreating(ModelBuilder modelBuilder) //Model Bazy Danych.
    {
        modelBuilder.Entity<Lister>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PRIMARY"); // ID z kluczem głównym.

            entity.ToTable("lister"); // nazwa tabeli.
            //Właściwości każdej z baz. 
            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Deadline)
                .HasColumnType("date")
                .HasColumnName("Deadline");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("Name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
