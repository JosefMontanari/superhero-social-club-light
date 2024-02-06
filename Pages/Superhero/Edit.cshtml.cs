using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperHeroSocialClubLight.Pages.Superhero
{
	[BindProperties]
	public class EditModel : PageModel
	{
		public string Name { get; set; }
		public string SecretIdentity { get; set; }
		public List<string> SuperPowers { get; set; }


		public void OnGet()
		{
		}

		public void OnPost()
		{
		}
	}
}
