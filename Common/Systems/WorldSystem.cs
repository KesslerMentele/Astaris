using Terraria.ModLoader;
using Terraria.WorldBuilding;
using System.Collections.Generic;
using Astaris.Common.Systems.GenPasses;

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
    }
}
