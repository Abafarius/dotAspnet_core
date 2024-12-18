using FirstApp.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace FirstApp
{
    public class CommandFruit : ICommand
    {
        public IResult GetById(int id)
        {
            var result = Data.all.TryGetValue(id, out var results);

            if (result)
            {
                return TypedResults.Ok(results);
            }
            return Results.Problem(statusCode: 404);
        }
        public IResult CreateFruit(int id, Fruit fruit)
        {
            return Data.all.TryAdd(id, fruit)
               ? TypedResults.Created("fruit/{id}", fruit)
               : Results.ValidationProblem(new Dictionary<string, string[]>
               {
                    {"id", new[] {"A fruit with this id was created!"} }
               });
        }

        public static void UpdateFruit(int id, Fruit fruit)
        {
            Data.all[id] = fruit;   
        }

        public IResult DeleteFruit(int id)
        {
            Data.all.Remove(id);
            return Results.NoContent();
        }
    }
}
