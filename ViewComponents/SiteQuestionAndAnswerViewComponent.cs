using codingtr.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace codingtr.ViewComponents
{
    public class SiteQuestionAndAnswerViewComponent : ViewComponent
    {
        private IPostRepository _postRepository;

        public SiteQuestionAndAnswerViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.QuestionAndAnswerPosts = await _postRepository.Post.Where(item => item.Category.CategoryId == 1).Take(8).ToListAsync(); 
            return View();
        }
    }
}
