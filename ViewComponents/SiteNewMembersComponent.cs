using codingtr.Data.Abstract;
using codingtr.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace codingtr.ViewComponents
{
    public class SiteNewMembersViewComponent : ViewComponent
    {
        private IUserRepository _userRepository;

        public SiteNewMembersViewComponent(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            ViewBag.LastUserList = await _userRepository
                .GetAllUser
                .OrderByDescending(user => user.CreatedAt) // `CreatedAt` alanına göre azalan sıralama
                .Take(10)                                 // İlk 10 kaydı al
                .ToListAsync();


            ViewBag.LastUserListCount = 56;

            return View();
        }
    }
}
