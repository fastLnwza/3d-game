cmake_minimum_required(VERSION 3.16)
project(Assignment_3)

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Include directories
include_directories(${CMAKE_CURRENT_SOURCE_DIR})
include_directories(${CMAKE_CURRENT_SOURCE_DIR}/../common/include)

# Add executable
add_executable(Assignment_3 
    main.cpp
    model.cpp
    camera.cpp
)

# Link with common library
target_link_libraries(Assignment_3 common)

# Link GLFW
target_link_libraries(Assignment_3 glfw)

# Link GLAD
find_library(GLAD_LIB 
    NAMES libglad.a glad
    PATHS ${CMAKE_SOURCE_DIR}/build/_deps/glad-build
    NO_DEFAULT_PATH
)
if(GLAD_LIB)
    target_link_libraries(Assignment_3 ${GLAD_LIB})
    target_include_directories(Assignment_3 PRIVATE ${CMAKE_SOURCE_DIR}/build/_deps/glad-build/include)
else()
    # Fallback: try to link from build directory directly
    target_link_libraries(Assignment_3 ${CMAKE_SOURCE_DIR}/build/_deps/glad-build/libglad.a)
    target_include_directories(Assignment_3 PRIVATE ${CMAKE_SOURCE_DIR}/build/_deps/glad-build/include)
endif()

# Link GLM
target_include_directories(Assignment_3 PRIVATE ${CMAKE_SOURCE_DIR}/build/_deps/glm-src)

# Include stb_image
target_include_directories(Assignment_3 PRIVATE ${CMAKE_SOURCE_DIR}/build/_deps/stb-src)

# Copy resources to build directory
# Use add_custom_command to ensure resources are copied during build
add_custom_command(TARGET Assignment_3 POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E make_directory "${CMAKE_BINARY_DIR}/Assignment 3/resource"
    COMMAND ${CMAKE_COMMAND} -E copy_directory
        "${CMAKE_CURRENT_SOURCE_DIR}/resource"
        "${CMAKE_BINARY_DIR}/Assignment 3/resource"
    COMMENT "Copying resources to build directory"
)

# Provide source and binary dirs to the app for robust resource path resolution
target_compile_definitions(Assignment_3 PRIVATE 
    PROJECT_SOURCE_DIR="${CMAKE_CURRENT_SOURCE_DIR}"
    PROJECT_BINARY_DIR="${CMAKE_CURRENT_BINARY_DIR}"
)

# macOS specific
if(APPLE)
    target_link_libraries(Assignment_3 "-framework OpenGL" "-framework Cocoa" "-framework IOKit" "-framework CoreVideo")
endif()

