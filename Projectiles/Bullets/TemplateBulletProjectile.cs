using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace TemplateMod.Projectiles.Bullets
{
    public class TemplateBulletProjectile : ModProjectile
        // - The in code name. Must match the item that shoots this projectile on the attribute item.shoot
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Template Bullet");
                // - Note that the only time it is displayed ingame is when it kills a player, when hovered over and written in the death message

        }

        public override void SetDefaults()
        {
            //These attributes make the projectile a bullet
            projectile.aiStyle = 0;                         //The behavior of this projectile while it exists in the world. (Refer to aiStyle Library)
            projectile.friendly = true;                     //Whether this projectile is considered friendly, meaning it will not harm players and NPCs marked as friendly.
            projectile.hostile = false;                     //Whether this projectile is considered hostile, meaning it will harm players and NPCs marked as friendly.
            projectile.ranged = true;                       //This projectile does range damage

            //These attributes loads the projectile in game
            projectile.height = 10;                         //Height of projectile in pixels
            projectile.scale = 1;                           //A multiplier for how large to draw this projectile.
            projectile.timeLeft = 600;                      //The time in frames before this projectile disappears. 
            projectile.width = 12;                          //Width of projectile in pixels

            //These attributes give the projectile style
            projectile.knockBack = 0;                       //knockback of the projectile. float?
        }

        // - No recipe needed for projectiles
    }
}