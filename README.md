

[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/uTVZkEVg)
# Scape Cave

## Summary

  - [Description](#description)
  - [Prerequisites](#prerequisites)
  - [How to Play](#how-to-play)
  - [Repository Organization](#repository-organization)
  - [Authors](#authors)
  - [License](#license)
  


## Description

Scape Cave is a One Button Game about a mouse in a cave that has to eat as much cheese as possible. There are snakes that can eat the mouse. Everytime the mouse moves faster and appear more snakes, so it's more difficult. The mouse can pass through the cave, but the player has to be careful if behind a rock is a snake.

It was made for a course in the Hochschule Mainz to learn about Unity.



## Prerequisites

This game was created with Unity 2022.3.11f1, so it needs to install this Unity editor version.
Here's the link to install Unity editor: https://unity.com/releases/editor/whats-new/2022.3.11
Also is required to install Unity Hub: https://unity.com/de/unity-hub



## How to Play
Open the scene "LandGame". In Unity there is a "Play" Button, press it and the game will load. Once beeing in the game window, press the "Space" key to play.



## Repository Organization
Into the folder "Assets" there are seven folders (Materials, Prefabs, Quirky Series Ultimate, Scenes, Scripts, Sounds, TextMesh Pro).


### Materials
Some materials for the objects. The materials from the animals are in Quirky Series Ultimate.


### Prefabs
There is the original object for the cheese.


### Quirky Series Ultimate
Into this folder are more other folders, because there are the animals (the snake and the mouse) with all their materials, animations and textures.


### Scenes
There is the Scene "LandGame", where the game is, and a "SampleScene" if it needs to do something more.


### Scripts
Into this folder are eight codes (GameOver, InvokeCheese, InvokeSnakes, LogicScript, MovementInTheCave, MovementMouse, MovementSnake and Score) to give the behavior to the game objects.


#### GameOver
Script for the snakes to eat the mouse using OnCollisionEnter, destroy GameObject and calling the gameOver behavior from the LogicScript script.


#### InvokeCheese
Script to invoke a cheese after a determined time and repeat it. 


#### InvokeSnakes
Script to invoke a snake after a determined time and repeat it.


#### LogicScript
Script with the gameOver and Restart behavior.


#### MovementInTheCave
Script for the mouse, camera and score Z axis movement. 


#### MovementMouse
Script for the x axis movement of the mouse. Using a GetKey, the mouse can move to the right everytime "Space" is pressed. Without the key pressed the mouse moves to the left.


#### MovementSnake
Script for the z axis movement of the snakes to move them against of the mouse direction. 


#### Score
Script for the mouse to count the number of cheeses eaten. With a OnTriggerEnter the cheese is destroy when the mouse touches it and the counter adds one.


### Sounds
This folder contains all the sound effects and music.


### TextMesh Pro
This is a package with tools for 2D and 3D textes.



## Authors

  - **Daniela Masihy Kowoll** - *Designed the game and developed it* -



## License
This project is licensed under the [CC0 1.0 Universal](LICENSE.md)
Creative Commons License - see the [LICENSE.md](LICENSE.md) file for
details

### Pixabay Content

- **Sound effects and Background Music:**
  - **License:** [Pixabay Content License](https://pixabay.com/es/service/license-summary/)
  - **License Link:** [Pixabay Content License](https://pixabay.com/es/service/license-summary/)
