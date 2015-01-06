﻿using System;

namespace ToDoDemo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public int Priority { get; set; }
    }
}