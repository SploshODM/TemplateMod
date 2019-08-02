using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TemplateMod.Items.Weapons
{
    public class TemplateSummonStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Template Summon Staff");
            Tooltip.SetDefault("Summons a friendly minion");
        }
        
        public override void SetDefaults()
        {
            //These Attributes make the item a summon weapon
            item.buffTime = -1;                      //Duration of given buff
            item.buffType = BuffID.PetBunny;                      //ID of buff given by the item. For multiple buffs, assign one buff here, then in ModItem.UseItem, call player.AddBuff(buffID, time)
            item.noMelee = true;                    //sprite does no damage (summon weapons)
            item.shoot = ProjectileID.Bunny;                         //This is what the projectile will look like. Vanilla = [item.shoot = <ProjectileID>]. Modded = [item.shoot = mod.ProjectileType("<ProjectileName>")]
            item.shootSpeed = 10f;                   //Speed (float) of the fired projectile
            item.summon =  true;                    //This item does Summon Damage
             
            //These attributes are for loading the item ingame
            item.height = 32;                       //The size of the height of the hitbox in pixels.
            item.useAnimation = 40;                 //How long the Weapon is used for.
            item.useStyle = 1;                      //Animation style: 1=overhead swing, 2=drinking, 3=stab, 4=hold up like life crystal, 5=staffs/guns
            item.useTime = 40;                      //How fast the Weapon is used.
            item.width = 32;                        //The size of the width of the hitbox in pixels.

            //These attributes give the weapon style
            item.damage = 10;                       //The damage stat for the Weapon.
            item.knockBack = 4f;                    //The knockback (float) stat of your Weapon.
            //item.mana = 0;                          //Amount of mana consumed on use
        }

        public override void AddRecipes() //Adding recipes
                                          // * This is where you add the recipe for the gun
        {
            ModRecipe recipe = new ModRecipe(mod);      //CRITICAL
            //recipe.AddIngredient(ItemID.DirtBlock, 1);
            //recipe.AddIngredient(ItemID.Wood, 1);
            //recipe.anyWood = true;
            //recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);                     //CRITICAL
            recipe.AddRecipe();                         //CRITICAL

            //This is a simple recipe. TemplateGun is craftable if the player has 1 dirt block and 1 wood block (of any type) near a workbench
        }


    }
}