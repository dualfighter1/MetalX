using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using static Terraria.ModLoader.ModContent;

namespace MetalX.blocks
 {
     public class steelore : ModTile
     {
         public override void SetStaticDefaults()
         {
             Main.tileSolid[Type] = true;
             Main.tileSpelunker[Type] = true;
             Main.tileMergeDirt[Type] = true;
             AddMapEntry(new Color(200, 200, 200));

             ItemDrop = ItemType<Items.steelore>();
         }
     }
 }
