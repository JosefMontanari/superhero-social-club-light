using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroSocialClubLight.Database;
using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Pages.Superhero
{

	public class EditModel : PageModel
	{

		[BindProperty]
		public string? Name { get; set; }
		[BindProperty]
		public string? SecretIdentity { get; set; }
		[BindProperty]
		public List<string>? SuperPowers { get; set; }

		public SuperHero? Hero { get; set; }
		public void OnGet(int id)
		{
			Hero = SuperHeroRepository.SuperHeros.FirstOrDefault(h => h.Id == id);

		}

		public void OnPost()
		{

			int idHero = SuperHeroRepository.SuperHeros.Count + 1;
			SuperHero? superHero = new SuperHero(idHero, Name, SecretIdentity, SuperPowers.ToString());
			SuperHeroRepository superHeroRepository = new SuperHeroRepository();
			superHeroRepository.UpdateSuperHero(Hero.Id, superHero);

		}
	}
}
