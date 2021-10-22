using System.Linq;
using GraphQLTodos.Models;
using GraphQLTodos.Data;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQLTodos.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        public IQueryable<Todo> GetTodos([ScopedService] AppDbContext context)
        {
            return context.Todos;
        }

        [UseDbContext(typeof(AppDbContext))]
        [UseProjection]
        [UseFiltering]
        public IQueryable<TodoGroup> GetTodoGroups([ScopedService] AppDbContext context)
        {
            return context.TodoGroups;
        }
    }
}