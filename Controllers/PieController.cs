using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers;

public class PieController : Controller
{
    // GET
    private readonly IPieRepository _pieRepository;
    private readonly ICategoryRepository _categoryRepository;

    public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
    {
        _pieRepository = pieRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult List()
    {
        // ViewBag.CurrentCategory = "Cheese cakes";
        // return View(_pieRepository.AllPies);
        PieListViewModel piesListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cake");
        return View(piesListViewModel);
    }
}