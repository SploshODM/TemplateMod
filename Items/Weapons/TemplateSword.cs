using Terraria.ID;
using Terraria.ModLoader;

namespace TemplateMod.Items.Weapons
    // * namespace is the directory to where the source file AND sprite are located
{
	public class TemplateSword : ModItem
            // * Set the in-code name for the item. Sprite must have a matching name
	{
		public override void SetStaticDefaults()
            // * This is where you set the name and tooltip for the item
        {
            //ToolTip Strings
            string TT1 = "A basic sword with no special effects";
            // * Can have multiple line in the tooltip. Set each line here, end with '\n' and concatenate them in the 'Tooltip.SetDefault' line

            //Defaults
            DisplayName.SetDefault("Template Sword");
                // * The name of the item, as seen in game
            Tooltip.SetDefault(TT1);
                // * Set the items tooltip here
        }

        public override void SetDefaults()
            // * This is where you set the properties of the sword/item
        {
            item.CloneDefaults(ItemID.WoodenSword);
            // * This item is the most basic of weapons, a clone of a Vanilla Terraria Item. For a custom weapon, look at ItemSetDefaultsAttributes.txt for all available attributes
        }

        public override void AddRecipes()
            // * This is where you add the recipe for the sword
        {
            ModRecipe recipe = new ModRecipe(mod);      //CRITICAL
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.anyWood = true;
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);                     //CRITICAL
            recipe.AddRecipe();                         //CRITICAL

            //This is a simple recipe. TemplateSword is craftable if the player has 1 dirt block and 1 wood block (of any type) near a workbench
        }
    }
}
