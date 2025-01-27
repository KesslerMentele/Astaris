using Astaris.Content.Items.Placeables;
using Astaris.Content.Projectiles.Weapons;
using Terraria.ID;
using Terraria.ModLoader;

namespace Astaris.Content.Items.Weapons;

public class Comet : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 38;
        Item.height = 34;
        Item.scale = 1.1f;
        
        Item.noMelee = true;
        Item.useStyle = ItemUseStyleID.Shoot;
        Item.useAnimation = 40;
        Item.useTime = 40;
        Item.noUseGraphic = true;
        
        Item.knockBack = 7.5f;
        Item.damage = 35;
        Item.DamageType = DamageClass.MeleeNoSpeed;
        
        Item.UseSound = SoundID.Item1;
        
        Item.shoot = ModContent.ProjectileType<CometProjectile>();
        Item.shootSpeed = 15.9f;
        
        Item.channel = true;
    }

    public override void AddRecipes()
    {
        CreateRecipe().AddIngredient(ModContent.ItemType<RockCrystal>(), 25)
            .AddIngredient(ItemID.Chain, 2)
            .AddTile<Tiles.StarlightAltar>()
            .Register();
    }
}