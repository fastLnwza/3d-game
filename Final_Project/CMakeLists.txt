cmake_minimum_required(VERSION 3.16)
project(Final_Project)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Find required packages
find_package(OpenGL REQUIRED)
find_package(glfw3 REQUIRED)
find_package(glm REQUIRED)
find_package(GLUT)

# Include directories
include_directories(${CMAKE_CURRENT_SOURCE_DIR})
include_directories(${CMAKE_SOURCE_DIR}/common/include)

# Add executable
add_executable(Final_Project main.cpp)

# Add shader files
file(GLOB_RECURSE SHADER_FILES 
    "resources/vs/*"
    "resources/fs/*"
)

# Add shader files to the target
target_sources(Final_Project PRIVATE ${SHADER_FILES})

# Organize files in IDE
source_group("Shaders" FILES ${SHADER_FILES})

# Link libraries
target_link_libraries(Final_Project 
    common
    OpenGL::GL
    glfw
    glm::glm
)

if(GLUT_FOUND)
    target_link_libraries(Final_Project GLUT::GLUT)
elseif(APPLE)
    # Fallback for macOS system GLUT framework
    target_link_libraries(Final_Project "-framework GLUT")
endif()

# Copy resources to build directory
file(COPY ${CMAKE_CURRENT_SOURCE_DIR}/resources/ DESTINATION ${CMAKE_BINARY_DIR}/Final_Project/resources/)

# Provide source and binary dirs to the app for robust resource path resolution
target_compile_definitions(Final_Project PRIVATE 
    PROJECT_SOURCE_DIR="${CMAKE_CURRENT_SOURCE_DIR}"
    PROJECT_BINARY_DIR="${CMAKE_CURRENT_BINARY_DIR}"
)

