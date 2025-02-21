using MediatR;
using Microsoft.EntityFrameworkCore;
using OnionNight.Application.Features.Mediator.Queries;
using OnionNight.Application.Features.Mediator.Results;
using OnionNight.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.Mediator.Handlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly OnionContext _context;

        public GetProductQueryHandler(OnionContext context)
        {
            _context = context;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.ToListAsync();
            return values.Select(x => new GetProductQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock

            }).ToList();
        }
    }
}
