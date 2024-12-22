using codingtr.Data.Abstract;
using codingtr.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace codingtr.ViewComponents
{
    public class SiteGroupsViewComponent:ViewComponent
    {
        private IGroupRepository _groupRepository;

        public SiteGroupsViewComponent(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Groups = _groupRepository.Group.ToList();
            return await Task.FromResult(View());
        }
    }
}
