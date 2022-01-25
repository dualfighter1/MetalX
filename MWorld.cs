using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using static Terraria.ModLoader.ModContent;
using System.Collections.Generic;

namespace MWorld
{
    public class MWorld : ModSystem
    {
        private void OreGeneration(GenerationProgress progress) 
        {
            progress.Message = "Destroying Science Facilities";
            for(int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 7E-04); i++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                Tile tile = Framing.GetTileSafely(x, y);
                if (tile.IsActive && tile.type == TileID.Stone)
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 7), WorldGen.genRand.Next(1, 5), TileType<MetalX.blocks.steelore>());
                }
            }
        }
    }
}
