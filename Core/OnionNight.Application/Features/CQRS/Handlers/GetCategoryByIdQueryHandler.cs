﻿using OnionNight.Application.Features.CQRS.Queries;
using OnionNight.Application.Features.CQRS.Results;
using OnionNight.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.CQRS.Handlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly OnionContext _context;
        public GetCategoryByIdQueryHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _context.Categories.FindAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = values.CategoryId,
                CategoryName = values.CategoryName
            };
        }
    }
}
