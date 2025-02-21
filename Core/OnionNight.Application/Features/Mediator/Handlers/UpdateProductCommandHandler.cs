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
    public class UpdateProductCommandHandler : IRequest<UpdateProductCommand>
    {
        private readonly OnionContext _context;

        public UpdateProductCommandHandler(OnionContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Products.FindAsync(request.ProductId);
            value.ProductName = request.ProductName;
            value.ProductPrice = request.ProductPrice;
            value.ProductStock = request.ProductStock;
            await _context.SaveChangesAsync();
        }

    }
}
