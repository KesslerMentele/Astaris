using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace Astaris.Content.Items.Placeables;


public class StarlightAltar : ModItem
{
    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 20;
        Item.useTime = 15;
        Item.useAnimation = 15;

        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTurn = true;
        
        Item.maxStack = 999;
        Item.consumable = true;

        Item.createTile = ModContent.TileType<Tiles.StarlightAltar>();
    }
    
    public override void AddRecipes()
    {
        Recipe baseRecipe = Recipe.Create(ModContent.ItemType<StarlightAltar>(), 1);
        
        baseRecipe.AddRecipeGroup(RecipeGroupID.Wood, 5)
            .AddIngredient(ItemID.FallenStar, 5)
            .AddIngredient(ItemID.SilverBar, 10)
            .AddTile(TileID.Benches)
            .Register();
        Recipe altRecipe = baseRecipe.Clone();
        altRecipe.AddIngredient(ItemID.TungstenBar, 10);
        altRecipe.RemoveIngredient(ItemID.SilverBar);
        altRecipe.Register();
    }
    
}