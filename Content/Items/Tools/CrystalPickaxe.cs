using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Astaris.Content.Items.Placeables;


namespace Astaris.Content.Items.Tools
{
    internal class CrystalPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 32;

			Item.useTime = 13;
			Item.useAnimation = 15;
			Item.autoReuse = true;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;


			Item.DamageType = DamageClass.Melee;
			Item.damage = 12;
			Item.knockBack = 3f;

			Item.value = Item.buyPrice(silver: 20);
			Item.rare = ItemRarityID.Blue;

			Item.pick = 60;

            // Sound
            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
			CreateRecipe()
				 .AddRecipeGroup(RecipeGroupID.Wood, 4)
				 .AddIngredient(ModContent.ItemType<RockCrystal>(), 8)
				 .AddTile(TileID.Anvils)
				 .Register();
        }

    }
}
