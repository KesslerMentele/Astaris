﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Astaris.Content.Projectiles.Weapons;
using Astaris.Content.Items.Placeables;
using Terraria.Enums;

namespace Astaris.Content.Items.Weapons
{
    internal class CrystalShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Rapier;

            Item.UseSound = SoundID.Item1;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 17;
            Item.knockBack = 4f;

            Item.rare = ItemRarityID.Blue;
            Item.value = Item.buyPrice(silver: 20);
            
            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 2.1f;
            Item.shoot = ModContent.ProjectileType<CrystalShortswordProjectile>();
        }

        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
            MoonPhase phase = Main.GetMoonPhase();

            switch (phase)
            {
                case MoonPhase.Empty:
                    damage *= 2.0f;
                    break;
                case MoonPhase.QuarterAtLeft:
                case MoonPhase.QuarterAtRight:
                    damage *= 1.75f;
                    break;
                case MoonPhase.HalfAtLeft:
                case MoonPhase.HalfAtRight:
                    damage *= 1.5f;
                    break;
                case MoonPhase.ThreeQuartersAtLeft:
                case MoonPhase.ThreeQuartersAtRight:
                    damage *= 1.25f;
                    break;
                case MoonPhase.Full:
                    damage *= 1f;
                    break;
            }
			
        }
        
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<RockCrystal>(), 5) // ItemId, Qty
                .AddTile<Tiles.StarlightAltar>()
                .Register(); // Add Recipe
        }
    }
}
