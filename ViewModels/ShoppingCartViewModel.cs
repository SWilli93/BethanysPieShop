using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels;

public class ShoppingCartViewModel
{
    public ShoppingCartViewModel(IShoppingCart shoppingCart, double shoppingCartTotal)
    {
        ShoppingCart = shoppingCart;
        ShoppingCartTotal = shoppingCartTotal;
    }
    
    public IShoppingCart ShoppingCart { get; }
    public double ShoppingCartTotal { get; }
}