using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Database
{
	public static class SuperHeroRepository
	{
		public static List<SuperHero> SuperHeros { get; set; } = new List<SuperHero>{

			new SuperHero(1, "Superman", "Clark Kent", "Super strength", "flight"),
			new SuperHero(2, "Batman", "Bruce Wayne", "Intelligence", "Martial Arts", "Gadgets"),
			new SuperHero(3, "Wonder Woman", "Diana Prince", "Super strength", "Flight", "Lasso of Truth"),
			new SuperHero(4, "Spider-Man", "Peter Parker", "Wall-crawling", "Spider-Sense", "Web-slinging"),
			new SuperHero(5, "Captain America", "Steve Rogers", "Super strength", "Shield mastery", "Peak human agility")

			};
	}
}
