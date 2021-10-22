using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQLTodos.Models
{
    public class TodoGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}