# Monster-Chase-Game
## Description
This Unity game is an action-packed adventure where players have the ability to control a character on the run. Players must guide their character to escape enemies by running or jumping over enemies to stay alive. The game features intuitive controls, captivating animations, and an engaging user interface.

https://github.com/varshigak/Monster-Chase-Game/assets/142120820/aece3be5-d203-467a-806f-059e24349aa8
## Getting Started
* Unity 2021.3.13f1
* Download project and open in Unity.
* "Assets" > "Scenes" > "MainMenu"
* Press the Play button to start the game.
## Player Controls
* Move left: A or Left Arrow
* Move right: D or Right Arrow
* Jump: Spacebar
## Game Mechanics
### Player Movement
The player character is controlled using C# scripts. Rigidbody components provide realistic physics-based movement, while colliders ensure collision detection with the environment.
### Player Animations
Character animations are triggered through code, making use of Unity's Animator component. Animations include running, idle, and jumping.
### Player Jumping
A combination of physics and input handling enables fluid and responsive jumping with ground detection.
### Camera Follows Player
The camera follows the player's movement smoothly, providing a dynamic view of the game world. This is achieved by adjusting the camera's position based on the player's position.
### Enemy Mechanics
Enemies are spawned dynamically using a "Spawner" script. They feature animations and react to the player's presence. A "Collector" script ensures that when the player collides with an enemy, the player disappears from the scene.
### Main Menu and UI System
The main menu allows players to select one of two characters. Players have the option to restart the game or return to the main menu during gameplay.
