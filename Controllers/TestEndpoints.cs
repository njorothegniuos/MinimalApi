﻿using Carter;

namespace MinimalApi.Controllers
{
    public class TestEndpoints : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/test");

            group.MapGet("", Process);
        }

        public static async Task<IResult> Process(CancellationToken cancellationToken)
        {
            return Results.Ok("Request received!");
        }
    }
}
