using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroSocialClubLight.Database;
using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Pages.Superhero
{

	public class EditModel : PageModel
	{
		public int Id { get; set; }
		[BindProperty]
		public string Name { get; set; }
		[BindProperty]
		public string SecretIdentity { get; set; }
		[BindProperty]
		public List<string>? SuperPowers { get; set; }


		public void OnGet(int id)
		{
			Id = id;
		}

		public void OnPost()
		{
			int id = SuperHeroRepository.SuperHeros.Count + 1;
			SuperHero superHero = new SuperHero(id, Name, SecretIdentity, SuperPowers.ToString());
			SuperHeroRepository superHeroRepository = new SuperHeroRepository();
			superHeroRepository.UpdateSuperHero(Id, superHero);
		}
	}
}
