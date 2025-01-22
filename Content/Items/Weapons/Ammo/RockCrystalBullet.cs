using Astaris.Common;
using Astaris.Content.Items.Placeables;
using Astaris.Content.Projectiles.Weapons;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using StarlightAltar = Astaris.Content.Tiles.StarlightAltar;

namespace Astaris.Content.Items.Weapons.Ammo;

public class RockCrystalBullet : ModItem
{
    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
    }

    public override void SetDefaults()
    {
        Item.width = 8;
        Item.height = 8;
        Item.maxStack = 999;
        
        Item.damage = 12;
        Item.DamageType = DamageClass.Ranged;
        Item.knockBack = 2.25f;
        
        Item.consumable = true;

        Item.ammo = AmmoID.Bullet;
        Item.shoot = ModContent.ProjectileType<RockCrystalBulletProjectile>();
        Item.shootSpeed = 4f;
    }

    public override void AddRecipes()
    {
        Recipe recipe = Recipe.Create(ModContent.ItemType<RockCrystalBullet>(), 10);
        recipe.AddIngredient(ModContent.ItemType<RockCrystal>(), 1)
            .AddTile<StarlightAltar>()
            .Register();
    }
}