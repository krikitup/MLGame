# Machine Learning Components in Gaming

## Overview
This project explores the integration of Machine Learning (ML) in gaming environments, focusing on enhancing realism and responsiveness in game characters and scenarios. By leveraging ML, this project aims to handle complex systems more efficiently than traditional methods, easing coding efforts and scaling solutions effectively.

## Features

### Pros
- **Ease of Use**: Simplifies implementation with existing ML libraries.
- **Resource Availability**: Extensive examples and libraries are readily accessible.

### Cons
- **Control Over Network Architecture**: Limited control which may affect customization.
- **Environmental Dependency**: The system's performance is heavily reliant on the specific setup.

## Implementation

### Tools Used
- **Unity ML-Agents**: Utilized for dynamic and adaptive character animations, allowing for more realistic movements than traditional animation techniques.

### Techniques
- **Reinforcement Learning**: Applied to train agents with the goal of maximizing reward accumulation over time.
- **Imitation Learning**: Combines reinforcement learning with recorded data to speed up the learning process and achieve realistic character behavior.

## Challenges

### What Didn't Work
- **Inverse Kinematics**: Struggled with complex joint movements.
- **Constrained Arm Movement**: Limited to forearms, lacking impact on shoulders.
- **Training Limitations**: Early stopping in movements due to high negative rewards and ineffective use of single raycast for movement prediction.

### What Did Work
- **Imitation vs. Classical Learning**: Marked improvements in learning efficiency when using imitation learning over classical methods.

## Results

### Training Curves
The system was tested with various forces:
- **Random vs. One Directional Forces**: The model performed better with dynamically changing forces, which helped in negating some of the external variables.

## Future Work
- **Model Consistency**: Enhancing the car model for more dynamic training scenarios.
- **Information and Sensory Inputs**: Adding more sensors and improving ray-casting techniques.
- **Behavior Cloning**: Integrating traditional animation for better-controlled movements.

## Acknowledgements
Special thanks to Prof. Adam Mally and Prof. Talid Sinno for their guidance and support throughout the project.
