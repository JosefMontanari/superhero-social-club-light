using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroSocialClubLight.Database;
using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Pages.Superhero
{

	public class EditModel : PageModel
	{
		public SuperHero? Hero { get; set; }

		[BindProperty]
		public string? Name { get; set; }
		[BindProperty]
		public string? SecretIdentity { get; set; }
		[BindProperty]
		public int id { get; set; }

		[BindProperty]
		public List<string>? SuperPowers { get; set; }

		public void OnGet(int id)
		{
			this.Hero = SuperHeroRepository.SuperHeros.FirstOrDefault(h => h.Id == id);
			Name = Hero.Name;
			SecretIdentity = Hero.SecretIdentity;
			//SuperPowers = Hero.SuperPowers;

		}

		public void OnPost()
		{
			SuperHero? superHero = new SuperHero(id, Name, SecretIdentity);
			SuperHeroRepository.AddSuperPowers(SuperPowers, superHero);
			SuperHeroRepository.UpdateSuperHero(id, superHero);


		}
	}
}
