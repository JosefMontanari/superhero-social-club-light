using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperHeroSocialClubLight.Pages.Superhero
{
	public class SignupModel : PageModel
	{
		public string? Name { get; set; }
		public string? SecretIdentity { get; set; }
		public string? Superpower { get; set; }


		public void OnGet()
		{
		}
	}
}
