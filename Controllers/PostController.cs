using codingtr.Models;
using Microsoft.AspNetCore.Mvc;
using codingtr.Data.Abstract;
using System.Security.Claims;
using Microsoft.Identity.Client;
namespace codingtr.Controllers
{
    public class PostController : Controller
    {
        private IPostRepository _postRepository;
        private IUserRepository _userRepository;

        public PostController(IPostRepository postRepository, IUserRepository userRepository)
        {
            _postRepository = postRepository;
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult PostList()
        {
            return Json(_postRepository.Post.ToList());
        }



        /*Created Post*/
        [HttpPost]
        public async Task<IActionResult> CreatePost(string Title, string Description, string Content, int CategoryId, IFormFile imageFile)
        {
            string extension;
            string randomFileName;
            string path;

            if (imageFile == null)
            {

                randomFileName = "";

            }
            else
            {
                extension = Path.GetExtension(imageFile.FileName);
                randomFileName = string.Format($"{Guid.NewGuid().ToString()}{extension}");
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/posts", randomFileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }

            }
            var user = HttpContext.User;
            int UserID = 0;

            if (user.Identity.IsAuthenticated)
            {
                UserID = Convert.ToInt32(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                Console.WriteLine("userıd:::", UserID);
            }


            var entity = new Post
            {
                Title = Title,
                Description = Description,
                Content = Content,
                CategoryId = CategoryId,
                CreatedAt = DateTime.Now,
                ImageFile = randomFileName,
                UserId = UserID
            };
            _postRepository.CreatePost(entity);
            return RedirectToAction("Index", "Home");




        }
    }
}

