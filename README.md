# minigame
Game Title - Game Design Workshop SP24 - Heather DeRuyck

Description: 
  Play as a squid and accumulate points by temporarily stunning fish with ink and then eating them.

Controls: 
  Arrow keys for movement (up arrow to move up, down arrow to move down, left arrow to move left, and right arrow to move right) and space bar to shoot.

How to Play: 
  Swim around and shoot ink at fish to stun them. Move onto fish to eat and gain points before they swim away.

Dev Log: 
  -Stunning Fish: when an ink projectile hits a fish, it stops moving temporarily. Stunning a fish is the only way to be able to eat it.
  -Points: After stunning and eating fish, points are gained. This is tracked in the bottom right corner of the screen on the rock.
  -Fish Types: There are three types of fish, each has its own color, point value, swim speed, and amount of time it stays stunned before swimming away. Yellow fish are worth one point, swim the slowest, and stay stunned the longest. Green fish are worth two points, swim a bit faster, and stay stunned for a couple seconds fewer. Pink fish are worth three points, swim the fastest, and have the smallest window of time in which they remain stunned.

Assets:
  Player, fish, and ink projectiles are Unity primitives. Background is my own, drawn in Photoshop.
