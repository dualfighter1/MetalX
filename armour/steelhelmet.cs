using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace MetalX.armour
{
	[AutoloadEquip(EquipType.Head)]
	public class steelhelmet : ModItem
	{
		public override void SetStaticDefaults() {
		}

		public override void SetDefaults() {
			Item.width = 18;
			Item.height = 18;
			Item.value = 100;
			Item.rare = ItemRarityID.Green;
			Item.defense = 7;
		}

		public override void AddRecipes() {
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<Items.steel>(), 15);
                                                                  recipe.AddTile(TileID.Anvils);
			recipe.Register();
		}
	}
}