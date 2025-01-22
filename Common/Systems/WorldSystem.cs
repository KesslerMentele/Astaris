using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
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
            
            // if (!Main.hardMode)
            // {
            //     return; // Only run the code in hardmode
            // }
            




            // if (!Main.rand.NextBool(5))
            // {
            //     return;
            // }
            int i = Main.rand.Next(Main.maxTilesX);
            int j = Main.rand.Next((int)Main.worldSurface);

            ushort tileId = Main.tile[i, j].TileType;
            
            if (tileId != TileID.Marble || Main.tile[i, j].IsActuated ) // Potentially make into custom Tileset
            {
                return;
            }

            for (int num = 0; num < 4; num++)
            {
                int num2 = 0;
                int num3 = 0;

                switch (num)
                {
                    case 0:
                        num2 = 1;
                        num3 = 1;
                        break;
                    case 1:
                        num2 = 1;
                        num3 = -1;
                        break;
                    case 2:
                        num2 = -1;
                        num3 = 1;
                        break;
                    case 3:
                        num2 = -1;
                        num3 = -1;
                        break;
                }

                if (Main.tile[i + num2, j + num3].HasUnactuatedTile)
                {
                    return;
                }

                bool placed = WorldGen.PlaceTile(i + num2, j + num3, ModContent.TileType<RockCrystal>(),
                    true);
                if (placed)
                {
                    break;
                }
            }
        }
    }
}
