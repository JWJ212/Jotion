using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TutorialMod.Potions
{
	public class Jotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jotion"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("I am retarded.");
		}

		public override void SetDefaults()
		{
			Item.width = 30;
			Item.height = 30;
			Item.useTime = 25;
			Item.useAnimation = 20;
			Item.useStyle = 2;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item3;
			Item.autoReuse = true;
			Item.potion = true;
			Item.consumable = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.Bottles);
			recipe.Register();
		}
	}
}