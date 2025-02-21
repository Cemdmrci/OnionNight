using MediatR;
using OnionNight.Application.Features.Mediator.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.Mediator.Queries
{
    public class GetProductQuery : IRequest<List<GetProductQueryResult>>
    {
    }
}
