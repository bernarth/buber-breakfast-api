namespace BuberBreakfast.Services.Breakfasts;

using BuberBreakfast.Models;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> breakfasts = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        // TODO: here we use a repository to store the data
        breakfasts.Add(breakfast.Id, breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return breakfasts[id];
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