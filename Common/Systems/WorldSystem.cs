using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using System.Linq;
using Astaris.Common.Systems.GenPasses;
using Astaris.Content.Tiles;
using Terraria;
using Terraria.ID;

namespace Astaris.Common.Systems
{
    internal class WorldSystem : ModSystem
    {

        
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {
            int surfaceOreIndex = tasks.FindIndex(t => t.Name.Equals("Surface Ore and Stone"));
            if (surfaceOreIndex != -1) 
            {
                tasks.Insert(surfaceOreIndex + 1, new AquamarineShaleGenPass("Aquamarine Shale Pass", 320f));
            }
        }

        public override void PostUpdateWorld()
        {
            
            if (!Main.hardMode || Main.rand.NextBool(2))
            {
                return; // Only run the code in hardmode
            }
            
            int i = Main.rand.Next(Main.maxTilesX);
            int j = Main.rand.Next((int)Main.worldSurface);

            ushort tileId = Main.tile[i, j].TileType;
            
            if (tileId != TileID.Marble || Main.tile[i, j].IsActuated ) // Potentially make into custom Tileset
            {
                return;
            }
            
            var signPairs = new (int, int)[]
            {
                (1, 1),
                (1, -1),
                (-1, 1),
                (-1, -1)
            };
            
            var shuffled = signPairs.OrderBy(_ => Main.rand.Next()).ToList();
            
            foreach (var (num2, num3) in shuffled)
            {
                if (Main.tile[i + num2, j + num3].HasUnactuatedTile)
                {
                    return;
                }
                bool placed = WorldGen.PlaceTile(i + num2, j + num3, ModContent.TileType<RockCrystal>(), true);
                if (placed)
                {
                    break;
                }
            }
        }
    }
}
