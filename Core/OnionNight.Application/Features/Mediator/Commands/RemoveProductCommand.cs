using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.Mediator.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public int ProductId { get; set; }
        public RemoveProductCommand(int productId)
        {
            ProductId = productId;
        }
    }
}
