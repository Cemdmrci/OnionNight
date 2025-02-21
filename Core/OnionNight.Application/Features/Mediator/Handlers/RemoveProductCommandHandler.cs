using MediatR;
using OnionNight.Application.Features.Mediator.Commands;
using OnionNight.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.Mediator.Handlers
{
    public class RemoveProductCommandHandler : IRequest<RemoveProductCommand>
    {
        private readonly OnionContext _context;

        public RemoveProductCommandHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ProductId);
            _context.Products.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
