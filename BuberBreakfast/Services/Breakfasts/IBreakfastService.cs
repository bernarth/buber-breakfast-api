namespace BuberBreakfast.Services.Breakfasts;

using BuberBreakfast.Models;
using ErrorOr;

public interface IBreakfastService
{
    ErrorOr<Created> CreateBreakfast(Breakfast breakfast);

    ErrorOr<Breakfast> GetBreakfast(Guid id);

    ErrorOr<Deleted> DeleteBreakfast(Guid id);

    ErrorOr<UpsertedBreakfast> UpserBreakfast(Breakfast breakfast);
}