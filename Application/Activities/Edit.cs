using System;
using System.Collections.Generic;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Persistence;
using System.Diagnostics.CodeAnalysis;
using AutoMapper;

namespace Application.Activities
{
    public class Edit
    {
        public class Command :IRequest
        {
            public Activity Activity {get; set;}

        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context ;
            private readonly IMapper _mapper;

            public Handler(DataContext context , IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
               var activity = await _context.Activities.FindAsync(request.Activity.Id);

              _mapper.Map(request.Activity,activity);

               await _context.SaveChangesAsync();

            }
        }
    }
}