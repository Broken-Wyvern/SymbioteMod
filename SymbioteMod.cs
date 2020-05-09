using Terraria.ModLoader;

namespace SymbioteMod
{
	public class SymbioteMod : Mod
	{
		public SymbioteMod()
		{
		}

		public override void Load()
		{
			SModInput.LoadInput(this);
		}

		public override void Unload()
		{
			SModInput.UnloadInput();
		}

	}
}