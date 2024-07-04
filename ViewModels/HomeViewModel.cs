using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.ViewModels;

public class HomeViewModel
{
    public IEnumerable<Pie> PiesOfTheWeek { get; }

    public HomeViewModel(IEnumerable<Pie> piesOfTheWeek)
    {
        PiesOfTheWeek = piesOfTheWeek;
    }
}