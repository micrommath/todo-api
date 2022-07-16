﻿using Todo.Application.Commands;
using Todo.Application.ViewModels;

namespace Todo.Application.Mappings
{
    public static class TodoMapper
    {
        public static Domain.Entities.Todo ToDomain(this AddTodoCommand command)
        {
            if (command == null)
                return null;

            return new Domain.Entities.Todo(command.Title,
                command.Description,
                command.Status,
                command.Tags);
        }

        public static TodoViewModel ToViewModel(this Domain.Entities.Todo todo)
        {
            if (todo == null)
                return null;

            return new TodoViewModel
            {
                Id = todo.Id,
                Title = todo.Title,
                Description = todo.Description,
                Status = todo.Status,
                Tags = todo.Tags,
                CreatedAt = todo.CreatedAt,
                ModifiedAt = todo.ModifiedAt
            };
        }
    }
}