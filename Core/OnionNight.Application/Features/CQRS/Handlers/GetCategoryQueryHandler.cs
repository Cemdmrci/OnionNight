﻿using Microsoft.EntityFrameworkCore;
using OnionNight.Application.Features.CQRS.Results;
using OnionNight.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionNight.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly OnionContext _context;
        public GetCategoryQueryHandler(OnionContext context)
        {
            _context = context;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _context.Categories.ToListAsync();
            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            }).ToList();
        }
    }
}
