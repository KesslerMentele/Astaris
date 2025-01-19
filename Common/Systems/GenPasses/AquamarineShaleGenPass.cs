using Terraria;
using Terraria.ModLoader;
using Terraria.IO;
using Terraria.WorldBuilding;
using Astaris.Content.Tiles;
using Terraria.ID;


namespace Astaris.Common.Systems.GenPasses
{
    internal class AquamarineShaleGenPass : GenPass
    {
        public AquamarineShaleGenPass(string name, float weight) :  base(name, weight)
        {

        } 

        protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
        {
            progress.Message = "Spawning Aquamarine Shale";

            // Aquamarine Shale
            int maxToSpawn = WorldGen.genRand.Next(400,1000);
            int numSpawned = 0;
            int attempts = 0;
            while(numSpawned < maxToSpawn)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)GenVars.worldSurface, Main.maxTilesY - 300);

                Tile tile = Framing.GetTileSafely(x, y);

                if ((tile.TileType == TileID.Sand))
                {
                    WorldGen.TileRunner(x, y, WorldGen.genRand.Next(8, 12), WorldGen.genRand.Next(2, 5), ModContent.TileType<AquamarineShale>());
                    numSpawned++;
                }
                attempts++;
                if (attempts >= 100000) 
                {
                    break;
                }
            }
        }
    }
}
