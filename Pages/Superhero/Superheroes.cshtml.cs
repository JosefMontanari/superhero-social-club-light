using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroSocialClubLight.Database;
using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Pages.Superhero
{
	public class SuperheroesModel : PageModel
	{
		public List<SuperHero> Superheroes { get; set; }


		public void OnGet()
		{
			Superheroes = SuperHeroRepository.SuperHeros;
		}
	}
}
