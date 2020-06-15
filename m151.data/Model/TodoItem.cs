using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace m151.data.Model
{
    public class TodoItem
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}
