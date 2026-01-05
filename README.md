# 🏂 Snowboarder Game

<div align="center">
  
![Unity](https://img.shields.io/badge/Unity-2021.3%2B-000000?logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?logo=csharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-2D%20Side--scrolling-blue)
![Status](https://img.shields.io/badge/Status-Complete-brightgreen)

**A fast-paced 2D snowboarding adventure built with Unity!**

</div>

## 🎮 Gameplay Preview

<div align="center">
 
  <p><em>Master the slopes with precise controls and dynamic mechanics!</em></p>
</div>

## 📖 Overview

**Snowboarder** is an exhilarating side-scrolling jumping game where players navigate challenging mountain slopes using smooth movement, rotation control, and strategic speed boosts. Built entirely in Unity with custom sprite-based assets, the game offers a satisfying physics-based experience with visually appealing particle effects and responsive gameplay mechanics.

## ✨ Features

### 🎯 **Core Gameplay**
- **Intuitive Controls**: Simple yet deep movement system
- **Rotation Mechanics**: Full 360° rotation control in mid-air
- **Speed Boost System**: Strategic acceleration mechanics
- **Jump Physics**: Realistic arc-based jumping with momentum

### 🎨 **Visual & Audio**
- **Sprite Shape Terrain**: Dynamically generated slopes using Unity's Sprite Shape tool
- **Particle Effects**: Snow spray on landing, crash effects, and environmental particles
- **Dynamic Lighting**: Simple 2D lighting for depth and atmosphere
- **Visual Feedback**: Screen shake, camera effects, and hit indicators

### ⚙️ **Technical Systems**
- **Crash Detection**: Collision system with appropriate feedback
- **Finish Line System**: Level completion triggers with restart functionality
- **Progression Tracking**: Basic level completion tracking
- **Physics-Based Movement**: Realistic snowboarding physics simulation

### 🎲 **Game Mechanics**
- **Score System**: Points for tricks, distance, and speed
- **Combo Multipliers**: Chain jumps for higher scores
- **Obstacle Course**: Variety of jumps, gaps, and hazards
- **Time Challenge**: Optional time-based scoring

## 🕹️ Controls

| Action | PC Controls | Gamepad |
|--------|-------------|---------|
| **Move Left/Right** | A/D or ←/→ | Left Stick |
| **Jump** | Spacebar | A Button |
| **Rotate (in air)** | Q/E or Mouse | Right Stick |
| **Speed Boost** | Left Shift | Right Trigger |
| **Pause** | Escape | Start Button |

## 🚀 Getting Started

### Prerequisites
- **Unity 2021.3 LTS** or newer
- Basic understanding of Unity Editor

### Installation
1. **Clone or Download** the repository
   ```bash
   git clone https://github.com/yourusername/snowboarder-game.git
   ```
2. **Open in Unity**
   - Launch Unity Hub
   - Add project folder
   - Open with Unity 2021.3+

3. **Play the Game**
   - Open the `MainScene` in `Assets/Scenes/`
   - Click Play in the Unity Editor

### Building
1. **File → Build Settings**
2. Select your target platform (Windows, Mac, WebGL)
3. Click **Build**

## 📁 Project Structure

```
snowboarder-game/
├── Assets/
│   ├── Scripts/
│   │   ├── Player/
│   │   │   ├── PlayerController.cs      # Main movement and rotation
│   │   │   ├── PlayerPhysics.cs         # Physics calculations
│   │   │   └── PlayerAnimations.cs      # Animation control
│   │   ├── Gameplay/
│   │   │   ├── FinishLine.cs            # Level completion system
│   │   │   ├── CrashDetection.cs        # Collision handling
│   │   │   └── ScoreManager.cs          # Scoring system
│   │   ├── Effects/
│   │   │   ├── ParticleController.cs    # Particle system management
│   │   │   └── CameraEffects.cs         # Screen shake and effects
│   │   └── Managers/
│   │       ├── GameManager.cs           # Game state management
│   │       └── LevelManager.cs          # Level loading and restart
│   ├── Art/
│   │   ├── Sprites/                     # Character and environment sprites
│   │   ├── SpriteShapes/                # Terrain sprite shapes
│   │   └── Particles/                   # Particle system textures
│   ├── Scenes/
│   │   ├── MainScene.unity              # Main gameplay scene
│   │   └── MenuScene.unity              # Main menu scene
│   ├── Prefabs/                         # Reusable game objects
│   └── Audio/                           # Sound effects and music
├── ProjectSettings/                     # Unity project settings
└── README.md                            # This file
```

## 🛠️ Technical Implementation

### **Sprite Shape Terrain**
- **Custom Tool Usage**: Leveraged Unity's Sprite Shape Controller for smooth, deformable terrain
- **Collision Optimization**: Efficient 2D collider generation from sprite shapes
- **Visual Polish**: Gradient fills and multiple sprite layers for depth

### **Physics System**
```csharp
// Example: Rotation control in PlayerController.cs
void HandleRotation() {
    if (!isGrounded) {
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -rotationInput * rotationSpeed * Time.deltaTime);
    }
}
```

### **Particle Effects**
- **Ground Contact Particles**: Triggered on landing with velocity-based intensity
- **Crash Effects**: Burst particles on collision with obstacles
- **Speed Lines**: Particle trails during boost activation

## 🎯 Game Design Elements

### **Level Design**
1. **Progressive Difficulty**: Easy to hard slope designs
2. **Checkpoint System**: Strategic restart points
3. **Secret Paths**: Hidden routes with bonuses
4. **Environmental Hazards**: Trees, rocks, and gaps

### **Player Progression**
- **Unlockable Characters**: Different snowboarders with unique stats
- **Customization**: Board designs and character outfits
- **Level Stars**: Three-star rating system per level


## 🔮 Future Features

### **Planned Updates**
1. **Multiplayer Mode**
   - Split-screen local multiplayer
   - Online leaderboards
   - Ghost race system

2. **Extended Content**
   - More levels with different themes (forest, urban, park)
   - Weather system (snowstorm, night riding)
   - Trick system with combo scoring

3. **Technical Enhancements**
   - Mobile touch controls
   - VR/AR compatibility
   - Advanced particle effects with shaders

### **Community Requests**
- Level editor for player-created content
- Replay system with camera controls
- Modding support for custom assets

## 🏗️ Development Journey

### **Challenges Overcome**
1. **Physics Tuning**: Balancing realism with fun gameplay
2. **Sprite Shape Limitations**: Working around edge cases in terrain generation
3. **Performance Optimization**: Maintaining 60 FPS with particles and physics

### **Key Learnings**
- Effective use of Unity's 2D physics system
- Particle system optimization techniques
- Player feedback systems for satisfying gameplay

## 🤝 Contributing

Interested in contributing? Here's how:

1. **Fork the repository**
2. **Create a feature branch** (`git checkout -b feature/NewFeature`)
3. **Commit changes** (`git commit -m 'Add NewFeature'`)
4. **Push to branch** (`git push origin feature/NewFeature`)
5. **Open a Pull Request**

### **Areas for Contribution**
- New level designs
- Additional particle effects
- Sound design and music
- Bug fixes and optimizations

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **Unity Technologies** for the amazing game engine
- **Sprite Shape Tool** for making terrain creation a breeze
- **Online Tutorials** that helped overcome development hurdles
- **Playtesters** who provided valuable feedback

<div align="center">

### **Ready to shred the slopes?** 🏔️❄️

*For questions, feedback, or collaboration opportunities, feel free to reach out!*

**⭐ If you like this project, don't forget to star the repository!**

</div>
