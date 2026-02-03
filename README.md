# HW4
## Devlog
The model-view-control pattern decouples the Player code by focusing the Player class's function on just the game logic of the player gameObject, such as collisions with either
the pipes or the area past them triggering a point reward, instead of also on game aesthetics like sound effects or updating UI. Events are used/invoked by the class when the players game logic needs to influence
the previously mentioned other elements in the game and the use of them requires little lines. A singleton further contributes to the decoupling of the overall code and pattern by making the Player class more easily accessible without stored references in the other
elements' classes.

The classes defining the view aspect of the model-view-control pattern in this project are primarily
the UI class and the audio system class. The GameController class managing pipe spawning 
and randomized height as well as the player class controlling player flight height are other classes that partially make up the view part because of their
relationships with their respective sprites' visual results.

The classes defining the control side of the pattern are the GameController class, Locator class, Player class, and Pipe class because of their focus on game logic such as spawning, desepawning, movement, points, and countdowns. 

Once more, both parts of the pattern rely on their reception of Player class invoked events for changes or use so that they are seperate from it and thus create less density
in the Player class's code.



## Open-Source Assets
- [Sound effects Pack 2](https://phoenix1291.itch.io/sound-effects-pack-2) - point and end game sound effects
- [Whoosh Sound Effects](https://tagirijus.itch.io/whoosh-sound-effects) - flying sound effect
- [Industrial Pipe Platformer Tileset](https://wwolf-w.itch.io/industrial-pipe-platformer-tileset) - tile sprite
- [Bird flying pixel art animation](https://ankousse26.itch.io/bird-flying-pixel-art-animation-free) - bird sprite and animation