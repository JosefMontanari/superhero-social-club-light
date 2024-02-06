using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperHeroSocialClubLight.Database;
using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Pages.Superhero
{
	public class DetailsModel : PageModel
	{

		public SuperHero? Superhero { get; set; }


		public void OnGet(int id, string Name, string SecretIdentity)
		{
			Superhero = SuperHeroRepository.SuperHeros.FirstOrDefault(s => s.Id == id);
		}
	}
}
