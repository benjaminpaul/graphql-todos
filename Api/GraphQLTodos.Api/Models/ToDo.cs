using System;
using System.ComponentModel.DataAnnotations;

namespace GraphQLTodos.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public bool IsDone { get; set; }

        public int TodoGroupId { get; set; }
    }
}