using MediatR;
using OnionNight.Application.Features.Mediator.Commands;
using OnionNight.Domain.Entities;
using OnionNight.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.Mediator.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly OnionContext _context;

        public CreateProductCommandHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock

            });
            await _context.SaveChangesAsync();
        }
    }
}