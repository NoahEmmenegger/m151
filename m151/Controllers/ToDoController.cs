using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ch.gibz.m151.demo.api.Model;
using Microsoft.AspNetCore.Mvc;

namespace ch.gibz.m151.demo.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private M151DemoContext _context;

        public ToDoController(M151DemoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return _context.TodoItem;
        }

        [HttpGet("{id}")]
        public TodoItem GetSingleItem(Guid id)
        {
            return _context.TodoItem.FirstOrDefault(t => t.Id == id);
        }

        [HttpPost]
        public Guid Post([FromBody]TodoItem newTodoItem)
        {
            if (newTodoItem.Id == Guid.Empty)
            {
                newTodoItem.Id = Guid.NewGuid();
            }
            _context.TodoItem.Add(newTodoItem);
            _context.SaveChanges();

            return newTodoItem.Id;
        }

        [HttpPut("{id}")]
        public TodoItem Put(Guid id, [FromBody]TodoItem updateTodoItem)
        {
            var existingItem = GetSingleItem(id);

            existingItem.Name = updateTodoItem.Name;
            existingItem.IsComplete = updateTodoItem.IsComplete;

            _context.SaveChanges();

            return existingItem;
        }

    }
}
