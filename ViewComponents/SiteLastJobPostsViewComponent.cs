using codingtr.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace codingtr.ViewComponents
{
    public class SiteLastJobPostsViewComponent:ViewComponent
    {
        private IPostRepository _postRepository;

        public SiteLastJobPostsViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.JobPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 4).ToListAsync();

            return View();
        }
    }
}
