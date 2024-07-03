using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models;

public class PieRepository: IPieRepository
{
    private readonly BethanysPieShopDbContext _BethanysPieShopDbContext;

    public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        _BethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    public IEnumerable<Pie> AllPies
    {
        get
        {
            return _BethanysPieShopDbContext.Pies.Include(c => c.Category);
        }
        
    }

    public IEnumerable<Pie> PiesOfTheWeek
    {
        get
        {
            return _BethanysPieShopDbContext.Pies.Include(c => c.Category).Where(p => p.IsPieOfTheWeek);
        } 
        
    }

    public Pie? GetPieById(int pieId)
    {
        return _BethanysPieShopDbContext.Pies.FirstOrDefault(p => p.PieId == pieId); 
    }
    
}