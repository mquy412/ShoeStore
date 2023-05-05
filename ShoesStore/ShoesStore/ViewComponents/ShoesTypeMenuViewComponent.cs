using Microsoft.AspNetCore.Mvc;
using ShoesStore.Models;

namespace WebN02.ViewComponents
{
    public class ShoesTypeMenuViewComponent : ViewComponent
    {
        ShoeStoreContext db = new ShoeStoreContext();

        public IViewComponentResult Invoke()
        {
            var shoesTypes = db.LoaiGiays.OrderBy(x => x.TenLoai);
            return View(shoesTypes);
        }
    }
}
