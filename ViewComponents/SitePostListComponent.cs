using codingtr.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;

namespace codingtr.ViewComponents
{
    public class SitePostListViewComponent:ViewComponent
    {
        private IPostRepository _postRepository;

        public SitePostListViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.AskAndQuestionPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 1).ToListAsync();
            ViewBag.ProjectPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 2).ToListAsync();
            ViewBag.BlogPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 3).ToListAsync();
            ViewBag.JobPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 4).ToListAsync();
            ViewBag.EventPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 5).ToListAsync();

            return View();
        }
    }
}
