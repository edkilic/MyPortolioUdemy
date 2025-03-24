using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContex = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContex.Features.ToList();
            return View(values);
        }
    }
}
    