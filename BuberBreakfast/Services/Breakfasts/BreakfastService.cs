namespace BuberBreakfast.Services.Breakfasts;

using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> breakfasts = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        // TODO: here we use a repository to store the data
        breakfasts.Add(breakfast.Id, breakfast);
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (breakfasts.TryGetValue(id, out var breakfast))
        {
            return breakfast;
        }

        return Errors.Breakfast.NotFound;
    }

    public void DeleteBreakfast(Guid id)
    {
        breakfasts.Remove(id);
    }

    public void UpserBreakfast(Breakfast breakfast)
    {
        breakfasts[breakfast.Id] = breakfast;
    }
}