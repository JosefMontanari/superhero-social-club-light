using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperHeroSocialClubLight.Pages.Superhero
{
	[BindProperties]
	public class SignupModel : PageModel
	{
		public string? Name { get; set; }
		public string? SecretIdentity { get; set; }
		public string? Superpower { get; set; }


		public void OnGet()
		{
		}

		public IActionResult OnPost()
		{
			if (Name != null && SecretIdentity != null)
			{
				return RedirectToPage("Superhero/Superheroes");
			}
			else
			{
				return Page();
			}
		}

	}
}
