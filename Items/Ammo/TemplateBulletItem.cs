using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TemplateMod.Items.Ammo
{
    public class TemplateBulletItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Template Bullet");    //This sets the 'In Game Name' of your item, the name players see when hovering their cursor over the item
            Tooltip.SetDefault("This is a basic bullet, with no special effects");//This is the tooltip (description) of the item when hovering over it in the inventory
        }

        public override void SetDefaults()
        {
            //These properties make the item classed as ammo
            item.ammo = mod.ItemType("TemplateBulletItem");         //The ID of the ammo class this item is part of
            item.consumable = true;                 //if the item is used on use like potions/foods/summoning items
            item.maxStack = 999;                    //How high the item stacks in the inventory
            item.notAmmo = false;                   //Tooltip says 'ammo', can go into ammo slots
            item.ranged = true;                     //This item does Ranged Damage
            //item.shoot = mod.ProjectileType("ExampleBulletAProjectile");
            item.shoot = 14;
            //item.ammo = mod.ItemType("ExampleBulletAItem"); //Tells game that the type of ammo is of ExampleBulletA

            //Thse allow the item to be loaded in game
            item.height = 10;                       //The size of the height of the hitbox in pixels.
            item.scale = 1f;                        //Size multiplier of items sprite
            item.width = 12;                        //The size of the width of the hitbox in pixels.

            //These properties give the item style
            item.crit = 6;                          //Crit strike chance. Player has base Crit Strike chance of 4%. Therefore item.crit = 0 means the item has 4% critical strike chance
            item.damage = 10;                       //The damage stat for the Weapon.
            item.value = 5;                         //Value of the item when bought, in PPGGSSCC. Sell price = 1/5th of buy price

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}
