using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _NavbarPartial : ViewComponent
	{
		private readonly ISocialMediaDal _socialMediaDal;

		public _NavbarPartial(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public IViewComponentResult Invoke()
		{
			var values = _socialMediaDal.GetListAll();
			return View(values); 
		}
	}
}
