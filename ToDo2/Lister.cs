using System;
using System.Collections.Generic;

namespace ToDoList3.ToDo2;

public partial class Lister //Tutaj są przedstawione nasze zmienne w bazie danych.
{
    public int ID { get; set; }

    public string Name { get; set; }

    public DateTime Deadline { get; set; }
}
