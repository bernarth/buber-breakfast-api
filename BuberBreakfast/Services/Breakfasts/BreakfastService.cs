namespace BuberBreakfast.Services.Breakfasts;

using BuberBreakfast.Models;
using BuberBreakfast.ServiceErrors;
using ErrorOr;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid, Breakfast> breakfasts = new();

    public ErrorOr<Created> CreateBreakfast(Breakfast breakfast)
    {
        breakfasts.Add(breakfast.Id, breakfast);

        return Result.Created;
    }

    public ErrorOr<Breakfast> GetBreakfast(Guid id)
    {
        if (breakfasts.TryGetValue(id, out var breakfast))
        {
            return breakfast;
        }

        return Errors.Breakfast.NotFound;
    }

    public ErrorOr<Deleted> DeleteBreakfast(Guid id)
    {
        breakfasts.Remove(id);

        return Result.Deleted;
    }

    public ErrorOr<UpsertedBreakfast> UpserBreakfast(Breakfast breakfast)
    {
        var isNewlyCreated = !breakfasts.ContainsKey(breakfast.Id);
        breakfasts[breakfast.Id] = breakfast;

        return new UpsertedBreakfast(isNewlyCreated);
    }
}