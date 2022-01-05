﻿using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Tests.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }

        public TodoItem GetbiId(Guid id, string user)
        {
            return new TodoItem("Titulo aqui","Bruno Ferreira",DateTime.Now);
        }

        public void Update(TodoItem todo)
        {
        }
    }
}