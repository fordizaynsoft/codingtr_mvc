using codingtr.Data.Abstract;
using codingtr.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace codingtr.ViewComponents
{
    public class SiteAddPostViewComponent:ViewComponent
    {
        private IPostRepository _postRepository;
        private ICategoryRepository _categoryRepository;
        public SiteAddPostViewComponent(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository; 
        }


   

      
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Category = new SelectList(await _categoryRepository.Category.ToListAsync(), "CategoryId", "Name");
            //var Category =await _categoryRepository.Category.ToListAsync();
            ViewBag.Category = Category;
            return View();

        }
    }
}
