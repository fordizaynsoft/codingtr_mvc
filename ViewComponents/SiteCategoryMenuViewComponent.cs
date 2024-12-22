using Microsoft.AspNetCore.Mvc;

namespace codingtr.ViewComponents
{
    public class SiteCategoryMenuViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
