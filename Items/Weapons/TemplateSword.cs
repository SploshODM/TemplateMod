using Terraria.ID;
using Terraria.ModLoader;

namespace TemplateMod.Items.Weapons
    //namespace is the directory to where the source file AND sprite are located
{
	public class TemplateSword : ModItem
            //Set the in-code name for the item. Sprite must have a matching name
	{
		public override void SetStaticDefaults()
        {
            //ToolTip Strings
            string TT1 = "A basic sword with no special effects";
                //Can have multiple line in the tooltip. Set each line here, end with '\n' and concatenate them in the 'Tooltip.SetDefault' line

            //Defaults
            DisplayName.SetDefault("Template Sword");
                //The name of the item, as seen in game
            Tooltip.SetDefault(TT1);
                //Set the items tooltip here
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.WoodenSword);
            item.damage = 5;

            //***************************************************************************************************************
            //                                              ITEM ATTRIBUTE LIBRARY
            //***************************************************************************************************************
            /*
            item.accessory = false;                 //if the item an be equipped in the accessory slot
            item.ammo = AmmoID.None;                //The ID of the ammo class this item is part of
            item.autoReuse = false;                 //true = autoswing
            item.bait = 0;                          //Bait power of item
            item.buffTime = 0;                      //Duration of given buff
            item.bufftype = 0;                      //ID of buff given by the item. For multiple buffs, assign one buff here, then in ModItem.UseItem, call player.AddBuff(buffID, time)
            item.channel = true;                    //Sprite is visible while launched projectile is still active
            item.CloneDefaults(ItemID.TerraBlade)   //Copies the properties of another item
            item.consumable = false;                //if the item is used on use like potions/foods/summoning items
            item.createTile = -1;                   //What tile the item places when used. -1=no tile. (see item.placeStyle). createTile overridden by item.shoot
            item.createWall = -1;                   //what wall the item places when used. -1=no tile. (see item.placeStyle). createTile overridden by item.shoot
            item.crit = 0;                          //Crit strike chance. Player has base Crit Strike chance of 4%. Therefore item.crit = 0 means the item has 4% critical strike chance
            item.damage = -1;                       //The damage stat for the Weapon.
            item.defense = 0;                       //amount of defence the item provides when equipped
            item.expert = false;                    //if the Tooltip mentions this item is expert only
            item.fishingPole = 0;                   //Fishing power of item (for fishing rods)
            item.healLife = 0;                      //amount of health restored on use. To heal to max life use: [item.healLife = Main.player[item.owner].statLifeMax2;] - 1 for just health, 2 for health with buffs
            item.healMana = 0;                      //amount of mana restored on use
            item.height = 0;                        //The size of the height of the hitbox in pixels.
            item.holdStyle = 0;                     //0=dont hold, 1=torches/glowsticks, 2=holding up(breathing reed), 3=special (magical harp)
            item.knockBack = 0f;                    //The knockback (float) stat of your Weapon.
            item.mana = 0;                          //Amount of mana consumed on use
            item.material = false;                  //Tooltip mentions the item as in ingredient. Automatically assigned.
            item.maxStack = 1;                      //How high the item stacks in the inventory
            item.mech = false;                      //If the item shows wiring when held
            item.noMelee = false;                   //sprite does no damage (summon weapons)
            item.noUseGraphic = false;              //This defines if it does not use graphic
            item.notAmmo = false;                   //Tooltip says 'ammo', can go into ammo slots
            item.placeStyle = 0;                    //Style of the tile being placed (See item.createTile)
            item.potion = false;                    //causes and cannot be used during 'Potion Sickness'. Also can be used with the Quick heal hotkey
            item.questItem = false;                 //Tooltip mentions the item is a quest item
            item.rare = 0;                          //The color the title of your Weapon when hovering over it ingame. 0 & 1 will burn in lava (-1: Gray, 0: White, 1: Blue, 2: Green, 3: Orange, 4: Light Red, 5: Pink, 6: Light Purple, 7: Lime, 8: Yellow, 9: Cyan, 10: Red, 11: Purple, 12: Rainbow)                   
            item.reuseDelay = 0;                    //Delay added after useAnimation timer, the player cannot use the item until after this cooldown
            item.scale = 1f;                        //Size multiplier of items sprite
            item.shoot = 0;                         //This defines what type of projectile this weapon will shoot. Vanilla = [item.shoot = <ProjectileID>]. Modded = [item.shoot = mod.ProjectileType("<ProjectileName>")]
            item.shootSpeed = 0f;                   //Speed (float) of the fired projectile
            item.useAmmo = AmmoID.None;             //The ID of the ammo this weapon uses
            item.useAnimation = 100;                //How long the Weapon is used for.
            item.useStyle = 0;                      //Animation style: 1=overhead swing, 2=drinking, 3=stab, 4=hold up like life crystal, 5=staffs/guns
            item.UseSound = null;                   //What sounds plays when item is used. Use this property as:[item.UseSound = SoundID.Item1;]. See 'Sound Library below'
            item.useTime = 100;                     //How fast the Weapon is used.
            item.useTurn = false;                   //Can the player turn during items' animation
            item.value = 0;                         //Value of the item when bought, in PPGGSSCC. Sell price = 1/5th of buy price
            item.width = 0;                         //The size of the width of the hitbox in pixels.
            ---------------------------------------------------------------------------------------------------------------
             Use ONE of the following properties to determine what damage class the item will do
            ---------------------------------------------------------------------------------------------------------------
            item.magic = false;                     //This item does Magic Damage
            item.melee = false;                     //This item does Melee Damage
            item.ranged = false;                    //This item does Ranged Damage
            item.summon = false;                    //This item does Summon Damage
            item.thrown = false;                    //This item does Throwing Damage
            ---------------------------------------------------------------------------------------------------------------
             Use the following properties to determine the item as a axe/hammer/pick and what power each property has
            ---------------------------------------------------------------------------------------------------------------
            item.axe = 0;                           //This item is an axe, with 0 power. Axe power = (item.axe = 0) * 5
            item.pick = 0;                          //This item is a pick, with 0 power
            item.hammer = 0;                        //This item is a hammer, with 0 power
            ---------------------------------------------------------------------------------------------------------------
             Use one of the following properties to show the item on the player if equipped in an accessory/armor slot
            ---------------------------------------------------------------------------------------------------------------
            \item.backSlot = -1;
            \item.balloonSlot = -1;
            \item.bodySlot = -1;
            \item.faceSlot = -1;
            \item.frontSlot = -1;
            \item.handOffslot = -1;
            \item.handOnslot = -1;
            \item.headSlot = -1;
            \item.legSlot = -1;
            \item.neckSlot = -1;
            \item.shieldSlot = -1;
            \item.shoeSlot = -1;
            \item.waistSlot = -1;
            \item.wingSlot = -1;
            ---------------------------------------------------------------------------------------------------------------
            */

            //***************************************************************************************************************
            //                                                  SOUND LIBRARY
            //***************************************************************************************************************
            //1. General Using Sound(for melee and most thrown stuff)
            //2. Mushroom
            //3. Potion Use
            //4. Fallen Star, Life Crystal
            //5. Arrow, Blowpipe Shooting Sound
            //6. Magic Mirror
            //7. Lower version of general using sound (deep swish)
            //8. Demon Scythe, Dirt Rod, Orb of Light, Vilethorn
            //9. Crystal Storm, Magic Missile, Star Cannon, Starfury
            //10. Harpoon
            //11. Guns
            //12. Laser Rifle, Space Gun
            //13. Water Spray
            //14. Bomb Explosion
            //15. Phaseblades
            //16. Whoopie Cushion Fart
            //17. Stinger Dart?
            //18. Duplicate of #1
            //19. Throwing sound(higher-pitched general use sound)
            //20. Cursed Flames, Flamelash, Flower of Fire
            //21. Water Bolt
            //22. Motorized Tools(Drill, Chainsaw, Hamdrax loop this sound while being used)
            //23. Motorized Tools Activation(plays with #22 at the start, but does not loop with it)
            //24. Spectre Boots sound
            //25. Fairy Bell
            //26. Harp
            //27. Coin Clink (Crystal Shard sound when broken)
            //28. Ice Rod, Rainbow Rod
            //29. Mana Crystal
            //30. Ice Rod's Ice Block appearance sound
            //31. Clockwork Assault Rifle
            //32. Angel Wings / Demon Wings flapping sound
            //33. Death Laser firing sound(Red lasers from the Destroyer and second-form Retinazer)
            //34. Flamethrower
            //35. Bell
            //36. Shotgun
            //37. Anvil clink
        }

        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ItemID.DirtBlock, 10);
            //recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
