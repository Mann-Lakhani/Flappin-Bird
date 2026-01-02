# Flappin-Bird

My very first game! A Flappy Bird clone built with Unity as a learning project to understand game development fundamentals.

## Play Now

**[Play Flappin-Bird Online](https://flappin-bird-f4f03.web.app)**

The game is live and playable in your browser! No downloads required.

## About the Game

Flappin-Bird is a classic endless runner game where you control a bird navigating through pipes. Tap or click to make the bird flap its wings and fly higher, but be careful not to hit the pipes or fall to the ground!

## Features

- Smooth bird flight mechanics with realistic physics
- Animated bird wings with flapping animation
- Procedurally spawned pipes with random heights
- Dynamic cloud system for atmospheric background
- Score tracking system
- Sound effects for wing flaps
- Main menu with game restart functionality
- Game over detection and restart capability

## Game Mechanics

- **Controls**: Click or tap to make the bird flap and gain altitude
- **Objective**: Navigate through gaps in the pipes without collision
- **Scoring**: Earn points by successfully passing through pipe gaps
- **Difficulty**: Constant challenge with randomly positioned pipes

## Technical Details

**Built with:**
- Unity Engine (Universal Render Pipeline)
- C# scripting
- Unity's 2D physics system
- Sprite animations

**Key Scripts:**
- `BirdScript.cs` - Handles bird movement and collision detection
- `PipeSpawner.cs` - Manages procedural pipe generation
- `PipeMoveScript.cs` - Controls pipe scrolling
- `LogicScript.cs` - Game state and score management
- `CloudSpawner.cs` & `CloudMoveScript.cs` - Background decoration system
- `MainMenuScript.cs` - Menu navigation

## Development Journey

This is my first game development project! I created Flappin-Bird to learn:
- Unity game engine basics
- 2D game physics and collision systems
- Object pooling and spawning mechanics
- Animation systems in Unity
- Game state management
- UI/UX in games

## How to Play

1. Clone this repository
2. Open the project in Unity (version compatible with URP)
3. Open the main scene from `Assets/Scenes/`
4. Press Play in the Unity Editor or build the game for your platform

## Assets

The game includes custom sprites for:
- Bird body and wing animations
- Pipe obstacles
- Cloud decorations

## Future Improvements

As I continue learning game development, I plan to add:
- High score system with local storage
- Different difficulty modes
- More visual effects and polish
- Mobile build optimization
- Additional sound effects and background music

## Credits

Developed by Mann Lakhani as a first game development project.

---

*Feel free to fork, learn from, or provide feedback on this project!*
