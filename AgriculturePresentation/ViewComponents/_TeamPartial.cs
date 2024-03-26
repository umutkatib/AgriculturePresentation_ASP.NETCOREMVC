using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.ViewComponents
{
	public class _TeamPartial : ViewComponent
	{
		private readonly ITeamService _teamService;

		public _TeamPartial(ITeamService teamService)
		{
			_teamService = teamService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _teamService.GetListAll();
			return View(values);
		}
	}
}
