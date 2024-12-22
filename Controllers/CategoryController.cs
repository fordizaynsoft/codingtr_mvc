using codingtr.Data.Concrete.EfCore;
using codingtr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using codingtr.Data.Abstract;
using System.Security.Claims;

namespace codingtr.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository _categoryRepository;
        private IPostRepository _postRepository;

        public CategoryController(ICategoryRepository categoryRepository, IPostRepository postRepository)
        {
            _categoryRepository = categoryRepository;
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Index(string name)
        {

            var user = HttpContext.User;
            ViewBag.UserName = User.FindFirst(ClaimTypes.Name)?.Value;

            name ??= "default";
            if (name == "blog")
            {

                ViewData["CategoryName"] = "Blog";
                ViewBag.CategoryPostList = await _postRepository.Post.Include(post => post.User).Where(item => item.Category.CategoryId == 3).OrderByDescending(item => item.CreatedAt).ToListAsync();
            }

            if (name == "soru-cevap")
            {
                ViewData["CategoryName"] = "Soru-Cevap";
                ViewBag.CategoryPostList = await _postRepository.Post.Where(item => item.Category.CategoryId == 1).OrderByDescending(item => item.CreatedAt).ToListAsync();
            }

            if (name == "proje-tanitim")
            {
                ViewData["CategoryName"] = "Proje Tanıtım";
                ViewBag.CategoryPostList = await _postRepository.Post.Where(item => item.Category.CategoryId == 2).OrderByDescending(item => item.CreatedAt).ToListAsync();
            }

            if (name == "etkinlikler")
            {
                ViewData["CategoryName"] = "Etkinlikler";
                ViewBag.CategoryPostList = await _postRepository.Post.Where(item => item.Category.CategoryId == 5).OrderByDescending(item => item.CreatedAt).ToListAsync();
            }


            if (name == "is-ilanlari")
            {
                ViewData["CategoryName"] = "İş İlanları";
                ViewBag.CategoryPostList = await _postRepository.Post.Where(item => item.Category.CategoryId == 4).OrderByDescending(item => item.CreatedAt).ToListAsync();
            }





            return View();


        }

        // private List<string> GetDataByCategory(string category)
        // {
        //     // Örnek veri kaynağı
        //     var allData = new Dictionary<string, List<string>>
        // {
        //     { "blog", new List<string> { "Blog Post 1", "Blog Post 2", "Blog Post 3" } },
        //     { "news", new List<string> { "News Article 1", "News Article 2" } },
        //     { "sports", new List<string> { "Sports News 1", "Sports News 2", "Sports News 3" } },
        // };

        //     // Eğer kategori bulunamazsa boş bir liste döndür
        //     return allData.ContainsKey(category) ? allData[category] : new List<string>();
        // }
    }
}

