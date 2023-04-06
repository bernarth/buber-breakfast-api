namespace BuberBreakfast.Services.Breakfasts;

using BuberBreakfast.Models;
using ErrorOr;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);

    ErrorOr<Breakfast> GetBreakfast(Guid id);

    void DeleteBreakfast(Guid id);

    void UpserBreakfast(Breakfast breakfast);
}