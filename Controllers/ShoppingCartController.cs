using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers;

public class ShoppingCartController : Controller
{
    private readonly IPieRepository _pieRepository;

    private readonly IShoppingCart _shoppingCart;
    // GET
    public ShoppingCartController(IPieRepository pieRepository, IShoppingCart shoppingCart)
    {
        _pieRepository = pieRepository;
        _shoppingCart = shoppingCart;
    }
}