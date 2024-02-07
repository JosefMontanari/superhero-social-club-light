using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroSocialClubLight.Database;
using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Pages.Superhero
{
	[BindProperties]
	public class SignupModel : PageModel
	{

		[BindProperty]
		public string? Name { get; set; }
		[BindProperty]
		public string? SecretIdentity { get; set; }

		[BindProperty]
		public List<string>? SuperPowers { get; set; }


		public void OnGet()
		{
		}

		public void OnPost()
		{
			int id = SuperHeroRepository.SuperHeros.Count + 1;
			SuperHero hero = new SuperHero(id, Name, SecretIdentity);
			SuperHeroRepository.AddSuperPowers(SuperPowers, hero);
			SuperHeroRepository.AddSuperHero(hero);
		}

	}
}
