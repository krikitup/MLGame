# Machine Learning Components in Gaming

## Overview
This project explores the integration of Machine Learning (ML) in gaming environments, focusing on enhancing realism and responsiveness in-game characters and scenarios. By leveraging ML, this project aims to handle complex systems more efficiently than traditional methods, easing coding efforts and scaling solutions effectively. 


## Motivation
Being a Scientific Computing master's student I have been working with different machine learning from the onset of my master's, after taking the course CIS 460, Computer Graphics by Prof Adam Mally, I was more curious about Game Dev and wanted to explore it further. After my futile tries at learning Unity, and Unreal in past, it seemed like the perfect opportunity to dive into it. I wanted to explore animation using ML, or movements for NPCs, to make it more dynamic, and system-driven. I also thought it'd be nice to implement a self-driving vehicle as I have done it before using CNNs, which uses a pretrained network and are slower, as there is very heavy computation involved. Therefore, in a controlled environment, we can simplify some of it, and instead use Ray-Casting for autonomous driving. 

## Why Use Machine Learning in Gaming?

Machine Learning offers several advantages in gaming, enhancing the development process and the end-user experience. Here are the key reasons for integrating ML into gaming:

### Complexity Management
Machine Learning allows using complex systems where traditional programming approaches fall short. In gaming, this complexity can arise from the need to simulate dynamic environments, intricate player interactions, or highly adaptive AI opponents. ML algorithms can better handle these complexities by learning from data, which allows them to adapt to a wide range of scenarios without explicit programming for each possibility.

### Ease of Implementation
Implementing Machine Learning can be more straightforward compared to the traditional approach of manually coding complex logic. Instead of anticipating and coding for hundreds of possible scenarios, developers can use ML models that learn and make decisions based on input data. This reduces the effort required to handle edge cases and lowers the frequency of missed cases that need specific handling.

### Robustness
ML methods are robust in delivering appropriate responses or actions with minimal changes to their algorithms. By learning from patterns in data, ML models can generalize from past experiences to new, unseen scenarios. This robustness is critical in gaming, where unpredictable player behaviour and the need for continuous system adaptability are common.

### Scalability
Machine Learning systems are inherently scalable. They can be trained on small data sets and then scaled to handle larger, more complex data sets over time. This scalability is particularly beneficial in gaming, where developers might start with limited scenarios and progressively train models to handle more complex situations or integrate them into bigger, more detailed game worlds.

### Enhancing Realism and Engagement
ML can significantly enhance the realism of game characters and environments by enabling more sophisticated behaviour models and interaction dynamics that are difficult to achieve with conventional algorithms. For instance, NPCs (non-player characters) powered by ML can exhibit behaviours that adapt to player actions in more nuanced ways, enhancing player engagement and providing a more immersive gaming experience.

Overall, Machine Learning's ability to manage complexity, ease of implementation, robustness, scalability, and contribution to realism makes it an invaluable tool in modern game development.

## Using [Unity ML-Agents](https://unity.com/products/machine-learning-agents)

Unity ML-Agents is an open-source toolkit offered by Unity Technologies that enables games and simulations to serve as environments for training intelligent agents. Here’s how Unity ML-Agents has been utilized in this project, along with its advantages and disadvantages:

### Advantages of Unity ML-Agents
- **Ease of Use**: Unity ML-Agents simplifies the implementation of complex AI behaviours, making it more accessible for developers to integrate advanced machine learning techniques.
- **Resource Availability**: There is a large number of examples and extensive documentation available, which help developers get up to speed quickly.
- **Existing Libraries and Resources**: The toolkit includes a wide range of pre-built libraries and resources that can be used to enhance the development process, reducing the need to build components from scratch.

### Disadvantages of Unity ML-Agents
- **Limited Control Over Network Architecture**: While ML agents provide various tools to build and train models, there are constraints in how much developers can modify the underlying network architectures, which may limit fine-tuning and optimization specific to certain games.
- **Dependence on System Environment**: The performance and effectiveness of trained models can be heavily dependent on the system environment. This means that changes in the game's environment or platform can potentially require significant retraining or adjustments to the AI models.

### Application in Project
In this project, Unity ML-Agents was primarily used to enhance character animations and make them more dynamic and adaptive. This was achieved by training agents within the Unity environment, enabling them to learn and improve their behaviours based on interactive gameplay scenarios.

Unity ML agents represent a powerful tool in the arsenal of game developers aiming to push the boundaries of what's possible in game AI, making games more immersive and interactive.

