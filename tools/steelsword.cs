using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MetalX.tools
{
	public class steelsword: ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Steel Sword"); 
		}

		public override void SetDefaults() 
		{
			Item.damage = 45;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
                        		Item.maxStack = 1;
		}	

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Items.steel>(), 8);
                        		recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}