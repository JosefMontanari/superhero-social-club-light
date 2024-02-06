using SuperHeroSocialClubLight.Models;

namespace SuperHeroSocialClubLight.Database
{
	public class SuperHeroRepository
	{
		public static List<SuperHero> SuperHeros { get; set; } = new List<SuperHero>{

			new SuperHero(1, "Superman", "Clark Kent", "Super strength", "Flight"),
			new SuperHero(2, "Batman", "Bruce Wayne", "Intelligence", "Martial Arts", "Gadgets"),
			new SuperHero(3, "Wonder Woman", "Diana Prince", "Super strength", "Flight", "Lasso of Truth"),
			new SuperHero(4, "Spider-Man", "Peter Parker", "Wall-crawling", "Spider-Sense", "Web-slinging"),
			new SuperHero(5, "Captain America", "Steve Rogers", "Super strength", "Shield mastery", "Peak human agility")

			};
		public void AddSuperHero(SuperHero superHero)
		{
			SuperHeros.Add(superHero);
		}

		public bool RemoveSuperHero(int id)
		{
			// Returnerar en bool så vi vet om den tar bort en superhjälte eller ej

			SuperHero superHeroToRemove = SuperHeros.FirstOrDefault(x => x.Id == id);
			if (superHeroToRemove != null)
			{
				SuperHeros.Remove(superHeroToRemove);
				return true;
			}
			else
			{
				return false;
			}

		}

		public bool UpdateSuperHero(int id, SuperHero superHero)
		{
			// Kolla så det finns en superhero med det id
			SuperHero superHeroToUpdate = SuperHeros.FirstOrDefault(superHero => superHero.Id == id);
			if (superHeroToUpdate != null)
			{

				// Kolla så att superhjälten man skickat med inte är null
				if (superHero != null)
				{
					// Om allt är korrekt så adderas hjälten och den gamla tas bort
					SuperHeros.Add(superHero);
					SuperHeros.Remove(superHeroToUpdate);

					return true;

				}

				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}
	}

}
