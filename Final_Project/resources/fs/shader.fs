#version 330 core
in vec2 TexCoord;
in vec3 FragPos;
in vec3 Normal;
out vec4 FragColor;

uniform sampler2D texture1;
uniform vec3 lightPos;
uniform vec3 lightColor;
uniform vec3 viewPos;

void main()
{
    // Sample the texture
    vec3 textureColor = texture(texture1, TexCoord).rgb;
    
    // Lighting calculations
    vec3 norm = normalize(Normal);
    vec3 lightDir = normalize(lightPos - FragPos);
    float diff = max(dot(norm, lightDir), 0.0);
    
    // Ambient + diffuse lighting
    vec3 ambient = 0.3 * lightColor;
    vec3 diffuse = diff * lightColor;
    
    vec3 result = (ambient + diffuse) * textureColor;
    FragColor = vec4(result, 1.0);
}

