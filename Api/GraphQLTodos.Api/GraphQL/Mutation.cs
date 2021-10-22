using System.Threading.Tasks;
using GraphQLTodos.Data;
using GraphQLTodos.GraphQL.Todos;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQLTodos.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDbContext))]
        public async Task<CreateTodoPayload> CreateTodoAsync(CreateTodoInput input, [ScopedService] AppDbContext context)
        {
            var todo = new Models.Todo
            {
                Description = input.Description,
                TodoGroupId = input.TodoGroupId,
                CreatedAt = new System.DateTime()
            };

            context.Todos.Add(todo);
            context.SaveChanges();

            return new CreateTodoPayload(todo);
        }

        [UseDbContext(typeof(AppDbContext))]
        public async Task<CreateTodoGroupPayload> CreateTodoGroupAsync(CreateTodoGroupInput input, [ScopedService] AppDbContext context)
        {
            var todoGroup = new Models.TodoGroup
            {
                Description = input.Description
            };

            context.TodoGroups.Add(todoGroup);

            context.SaveChanges();

            return new CreateTodoGroupPayload(todoGroup);
        }
    }
}