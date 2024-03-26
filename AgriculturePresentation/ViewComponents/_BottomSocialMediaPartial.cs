using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _BottomSocialMediaPartial : ViewComponent
	{
		private readonly ISocialMediaService _bottomSocialMediaService;

		public _BottomSocialMediaPartial(ISocialMediaService socialMediaService)
		{
			_bottomSocialMediaService = socialMediaService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _bottomSocialMediaService.GetListAll();
			return View(values);
		}
	}
}
