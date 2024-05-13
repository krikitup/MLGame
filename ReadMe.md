# Machine Learning Components in Gaming

## Overview
This project explores the integration of Machine Learning (ML) in gaming environments, focusing on enhancing realism and responsiveness in-game characters and scenarios. By leveraging ML, this project aims to handle complex systems more efficiently than traditional methods, easing coding efforts and scaling solutions effectively. 


## Motivation
Being a Scientific Computing master's student I have been working with different machine learning from the onset of my master's, after taking the course CIS 460, Computer Graphics by Prof Adam Mally, I was more curious about Game Dev and wanted to explore it further. After my futile tries at learnign Unity, and Unreal in past, it seemed like the perfect opportunity to dive into it. I wanted to explore animation using ML, or movements for NPCs, to make it more dynamic, and system-driven. I also thought it'd be nice to implement a self-driving vehicle as I have done it before using CNNs, which are much more complicated, but has much more data to process, using a Ray-Casting in environment with reinforcement learning could solve it. 


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
