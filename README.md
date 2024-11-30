# Unity Week 4: Prefabs and Colliders - Upgrade

## Credits : Maoz Grossman and Erel Segal-Halevi  
**Inspired by the Udemy course**: *The Ultimate Guide to Game Development with Unity 2019*, by Jonathan Weinberger

## Overview

This project extends the concepts introduced in Week 2 of the course, focusing on Prefabs and Colliders in Unity. The primary additions in this upgrade are related to resizing buffers and border collision mechanics that influence player movement and interaction with the environment.

### Code Samples

Code for this upgrade can be found in the `02` folder of the repository.

---

## Features Added

### 1. Resize Buffers

**Description**:  
Two types of resize buffers have been added to the game, affecting the player's scale when interacted with:

- **Good Resize (Shrinking)**:  
  Reduces the player's height and width by a factor of 2, making them smaller.

- **Bad Resize (Enlargement)**:  
  Increases the player's height and width by a factor of 2, making them larger.

**Scripts Involved**:
- **`Resize.cs`** (Located in `Scripts/levels`):  
  Controls the behavior of resizing buffers based on specific tags. Depending on whether the buffer is good or bad, the player's scale is modified accordingly.

- **`RandomSpawner.cs`** (Located in `Scripts/spawners`):  
  This script spawns the buffers randomly within a specified radius from the player. The spawning locations are calculated based on the camera’s view boundaries.

**Implementation**:
- The **shrinking buffer** is introduced in **Level 1**.
- Both **shrinking and enlargement buffers** are introduced in **Level 2**.

---

### 2. Border Collision

**Description**:  
The **Border_Collision** script ensures that the player cannot pass through the top and bottom edges of the map. Additionally, it implements continuous horizontal movement, meaning that when the player crosses the left or right edge of the screen, they reappear on the opposite side (left-right looping).

**Scripts Involved**:
- **`Border_Collision.cs`** (Located in `Scripts/collisions`):  
  Manages collision behavior with map borders. The script restricts the player from moving past the top and bottom borders and enables continuous movement across the left and right edges of the map.

**Features**:
- **Top and Bottom Border Restrictions**: Prevents the player from passing the top and bottom edges of the screen.
- **Left-Right Continuous Movement**: When the player crosses the left border, they continue from the right side, and vice versa.

---

## Instructions for Use

### How to Trigger Resizing Buffers:
1. **Shrinking Buffer**: Found in Level 1. When the player comes into contact with the shrinking buffer, their size is halved in both height and width.
2. **Enlarging Buffer**: Found in Level 2. When the player interacts with the enlarging buffer, their size is doubled in both height and width.

### How to Use Border Collision:
- The **Border_Collision** script handles player movement and interactions with map boundaries. 
- Ensure that your map's boundaries are correctly set, as the script uses these bounds to apply restrictions and looping behavior.

### How to Spawn Buffers:
- Buffers are spawned randomly around the player based on the camera's boundaries using the `RandomSpawner.cs` script. The spawn locations respect a predefined radius distance from the player.

---

## Itch.io

try this game : [Click here!](https://barmud.itch.io/assignment3-spaceship)
