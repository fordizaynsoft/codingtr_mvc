using codingtr.Data.Abstract;
using codingtr.Data.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace codingtr.ViewComponents
{
    public class SiteDevelopmentTopicsViewComponent:ViewComponent
    {
        private IDevelopmentTopicRepository _developmentTopicRepository;

        public SiteDevelopmentTopicsViewComponent(IDevelopmentTopicRepository developmentTopicRepository)
        {
            _developmentTopicRepository = developmentTopicRepository;
        }



        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.DevelopmentTopics =  _developmentTopicRepository.DevelopmentTopic.ToList();

            return await Task.FromResult(View());
        }
    }
}
