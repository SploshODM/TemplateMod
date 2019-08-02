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
            //These settings make this item a sword
            item.melee = true;                      //This item does Melee Damage
            item.useStyle = 1;                      //Animation style: 1=overhead swing, 2=drinking, 3=stab, 4=hold up like life crystal, 5=staffs/guns

            //These attributes set the technical aspects of the sword
            item.height = 40;                       //The size of the height of the hitbox in pixels.
            item.scale = 1f;                        //Size multiplier of items sprite
            item.useAnimation = 50;                 //How long the Weapon is used for.
            item.useTime = 50;                      //How fast the Weapon is used.
            item.useTurn = false;                   //Can the player turn during items' animation
            item.width = 40;                        //The size of the width of the hitbox in pixels.

            //These attributes give the item style and originality
            item.autoReuse = false;                 //true = autoswing
            item.crit = 2;                          //Crit strike chance. Player has base Crit Strike chance of 4%. Therefore item.crit = 0 means the item has 4% critical strike chance
            item.damage = 7;                        //The damage stat for the Weapon.
            item.knockBack = 0.5f;                  //The knockback (float) stat of your Weapon.
            item.UseSound = null;                   //What sounds plays when item is used. Use this property as:[item.UseSound = SoundID.Item1;]. See 'Sound Library below'
            item.value = 20;                         //Value of the item when bought, in PPGGSSCC. Sell price = 1/5th of buy price
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
