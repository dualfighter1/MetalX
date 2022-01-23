using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MetalX.Items
 {

     public class steelore : ModItem
     {

         public override void SetStaticDefaults()
         {
             DisplayName.SetDefault("Steel Ore");
         }

         public override void SetDefaults()
         {
           Item.width = 15;
           Item.height = 12;
           Item.rare = ItemRarityID.White;
           Item.value = Item.sellPrice(silver: 2);
           Item.maxStack = 999;
           Item.consumable = true;
           Item.useStyle = 1;
           Item.useTime = 10;
           Item.useAnimation = 10;
           Item.autoReuse = true;
           Item.createTile = TileType<blocks.steelore>();
        }
     }
 }
