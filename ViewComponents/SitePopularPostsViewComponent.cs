using codingtr.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace codingtr.ViewComponents
{
    public class SitePopularPostsViewComponent : ViewComponent
    {
        private IPostRepository _postRepository;

        public SitePopularPostsViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            // ViewBag.PopulerPostsList = await _postRepository.Post.Where(item => item.Category.CategoryId == 3).Take(7).ToListAsync();
            ViewBag.PopulerPostsList = await _postRepository.Post
                .Where(item => item.Category != null && item.Category.CategoryId == 3) // NULL kontrolü
                .Take(3)
                .ToListAsync();


            return View();
        }
    }
}
