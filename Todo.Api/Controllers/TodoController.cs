﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Todo.Domain.Commands;
using Todo.Domain.Entities;
using Todo.Domain.Handlers;
using Todo.Domain.Repositories;

namespace Todo.Api.Controllers
{
    [ApiController]
    [Route("v1/todos")]
    public class TodoController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAll(
            [FromServices] ITodoRepository repository)

        {
            return repository.GetAll("andrebaltieri");
        }

        [Route("done")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAllDone(
            [FromServices] ITodoRepository repository)
        {
            return repository.GetAllDone("andrebaltieri");
        }

        [Route("undone")]
        [HttpGet]
        public IEnumerable<TodoItem> GetAllUndone(
            [FromServices] ITodoRepository repositoy
        )
        {
            return repositoy.GetAllUndone("andrebaltieri");
        }

        [Route("done/today")]
        [HttpGet]

        public IEnumerable<TodoItem> GetDoneForToday(
            [FromServices] ITodoRepository repositoy
        )
        {
            return repositoy.GetByPeriod(
                "andrebaltieri",
                DateTime.Now.Date,
                true
            );
        }

        [Route("undone/today")]
        [HttpGet]

        public IEnumerable<TodoItem> GetInactiveForToday(
            [FromServices] ITodoRepository repositoy)
        {
            return repositoy.GetByPeriod(
                "andrebaltieri",
                DateTime.Now.Date,
                false
            );
        }

        [Route("done/tomorrow")]
        [HttpGet]

        public IEnumerable<TodoItem> GetDoneForTomorrow(
            [FromServices] ITodoRepository repositoy)
        {
            return repositoy.GetByPeriod(
                "andrebaltieri",
                DateTime.Now.Date.AddDays(1),
                true
            );
        }

        [Route("undone/tomorrow")]
        [HttpGet]

        public IEnumerable<TodoItem> GetUndoneForTomorrow(
            [FromServices] ITodoRepository repositoy)
        {
            return repositoy.GetByPeriod(
                "andrebaltieri",
                DateTime.Now.Date.AddDays(1),
                false
            );
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler)
        {
            command.User = "andrebaltieri";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
            [FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler)
        {
            command.User = "andrebaltieri";
            return(GenericCommandResult)handler.Handle(command);
        }

        [Route("mark-as-done")]
        [HttpPut]
        public GenericCommandResult MarkAsDone(
            [FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler)
        {
            command.User = "andrebaltieri";
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("mark-as-undone")]
        [HttpPut]
        public GenericCommandResult MarkAsUndone(
            [FromBody] CreateTodoCommand command,
            [FromServices] TodoHandler handler)
        {
            command.User = "andrebaltieri";
            return (GenericCommandResult)handler.Handle(command);
        }
    }
}
