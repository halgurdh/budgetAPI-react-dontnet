﻿using BudgetApi.Data;

namespace BudgetApi.Services
{
    public class TotalService
    {
        public void TotalBuilder(WebApplication app)
        {
            app.MapGet("/getAllTotal", async () => await TotalRepository.GetTotalAsync())
            .WithTags("Total EndPoints");

            app.MapGet("/getTotalById/{totalId}", async (int totalId) =>
            {
                Total totalToReturn = await TotalRepository.GetTotalById(totalId);

                if (totalToReturn != null)
                {
                    return Results.Ok(totalToReturn);
                }
                else
                {
                    return Results.BadRequest();
                }

            }).WithTags("Total EndPoints");

            app.MapPost("/createTotal", async (Total totalToCreate) =>
            {
                bool createSuccessful = await TotalRepository.CreateTotalAsync(totalToCreate);

                if (createSuccessful)
                {
                    return Results.Ok("Create Successful");
                }
                else
                {
                    return Results.BadRequest();
                }

            }).WithTags("Total EndPoints");


            app.MapDelete("/deleteTotalById/{totalId}", async (int totalId) =>
            {
                bool deleteSuccessful = await TotalRepository.DeleteTotalAsync(totalId);

                if (deleteSuccessful)
                {
                    return Results.Ok("Delete Successful");
                }
                else
                {
                    return Results.BadRequest();
                }

            }).WithTags("Total EndPoints");
        }
    }
}
