using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MetalX.armour
{
	[AutoloadEquip(EquipType.Body)]
	public class steelbreastplate : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Steel Breastplate");
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 8;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Items.steel>(), 25);
                      	                      recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}