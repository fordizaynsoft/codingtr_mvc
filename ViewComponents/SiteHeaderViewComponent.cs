using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Http; 

namespace codingtr.ViewComponents
{
    public class SiteHeaderViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userDetails =HttpContext.User.FindFirstValue(ClaimTypes.Role);
         

            ViewBag.userDetails = userDetails;

            return await Task.FromResult(View());
        }
    }
}
