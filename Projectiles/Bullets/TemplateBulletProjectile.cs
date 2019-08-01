using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;

namespace TemplateMod.Projectiles.Bullets
{
    public class TemplateBulletProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Template Bullet");
                // - Note that the only time it is displayed ingame is when it kills a player, when hovered over and written in the death message

        }
        public override void SetDefaults()
        {
            /*
            projectile.width = 36; //Set the hitbox width
            projectile.height = 36; //Set the hitbox height
            projectile.timeLeft = 60; //The amount of time the projectile is alive for
            projectile.penetrate = 1; //Tells the game how many enemies it can hit before being destroyed
            projectile.friendly = true; //Tells the game whether it is friendly to players/friendly npcs or not
            projectile.hostile = false; //Tells the game whether it is hostile to players or not
            projectile.tileCollide = true; //Tells the game whether or not it can collide with a tile
            projectile.ignoreWater = true; //Tells the game whether or not projectile will be affected by water
            projectile.ranged = true; //Tells the game whether it is a ranged projectile or not
            projectile.aiStyle = 0; //How the projectile works, this is no AI, it just goes a straight path
            */

            //These attributes make the projectile a bullet
			//aiType = ProjectileID.Bullet;           `		//Act exactly like default Bullet
            projectile.aiStyle = 0;                         //The behavior of this projectile while it exists in the world. (Refer to aiStyle Library)
            projectile.friendly = true;                     //Whether this projectile is considered friendly, meaning it will not harm players and NPCs marked as friendly.
            projectile.hostile = false;                     //Whether this projectile is considered hostile, meaning it will harm players and NPCs marked as friendly.
            projectile.ranged = true;                       //This projectile does range damage

            //These attributes loads the projectile in game
            projectile.height = 10;                         //Height of projectile in pixels
            projectile.scale = 1;                           //A multiplier for how large to draw this projectile.
            projectile.timeLeft = 600;                     //The time in frames before this projectile disappears. 
            projectile.width = 12;                          //Width of projectile in pixels

            //These attributes give the projectile style
            //projectile.extraUpdates = 0;                    //Set to above 0 if you want the projectile to update multiple time in a frame
            projectile.knockBack = 0;                       //knockback of the projectile. float?

			/*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			//													PROJECTILE.AISTYLE LIBRARY
			///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
			0 = Bullet Style. Projectile isnt affected by gravity
			1 = Arrow Style. Projectile IS affected by gravity
			2 = Thrown style. Used for Bones, knives and shuriken
			3 = Boomerang. Projectile returns to the player
			4 = Progressive Fading. used for Vilethorn
			5 = Falling Star Effect. Projectile spins and is surrounded by sparkles
			6 = Powder effect. Used for purification powder, vile powder
			7 = Grapple. Projectile attaches to surfaces
			8 = Magic Bounce Effect. Projectile bounces. bonucing is 'springier' than #14 and #16
			9 = Controlled Bolt. Follows the cursor until released, then flies in direction last moved
			10 = Falling block effect. Projectile acts like falling sand.
			11 = Follow effect. Projectile follows player. Used for pets and minons
			12 = Water stream effect. Used for aqua scepter
			13 = Harpoon effect. Used by Harpoon
			14 = Bounce effect. Projectile is thrown, and then falls and bounces. Used by Glowstick, spiky ball
			15 = Flail effect. Used by Ball o' Hurt, Blue Moon
			16 = Bounce/Explode effect. Projectile is thrown then falls and bounces. Used by Grenade, Dynamite
			17 = Stationary. Used for Tombstone
			18 = Exponential Acceleration. Projectile accelerates over time. Projectile also spins and has dark sparkles. Used by Demon Scythe, Death Sickle
			19 = Polearm effect. Projectile extends a small distance from the player
			20 = Motorized Tool Positioning. Used by Chainsaws and Drills, Hamdrax
			21 = No gravity effect. Projectile bounces off of walls and emits purple particle effect. 
			22 = Unknown. Used for ice block
			23 = Similar to #12. Drops dust. Used by Eye Fire and Flames
			24 = Shards. Projectile wiggles in a set direction. Used by Crystal Storm, Crystal Shards
			25 = Unknown. Used by Boulders
			26 = Bunny Effect. Used by Pet Bunny

			All Info, reference and description copied from: https://tconfig.fandom.com/wiki/List_of_Projectile_AI_Styles
			/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/

        }
    }
}