using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MetalX.Items
 {

     public class steel : ModItem
     {
     
         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("Steel");
         }

         public override void SetDefaults()
         {
           Item.width = 15;
           Item.height = 12;
           Item.rare = ItemRarityID.White;
           Item.value = Item.sellPrice(silver: 2);
           Item.maxStack = 999;
           Item.consumable = false;
        }

		public override void AddRecipes() 
		{
			Recipe recipe = CreateRecipe();
                        		recipe.AddIngredient(ModContent.ItemType<steelore>(), 3);
			recipe.AddTile(TileID.Furnaces);
			recipe.Register();
		}
     }
 }