using Terraria.ModLoader;

namespace SuperQuickRespawn
{
	class SuperQuickRespawn : Mod
	{
		public SuperQuickRespawn()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
