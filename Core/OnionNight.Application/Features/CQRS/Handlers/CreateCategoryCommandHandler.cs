using OnionNight.Application.Features.CQRS.Commands;
using OnionNight.Domain.Entities;
using OnionNight.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.CQRS.Handlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly OnionContext _context;
        public CreateCategoryCommandHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category()
            {
                CategoryName = command.CategoryName
            });
            await _context.SaveChangesAsync();
        }
    }
}