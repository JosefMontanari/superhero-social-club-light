namespace SuperHeroSocialClubLight.Models
{
	public class SuperHero
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? SecretIdentity { get; set; }
		public List<string> SuperPowers { get; set; }
		public string? Img { get; set; }

		public SuperHero(int id, string name, string secretIdentity, params string[] superPowers)
		{
			Id = id;
			Name = name;
			SecretIdentity = secretIdentity;
			SuperPowers = new List<string>(superPowers);
			Img = Name + ".jpg";
		}

	}
}
