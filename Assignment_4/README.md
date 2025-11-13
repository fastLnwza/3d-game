## Assignment 4 — Skeletal Animation Showcase

This project extends the LearnOpenGL skeletal animation sample with Mixamo assets.  
It loads the `Ch09_nonPBR` character and lets you switch between multiple animation clips at runtime.

### Features
- GPU skinning via bone matrices driven by the custom `Animator` class.
- Runtime animation switching: Chicken Dance (default) and Jump clips.
- Free-fly camera controls with depth testing and per-frame delta timing.
- Resource packaging that copies shaders and textures into the CMake build output.

### Controls
- `W / A / S / D` — Move the camera.
- Mouse move / scroll — Look around & zoom (GLFW cursor disabled).
- `1` — Restart the Chicken Dance animation.
- `2` — Play the Jump animation.
- `Esc` — Quit.

### Build & Run
```bash
# Configure (once)
cmake -S . -B build

# Build just this assignment
cmake --build build --target Assignment_4

# Run from the build tree so FileSystem paths resolve correctly
./build/Assignment_4/Assignment_4
```

> **macOS dependencies:** ensure `glfw`, `glm`, `assimp`, and `stb` are available.  
> CMake’s `FetchContent` pulls GLFW/GLM/STB automatically; install Assimp separately  
> (e.g. `brew install assimp`) so the `find_package(assimp REQUIRED)` call succeeds.

### Assets
- Character mesh: `Ch09_nonPBR.dae`
- Animations: `Chicken Dance.dae`, `Jump.dae`
- Textures: located under `resources/objects/mixamo/textures/`

All Mixamo assets remain under their original license.

### Capture
- Screenshot: `result/Boy.png`
- Animation capture: `result/Boy.mp4`

### Notes
- Resource lookup uses `learnopengl/filesystem.h`, which is configured during CMake generation via `learnopengl/root_directory.h`.
- If you move the repository, re-run CMake so the generated root path matches your local checkout.
