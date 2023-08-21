# Game Design Document - Repentance

### Table of contents
- [Game Overview](#1-game-overview)
- [Story and Narrative](#2-story-and-narrative)
- [Game Mechanics](#3-game-mechanics)
- [Levels and World Design](#4-levels-and-world-design)
- [Art and Audio](#5-art-and-audio)
- [User Interface](#6-user-interface)
- [Technology and Tools](#7-technology-and-tools)
- [Team Communication, Timelines and Task Assignment](#8-team-communication-timelines-and-task-assignment)
- [Possible Challenges](#9-possible-challenges)

## 1. Game Overview

### 1.1 Concept
Repentance is a single-player survival game. Trapped in a maze with vengeful monsters that were once victims of the player’s family, the player’s primary objective is to stay alive for 5 minutes. At the same time, the player’s role is to confront their family’s dark past and make decisions that could shape their own fate.

### 1.2 Genre
Repentance is a survival horror game. The player is challenged to survive for 5 minutes while trapped in the maze by either hiding or running from the monsters. The game sets up suspense by making use of horror game elements such as spine-chilling graphics, dark environments, unexpected attacks and eerie sound effects.

<p align="center">
    <img src="Images/Slender.png" width=300 height=150>
</p>

[Horror Sound Effect](./Audio/horror-sound-effect.mp3)

[Monster Growl](./Audio/monster-growl.mp3)

### 1.3 Target Audience
Set in a maze with horror elements, the game is targeted at players who are drawn to experiencing thrill in a controlled environment. Additionally, the 5-minute time constraint on the game makes it suitable for players who prefer or can only afford to play in short bursts.

### 1.4 Unique Selling Points

#### 1.4.1 Compelling Storyline
Repentance follows a storyline that progressively unfolds as the game scales in difficulty. The player’s role is not only to survive, but also to uncover the gruesome truth about their family and face the consequences of their past actions. The intertwining of survival and story progression creates an immersive experience that keeps players emotionally engaged.

#### 1.4.2 Appealing Aesthetic
Inspired by the dystopian science fiction film ‘Maze Runner’ (left), the game features a pixelated maze-like environment where the walls are overgrown with foliage (right). The pixelated graphics style creates a nostalgic retro feel while the foliage, just as it conceals the features of the maze, symbolizes the hidden secrets and dangers that lurk in the player’s world.

<p align="center">
    <img src="Images/Maze_Runner.png" width=300 height=150>
    <img src="Images/Pixelated_Maze.png" width=300 height=150>
</p>

#### 1.4.3 Unique Mechanics
Repentance includes player stamina as a gameplay mechanic that reflects a realistic physical limitation of the player’s character and heightens the challenge of the game. Stamina allows the player to run away from the monsters and gradually replenishes when the player walks. Having to balance multiple resources adds depth to the gameplay and encourages the player to think strategically.

<p align="center">
    <img src="Images/Game_UI.png" width=300 height=150>
</p>

## 2. Story and Narrative

### 2.1 Backstory

Our playable character by some stroke of misfortune has found themselves in front of a strange structure. They ponder the thought, as towering walls of broken stone filled with dilapidated foliage surround them. They move deeper into the maze lost in thoughts of confusion and regret. They come upon a lone singular house in the centre.

- The main character had received a letter detailed in their parents will, this was to be delivered to them upon their mother/father’s passing
- The letter described a location containing a family heirloom 
- The location was said to be the old location of the family home, found deep within the countryside
- The town supposedly no longer exists, but the letter states otherwise and insists that heirloom still resides there. 
- The player tracks the location confused as to why their parents desperately insisted that they obtain the heirloom 
- The location can be described as desolate, however the deeper they walk into the town they face large towering walls and an entrance to what appears to be a labyrinth

<p align="center">
    <img src="Images/gamedia2.png" width=300>
    <img src="Images/gamedia1.png" width=300>
</p>

### 2.2 Additional Information / Story

- Your family has a dark history  
- As you go through the labyrinth you may come across information that pertains to what happened
- The Main character's family commited crimes against another family (Murder)
- The Heirloom is an old knife/ weapon
- Appease the deceased (This can be set as a optional objective which you will have to read / actively search for)

### 2.3 Characters

- Main Character  : Brave but clueless, they understand that the heirloom is of great importance, they also hold great curiosity towards the strange location as well as towards the heirloom.
- Monster / Enemy / Ghost / Entity : There are three monsters, these represent the victim family: Parents and Child.
  - Parent :  Chases if the player is too close
  - Parent : Teleports randomly
  - Child : Hide and Seek, The player needs to hide
- NPC : These can be encountered in the maze, they can either help or increase the difficulty of the game.


## 3. Game Mechanics

### 3.1 Player Perspective
First-person perspective where the player’s view is defined by the camera. The player is able to move the camera to create the impression that they are looking around the game. The player’s character is largely not visible on the screen. Only the arms will be seen to further enhance the impression of a first-person perspective. This perspective choice enhances the horror genre of the game as the player becomes the character and the limited field of view intensifies the uncertainty of the maze.

<p align="center">
    <img src="Images/first-person-game-turn.gif" width=300 height=150>
    <img src="Images/game-first-person-shooting.gif" width=300 height=150>
</p>

#### 3.1.1 The player's arms

<p align="center">
    <img src="Images/Flashlight_Equip_Animation.gif" width=300 height=150>
    <img src="Images/player_arms.webp" width=300 height=150>
</p>

### 3.2 Controls

#### 3.2.1 Basic Controls
- W -> forward
- A -> left
- S -> backward
- D -> right
- Mouse -> camera

#### 3.2.2 Other 
- E -> interact with game objects
- shift + W/A/S/D -> sprint
- F -> flashlight

### 3.3 Progression
The player becomes trapped within the maze when the game begins and they must survive 5 minutes until the sun rises in order to win.
The maze is broken into three main sections each containing different enemies. Each enemy has a different attack style and the player must avoid these enemies as one attack from any enemy will kill the player. 
Throughout the maze the player will find tombstones that belong to the enemy. The player will have the opportunity to interact with the tombstone and destroy it. Destroying a tombstone will reveal part of the game's backstory, however it will anger the ghost and make the game more difficult for the player. The player will also come across different NPCs throughout the maze. The player can interact with the NPCs in the form of a conversation with multiple options that will have different impacts on the difficulty of the game. The game may become easier or harder for the player depending on the choices they make.

### 3.4 Gameplay Mechanics
The player is able to walk (using WASD) or sprint (using WASD + shift). The sprint capability is limited by a stamina bar that is depleted and slowly refilled. Additionally, the player is able to use the F key to equip a flashlight in areas of the maze that are dark too dark for the player to be able to see in. The player will come across different tombstones and NPCs throughout the maze that they can interact with using the E key.
The limitation of the sprint ability, along with the use of different light levels within the maze will make the game more challenging for the player.


## 4. Levels and World Design

### 4.1 Game World 

The world seen by the player is a maze with an aesthetic style inspired by the Maze Runner. It is 3D and will be displayed on a single screen. Only one level will be available, however, the maze will be randomly generated and change each time the game is played. This allows the game to be replayed multiple times. The player starts in the centre of the maze and will have to navigate through the maze by exploring and avoiding ghosts. Hints may be available to the player if they find them in the maze, however, no map/minimap will be available as it would defeat the purpose of the maze. 

<p align="center">
  <img src="Images/MazeDiagram.png" width=400>
</p>


### 4.2 Objects 

- Tombstones. Players can destroy tombstones or interact with them in some way to unlock lore. 
- Heirloom. Looks like an old knife/ weapon. 
- Flashlight. Starts in the player’s inventory. Player can turn it on or off.
- The player can collect other items such as weapons to slow down the monsters and prevent them from chasing the player.

<p align="center">
  <img src="Images/PlayerHoldingWeapon.gif" width=300 height=150>
</p>


### 4.3 Physics 

- Players will collide with the walls of the maze.
- Player will accelerate up to a certain speed when they sprint. 
- Players will collide with tombstones.



## 5. Art and Audio

### 5.1 Art Style  
- Retro Style, Playstation 1 Graphics
- Use of pixelated art
- Dark, sinister, uncomforting, horrifying
<p align="center">
    <img src="Images/ps1_horror.jfif" width="400">
</p>

Overall the intention is to implement lower quality graphics. As stylistically, this may allow additional details to be filled in by the player’s mind. In addition, lowering the quality may indicate some level of detachment from reality, in this case the intention is to further exacerbate the uncaniness of the situation, something that appears to be similar yet also different. Furthermore, the art style allows for the natural depiction of hard edges compared to smoothness that may commonly be associated with higher graphic quality. This reliance on hard edges in graphics may subconciously alert the player, keeping them uncomfortable and on edge.

<p align="center">
    <img src="Images/siren_head.gif" width="400"> <img src="Images/baldis_basic.png" width="400">
</p>

### 5.2 Audio 

- Exudes a Sombre atmosphere
- Character Sounds : Footsteps , Flashlight, Breathing, Item interactions, Monster Sounds
- Music: Quiet / Simple Ambience, Builds up when progressing, Monster encounter is intense, dire, alarming.

### 5.3 Sound Design 

In terms of sound design, sounds should likewise feel lower in quality and granular texture. This is in order to complement the visual aspect of the game thematically. Sounds feel as if they’re passing through a radio. Sounds in the game such as footsteps, doors and breathing shouldn’t feel pleasant to the ear, but should feel deliberate and noticeable. The player's actions in the game will take up valuable time and the sounds in the game should reflect these actions.

### 5.4 Music 

The music is rather simplistic tonally, typically consisting of low tones. This may build into something more intense as the time progresses. Additionally, intense music may be included for when the monster has been encountered with the player or if the monster is engaged in pursuing the player.

Stylistic examples of intended Game music: 

[Roaming](./Audio/atmosphere.wav) 

[Ambience](./Audio/sense_of_dread.wav)

### 5.5 Assets 

In terms of utilising pre built assets, they will typically be sourced from the Unity Store, as a base line, this may include 3d models but edited over with custom textures in order to better suit the theme of the game. 

- [Enemy/Monster](https://assetstore.unity.com/packages/3d/characters/humanoids/zombie-30232) 
- [Enemy/Monster](https://assetstore.unity.com/packages/3d/characters/ghoul-zombie-114531) 
- [Main Character](https://assetstore.unity.com/packages/3d/characters/humanoids/humans/adventure-character-201384)
- [Texture](https://assetstore.unity.com/packages/2d/textures-materials/stone/mc-dirt-stone-wall-free-sample-178284) 

## 6. User Interface

### 6.1 Start Screens
<p align="center">
    <img src="Images/Main_Menu.png" width=400>
    <img src="Images/Options.png" width=400>
</p>

### 6.2 In-Game Screens
<p align="center">
    <img src="Images/Game_UI.png" width=400>
    <img src="Images/Game_Menu.png" width=400>
</p>

## 7. Technology and Tools

- GitHub (Version Control)
- Unity (Game Engine)
- Figma (UI Design) 
- Reaper (DAW)
- Aseprite (Pixel Art Software)
- FMod (Audio Middleware)
- Adobe Photoshop (Photo Editing Software)

## 8. Team Communication, Timelines and Task Assignment


- Messenger and Zoom (Discussions)
- Trello (Task Management)
- Google Docs (Documentation and Planning)

### 8.1 The project has been broken into four main parts:
- World design, audio and maze generation
- Character and camera
- Menus, UI, cutscenes and storyline progression
- Enemies and character interactions 

### 8.2 Timeline
- Player movement (3/09)
- Basic maze (3/09)
- Enemy #1 (3/09)
- Main menu (3/09)
- Tombstones
- start location
- Enemy #2
- Enemy #3
- Maze generation
- Difficulty selection
- Interactable items (weapons, heirloom etc.) + inventory 

## 9. Possible Challenges

### 9.1 Time Constraint
Problem: Creating a detailed story that can be easily understood by the player within the 5-minute time frame.

Solution:
- Avoid including excessive backstory.
- Divide the story into segments and reveal the storyline naturally through character interactions.

### 9.2 Maze Generation
Problem: Creating a maze that can be mostly explored within the time limit but is also not too simple.

Solution:
- Playtest the maze with a variety of players to gauge their experience and adjust the maze’s complexity based on the feedback received.
- Design the maze with multiple pathways and dead ends to encourage player exploration without making it overly complicated.

### 9.3 Graphics & Audio
Problem: Implementation of horror elements that can effectively set up tension in the game and instill fear in the player.

Solution: 
- Make use of lighting techniques to create shadows and darkness in order to limit player visibility and create a sense of uncertainty.
- Incorporate eerie sound effects such as whispers and echoing footsteps to keep players feeling unsettled.

### 9.4 Narrative
Problem: Integration of story elements into the gameplay.

Solution: 
- Make use of cutscenes to convey key points of the storyline.
- Implement dialogue systems that enable players to converse with NPCs and choices made during these conversations can influence the outcome of the story.

### 9.5 Gameplay
Problem: Balancing difficulty in order to ensure players of all skill levels can enjoy the game.

Solution:
- Have different difficulty levels available.
- The game starts at an easy difficulty setting and progressively becomes harder. This eases the player into the gameplay.