# Project Timeline: Machine Learning Components in Gaming

## Weeks 1-3: Initial Setup and Research
- **Setting Up the Unity Environment**: Configure and prepare the Unity environment for ML-based developments. This includes installing Unity ML-Agents and setting up the necessary tools and plugins required for the project.
- **Literature Review**: Review academic papers and existing literature to understand the current landscape of machine learning in gaming. Special attention will be given to identifying the tasks that can benefit most from ML integration.
- **Decision on Specific ML Task**: Decide on a specific task where machine learning can be applied within the Unity environment. This decision will be based on the complexities and potential impact identified in the reviewed literature. One key motivation for this project is derived from the findings in the paper ["Challenges and Opportunities for Multi-Agent Reinforcement Learning"](https://dl.acm.org/doi/abs/10.1145/3274247.3274506). The insights from this paper will guide the choice of the ML task to ensure the project aligns with cutting-edge research in the field.

## Weeks 4-6: Humanoid Movement and Inverse Kinematics
- **Humanoid Movement Learning**: Focus on developing and training AI models to handle humanoid movement using Unity ML-Agents.
- **Implementing Inverse Kinematics**: Attempt to implement inverse kinematics to improve the realism and accuracy of joint movements in humanoid figures.
- **Adapting to Forces**: Train the model to enable the agent to walk against both random and uni-directional forces, enhancing stability and adaptability in variable conditions.

## Weeks 7-8: Car Mechanics and Scene Setup
- **Implementing Car Mechanics**: Utilize the [Arcade Free Racing Car asset](https://assetstore.unity.com/packages/3d/vehicles/land/arcade-free-racing-car-161085) from the Unity Asset Store to design and implement car mechanics, following guidance from [this YouTube tutorial](https://www.youtube.com/watch?v=Z4HA8zJhGEk&t=578s) on car control implementation.
- **Checkpoint System Setup**: Set up a checkpoint system for the racing track using guidance from [this YouTube video](https://www.youtube.com/watch?v=IOYNg6v9sfc). This system will be crucial for training car agents to navigate tracks efficiently.
- **Scene Preparation**: Prepare the training scene for the car using the [Modular Lowpoly Track Roads Free asset](https://assetstore.unity.com/packages/3d/environments/roadways/modular-lowpoly-track-roads-free-205188) to create a realistic and functional race track environment.

## Weeks 9-12: Training, Evaluation, Refinement, and Advanced Implementation

- **Advanced Raycast Implementation**: Enhance the raycasting system by incrementally increasing the complexity—from one raycast to two and eventually to four. This upgrade aims to improve the agent's ability to gather more detailed information from the environment, thus enhancing decision-making capabilities.

- **Modifying the Checkpoint System**: Revise the checkpoint system to allow better data gathering and interaction with the environment. This modification will enable more precise navigation cues for the car agents, improving their ability to handle diverse track configurations.

- **Incorporating Additional Inputs**: Add velocity as one of the inputs to the training model. This inclusion will help the agent to make more informed decisions based on the speed dynamics of the car, enhancing realism and control.

- **Training Data Enhancements for Handling Curves**: Implement training data modifications to teach the car agent to slow down around turns by providing negative forward input. This strategy will not only teach the agent to decelerate appropriately but also to reverse direction when necessary, mimicking more complex driving behaviours and improving handling on challenging track sections.

- **Further Training and Evaluation**: Continue to train both humanoid and car agents within their respective environments, adjusting models and strategies based on performance data. This phase will focus on integrating these new systems and inputs into the existing training framework to observe and refine their impacts on overall agent behaviour.

- **Performance Optimization**: Optimize the AI models to enhance performance, focusing on efficiency and effectiveness in both humanoid movement and car navigation. Special attention will be given to the integration of the new raycast system and the refined checkpoint mechanics.

- **Project Documentation and Final Presentation**: Prepare comprehensive documentation of the project outcomes, including detailed descriptions of all systems and technologies implemented, challenges faced, successes achieved, and areas for future research. Prepare and deliver a final presentation to stakeholders to showcase the project results, emphasizing the advancements made in AI training techniques and their practical applications in game environments.



## Implementation

### Tools Used
- **Unity ML-Agents**: Utilized for dynamic and adaptive character animations, allowing for more realistic movements than traditional animation techniques.

### Techniques
- **Reinforcement Learning**: Applied to train agents to maximize reward accumulation over time.
- **Imitation Learning**: Combines reinforcement learning with recorded data to speed up the learning process and achieve realistic character behaviour.

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
