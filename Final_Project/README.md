# Final Project

## Overview

A 3D graphics project built with OpenGL, featuring interactive camera controls and custom rendering capabilities. This project serves as the foundation for creating advanced 3D graphics applications.

## Features

### 🎮 Interactive Controls
- **WASD**: Move camera around the scene
- **Mouse**: Look around the scene
- **SPACE**: Toggle rotation on/off
- **TAB**: Toggle wireframe mode
- **ESC**: Exit application

### ⚙️ Technical Features
- OpenGL 3.3 Core Profile rendering
- Custom vertex and fragment shaders
- Camera system with mouse and keyboard controls
- Lighting system (ambient + diffuse)
- Wireframe rendering mode
- Real-time animation support

## Technical Implementation

### Architecture
- **Language**: C++17
- **Graphics API**: OpenGL 3.3 Core Profile
- **Window Management**: GLFW
- **Mathematics**: GLM (OpenGL Mathematics)
- **Build System**: CMake
- **Image Loading**: stb_image

### Code Structure
```
Final_Project/
├── main.cpp                    # Main application and rendering loop
├── stb_image.h                # Image loading library
├── resources/
│   ├── vs/
│   │   └── shader.vs          # Vertex shader
│   └── fs/
│       └── shader.fs          # Fragment shader
├── images/                    # Screenshots folder
├── video/                     # Demo videos folder
├── CMakeLists.txt            # Build configuration
└── README.md                 # This file
```

## Building and Running

### Prerequisites
- C++17 compatible compiler (GCC, Clang, or MSVC)
- CMake 3.16 or higher
- OpenGL 3.3+ support
- GLFW3 library
- GLM library

### Build Instructions

1. **Build the project**:
   ```bash
   ./build.sh
   ```

2. **Run the executable**:
   ```bash
   cd build/Final_Project
   ./Final_Project
   ```

## Usage Instructions

1. **Launch the application** - A window will open with the 3D scene
2. **Explore the scene** - Use mouse to look around and WASD to move camera
3. **Toggle rotation** - Press SPACE to start/stop rotation
4. **Wireframe mode** - Press TAB to see wireframe view
5. **Exit** - Press ESC to close the application

## Development

### Adding 3D Models

To add 3D models to the project:
1. Create vertex data and indices for your model
2. Set up VAO, VBO, and EBO buffers
3. Load textures if needed
4. Render in the main loop

### Adding Textures

The project includes `stb_image.h` for texture loading. You can load textures with:
```cpp
unsigned int loadTexture(const char* path) {
    // Texture loading code
}
```

### Modifying Shaders

Vertex and fragment shaders are located in:
- `resources/vs/shader.vs` - Vertex shader
- `resources/fs/shader.fs` - Fragment shader

After modifying shaders, rebuild the project to copy them to the build directory.

## Credits

### Libraries
- **OpenGL**: Graphics API
- **GLFW**: Window management and input handling
- **GLM**: Mathematics library for 3D transformations
- **stb_image**: Image loading

---

*Final Project*  
*Computer Graphics and Game Development*

