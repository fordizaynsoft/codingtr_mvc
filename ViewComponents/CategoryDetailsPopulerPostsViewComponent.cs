using codingtr.Data.Abstract;
using codingtr.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace codingtr.ViewComponents
{
    public class CategoryDetailsPopulerPostsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
