using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MetalX.armour
{
	[AutoloadEquip(EquipType.Legs)]
	public class steelleggings : ModItem
	{
		public override void SetStaticDefaults() {
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 100;
			Item.rare = ItemRarityID.Blue;
			Item.defense = 7;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
                                                                 recipe.AddIngredient(ModContent.ItemType<Items.steel>(), 20);
                                                                  recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}