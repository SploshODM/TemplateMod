using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TemplateMod.Items.Weapons
{
    public class TemplateGun : ModItem
        //This is where you set the in-code name for the item
    {
        public override void SetStaticDefaults()
            //Setting the basic default information for the item
        {
            DisplayName.SetDefault("Template Gun");    
                //This sets the 'In Game Name' of your item, the name players see when hovering their cursor over the item
            Tooltip.SetDefault("This is a basic gun with no special effects");
                //This is the tooltip (description) of the item when hovering over it in the inventory
        }

        public override void SetDefaults()
        {
            //These settings make this item a gun
            item.noMelee = true;                    //sprite does no damage (summon weapons)
            item.shoot = 14;                        //This defines what type of projectile this weapon will shoot. Vanilla = [item.shoot = <ProjectileID>]. Modded = [item.shoot = mod.ProjectileType("<ProjectileName>")]
            item.useAmmo = AmmoID.Bullet;           //The ID of the ammo this weapon uses
            item.useStyle = 5;                      //Animation style: 1=overhead swing, 2=drinking, 3=stab, 4=hold up like life crystal, 5=staffs/guns
            item.ranged = true;                     //This item does Ranged Damage

            //These attributes set the technical aspects of the gun
            item.height = 32;                        //The size of the height of the hitbox in pixels.
            item.reuseDelay = 0;                    //Delay added after useAnimation timer, the player cannot use the item until after this cooldown
            item.scale = 1f;                        //Size multiplier of items sprite
            item.useAnimation = 20;                 //How long the Weapon is used for.
            item.useTime = 20;                      //How fast the Weapon is used.
            item.width = 32;                        //The size of the width of the hitbox in pixels.

            //These attributes give the item style and originality
            item.crit = 0;                          //Crit strike chance. Player has base Crit Strike chance of 4%. Therefore item.crit = 0 means the item has 4% critical strike chance
            item.damage = 0;                        //The damage stat for the Weapon.
            item.knockBack = 0.1f;                  //The knockback (float) stat of your Weapon.
            item.UseSound = null;                   //What sounds plays when item is used. Use this property as:[item.UseSound = SoundID.Item1;]. See 'Sound Library below'

            //Additional attributes can be added by referring to ItemSetDefaultsAttributes.txt
        }

        public override void AddRecipes() //Adding recipes
                                          // * This is where you add the recipe for the gun
        {
            ModRecipe recipe = new ModRecipe(mod);      //CRITICAL
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.anyWood = true;
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);                     //CRITICAL
            recipe.AddRecipe();                         //CRITICAL

            //This is a simple recipe. TemplateGun is craftable if the player has 1 dirt block and 1 wood block (of any type) near a workbench
        }

    }
}
