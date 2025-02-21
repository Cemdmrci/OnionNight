using MediatR;
using OnionNight.Application.Features.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.Mediator.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
    {
        public int ProductId { get; set; }
        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
