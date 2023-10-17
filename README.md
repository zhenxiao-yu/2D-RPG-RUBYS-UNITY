# Rubys-2D-Adventure-Assignment1

Author: ZhenXiao Yu (251088539)

Class: CS4482A

Tutorial Resource Link: https://learn.unity.com/project/ruby-s-2d-rpg?uv=2020.3

Completed up to Tutorial: "Cinemachine"



##### Modifications: 

- Added Gold Collectible (with animation), ruby can now walk around and collect gold of various values. The total is displayed at top right conner.
- Added New Enemy Type: Zombie; This enemy will walk around and randomly change directions every 1 - 5 seconds, but also chases the player if the player is close enough. If Player runs away from a zombie's range then the zombie will return to wandering state. Ruby can kill zombies using her cog projectiles.
- Added Chests; Chests has a specific HP value (default 3), Ruby must use projectiles to shoot at chest to decrease the chest's HP. Once chest is broken, items (i.e Gold, Power ups, Zombies) will be instantiated at chest's location. Chest will also blink when hit projectile to signal that it's HP is decreasing. 
- Added New Obstacle: Spinning Laser trap; the Spinning trap will damage both the player and zombie upon collision. The speed, rotation and length of the traps are configurable through the inspector. 
- Added Portals (drain cover): Player can now teleport to different areas of the map by stepping onto portals. A pair of portals have the same color, so red portal will lead player to another corresponding red portal. I added two sets of portals --  red and green in my game. 
- Added Spawners: Zombies will randomly spawn out of caves between a minimum and maximum time value. I place two spawners, one to the left of player spawn, the other to the right of the spawn. They have different spawning frequencies;

