using codingtr.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace codingtr.ViewComponents
{
    public class SiteProjectPostListViewComponent:ViewComponent
    {
        private IPostRepository _postRepository;

        public SiteProjectPostListViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            ViewBag.ProjectPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 2).ToListAsync();
      

            return View();
        }
    }
}
