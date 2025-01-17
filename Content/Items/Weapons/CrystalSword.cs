using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Astaris.Content.Items.Placeables;


namespace Astaris.Content.Items.Weapons
{
    internal class CrystalSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			// Hitbox
			Item.width = 32;
			Item.height = 32;


			// Use Style
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.autoReuse = true;

			// Damage
			Item.DamageType = DamageClass.Melee;
			Item.damage = 20;
			Item.knockBack = 3.5f;
			Item.crit = 5;


			// Misc
			Item.value = Item.buyPrice(silver: 10, copper: 5);
			Item.rare = ItemRarityID.Blue;

            // Sound
            Item.UseSound = SoundID.Item1;
        }


		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<RockCrystal>(), 6) // ItemId, Qty
				.AddTile(TileID.Anvils) // TileID
				.Register(); // Add Recipe
		}

	}
}
