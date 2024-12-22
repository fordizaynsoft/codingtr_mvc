using Microsoft.AspNetCore.Mvc;

namespace codingtr.ViewComponents
{
    public class SiteLastEventsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View());
        }
    }
}
