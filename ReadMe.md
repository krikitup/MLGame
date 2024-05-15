# Machine Learning Components in Gaming

## Overview
This project explores the integration of Machine Learning (ML) in gaming environments, focusing on enhancing realism and responsiveness in-game characters and scenarios. By leveraging ML, this project aims to handle complex systems more efficiently than traditional methods, easing coding efforts and scaling solutions effectively. 


## Motivation
Being a Scientific Computing master's student I have been working with different machine learning from the onset of my master's, after taking the course CIS 460, Computer Graphics by Prof Adam Mally, I was more curious about Game Dev and wanted to explore it further. After my futile tries at learning Unity, and Unreal in past, it seemed like the perfect opportunity to dive into it. I wanted to explore animation using ML, or movements for NPCs, to make it more dynamic, and system-driven. I also thought it'd be nice to implement a self-driving vehicle as I have done it before using CNNs, which use a pre-trained network and are slower, as there is very heavy computation involved. Therefore, in a controlled environment, we can simplify some of it, and instead use Ray-Casting for autonomous driving. 

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

# Implementation with Time-Line: Machine Learning Components in Gaming

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

<div align='center'>
<img src="https://github.com/krikitup/MLGame/assets/52323943/ec360a7d-a22a-4539-9c61-68f28a95a914" width="80%" />
  <p>Video showing U-turn with raycast.</p>
</div>


## Achievements and Failures

### Achievements

- **Humanoid Stability Against Forces**: The humanoid model demonstrated the ability to walk against a range of resistive forces and successfully reach designated goals. This stability is a significant achievement, showcasing the effectiveness of the training under varying environmental conditions.
- **Car Navigation and U-Turn Mastery**: The car agent achieved one of the most challenging manoeuvres—executing a U-turn. This capability highlights the sophisticated level of spatial awareness and decision-making instilled through the training. Moreover, the car does not halt in the absence of a clear path; instead, it dedicates time to calculate possible movements, ensuring continuous operation.
- **Stable Car Mechanics**: Successfully created stable car mechanics that allowed the vehicle to operate under a variety of conditions and maintain good speed, contributing significantly to the realism and dynamic nature of the simulation.
- **Efficient Task Completion**: Both the humanoid and car agents were able to complete their respective tasks effectively, with optimized speeds that contributed to an overall efficient system performance.

### Limitations

- **Incomplete Inverse Kinematics in Humanoid**: While the implementation of inverse kinematics allowed for some control over arm movements, it failed to update leg movements adequately, resulting in a humanoid that was unstable and unable to walk properly during training sessions. This limitation highlights a critical area where the inverse kinematics integration with existing assets did not meet project expectations.
- **Limited Arm Movement Control**: Attempts to enhance arm movement control by implementing a negative reward system for movements outside a perpendicular plane to the body did not yield significant improvements. The control was largely confined to the forearms, with minimal effects on the upper arms, indicating a need for further refinement in this aspect of the model.
- **Robustness Issues in Autonomous Driving**: The autonomous driving system still exhibits low robustness, with frequent collisions indicating that the current model struggles with accurately predicting and reacting to obstacles. This area remains a key challenge and a focus for future improvements.

## Challenges

### Car Navigation Challenges
- **Early Stopping**: One of the significant challenges with the autonomous driving system was the car's tendency to stop prematurely. This behaviour often occurred in scenarios where pathfinding algorithms failed to identify viable routes forward, necessitating further refinement of the decision-making processes within the model.
- **Difficulty with U-Turns**: Despite achieving the manoeuvre in some instances, consistently performing U-turns remained a troubling aspect. The car often struggled to execute U-turns smoothly, indicating a need for more sophisticated handling and path-planning algorithms to improve manoeuvrability in tight scenarios.

### Humanoid Movement Training
- **Instability Against Forces**: The humanoid agent initially faced significant challenges when trained to walk against resistive forces. The model frequently fell, struggling to maintain balance and effective locomotion, which required iterative adjustments and enhancements to the training regime to achieve the desired stability and functionality.

### Checkpoint System Limitations
- **Inflexible Forward Direction**: The checkpoint system used for navigating the car had limitations in its ability to adjust the forward direction dynamically. This rigidity made aligning the car with the track more challenging, especially in complex track layouts or sudden directional changes. Improving the flexibility and responsiveness of the checkpoint system is essential for enhancing the autonomous driving capabilities of the car.

### Training and Hyperparameter Tuning Challenges
- **Model Training Difficulties**: Determining the optimal set of hyperparameters was a substantial challenge, as the model's performance varied significantly under different configurations. Frequent visualization of the model's performance under various scenarios was essential to understand the impact of each parameter adjustment.
- **Adapting to Dynamic Environments**: The dynamic and unpredictable nature of the game environment posed significant challenges in training, requiring continuous adjustments to training strategies and model parameters.

### Improvements
- **Checkpoint Height Adjustment and Multi-Raycast Implementation**: To overcome navigation issues, the height of checkpoints was reduced, and a multi-raycast system was implemented. This setup ensured that the car model could maintain a consistent view of the environment ahead, including essential cues from behind, enhancing situational awareness and decision-making accuracy.
- **Enhanced Environment Interaction**: By adding tags to different elements within the game environment (e.g., track, wall, checkpoint), the model was trained to process and differentiate between various types of interactions. This tagging system allowed for more nuanced responses and improved the overall performance of the AI agents.
- **Incorporating Reverse Actions**: To improve the car's ability to handle complex manoeuvres like U-turns, training data was enhanced to include reverse actions. This addition allowed the AI to learn and execute backing up as a strategic manoeuvre when forward paths were blocked or non-optimal.
- **Multiple Training Sessions with Inference Feedback**: The project utilized an iterative training approach, where multiple training sessions were conducted, and inference data from each session was analyzed to inform subsequent training phases. This method allowed for continuous improvement of the model’s accuracy and adaptability, ensuring that each iteration addressed the shortcomings identified in the previous one.

## Imitation Learning in Gaming

### Why Imitation Learning?
Imitation learning was chosen for this project due to its effectiveness in quickly ramping up the competency of machine learning models in complex environments. Unlike traditional reinforcement learning which requires models to learn from scratch through trial and error, imitation learning speeds up the process by teaching models to mimic successful behaviours from pre-recorded data. This approach is particularly advantageous in gaming, where desired actions and outcomes can be precisely demonstrated through expert gameplay, thus providing a clear path for the AI to learn.

Imitation learning is crucial in environments where obtaining rewards can be sparse or delayed, as it helps in establishing a baseline behaviour that the model can refine through further training. It ensures that the model starts with a fundamental understanding of the task, significantly reducing the time and resources spent on training.

### Achievements with Imitation Learning
In this project, imitation learning proved to be a substantial asset:
- **Rapid Learning**: The humanoid and car agents learned tasks much faster compared to models trained from scratch. This was evident in their quick adaptation to walking against resistive forces and handling complex driving manoeuvres like U-turns.
- **Stability and Performance**: Models trained with imitation learning exhibited increased stability and performance from the outset, handling complex sequences of actions with greater ease and confidence.

### Further Improvements
While imitation learning has significantly benefitted the project, there are several areas where the approach could be enhanced further:

- **Integration with Reinforcement Learning**: Combining imitation learning with reinforcement learning could yield better results. After the initial phase of imitation, reinforcement learning can take over to refine the behaviours based on specific rewards and penalties, tailoring the AI’s responses to the nuances of the game environment.
- **Increased Dataset Variety**: Expanding the variety of scenarios and behaviours in the training dataset can help improve the model's ability to generalize across different situations. Including more varied and challenging scenarios in the imitation dataset will prepare the AI for a wider range of in-game dynamics.
- **Continuous Learning and Adaptation**: Implementing mechanisms for continuous learning, where the model can learn and adapt from new gameplay data generated by actual players, could help the AI evolve with the game, maintaining its effectiveness as the game mechanics and player strategies develop over time.


By addressing these areas, the project can leverage the full potential of imitation learning, ensuring that the AI remains effective and responsive as the gaming environment evolves.

## Results

### Humanoid
The system was tested with various forces:
- **Random vs. One Directional Forces**: The model performed better with dynamically changing forces, which helped in negating some of the external variables.

<div align="center">
  <div style="display: inline-block; margin: 5px;">
    <img src="https://github.com/krikitup/MLGame/assets/52323943/e96606a0-7d89-414d-befb-24c4f3c8868b" width="45%" />
    <p>Dynamically Direction changing force </p>
  </div>
  <div style="display: inline-block; margin: 5px;">
    <img src="https://github.com/krikitup/MLGame/assets/52323943/9dff6324-212c-4533-a17f-30205989f2bd" width="45%" />
    <p>One directional Force</p>
  </div>
</div>




| Type    | Magnitude | Speed Reward | Direction Reward | Failure     |
|---------|-----------|--------------|------------------|-------------|
| Null    | 0         | 0.4135122    | 0.8953937        | very little |
| Uni     | 0.1       | 0.3193891    | 0.9009511        | very little |
| Uni     | 1         | 0.3627325    | 0.8934507        | very little |
| Uni     | 10        | 0.08228441   | 0.8251086        | significant |
| Uni     | 100       | 2.14E-05     | 0.5869689        | failure     |
| Random  | 0.1       | 0.4199955    | 0.9050978        | very little |
| Random  | 1         | 0.432611     | 0.9033613        | very little |
| Random  | 10        | 0.3575214    | 0.8982531        | very little |
| Random  | 100       | 0.1408803    | 0.7955912        | significant |

### Car

## Future Improvements

To build on the current achievements and address the existing challenges, several advancements are proposed for the next phases of the project. These enhancements are aimed at increasing the sophistication and effectiveness of the machine-learning models used in the gaming environment.

### Implementation of Convolutional Neural Networks (CNNs)
- **Using CNNs for Enhanced Perception**: Integrating Convolutional Neural Networks (CNNs) could significantly enhance the visual processing capabilities of the models. CNNs are particularly effective in interpreting complex visual inputs, making them ideal for tasks that require a deep understanding of intricate game environments. By processing visual data directly, CNNs can help improve the accuracy and responsiveness of AI agents, particularly in tasks involving navigation and object recognition.

### Extended and Varied Training
- **More Comprehensive Training Regimes**: Extending the training periods and diversifying the training environments can help the models develop a more robust understanding of the game dynamics. This includes exposing the AI to a wider range of scenarios and challenges, which can better prepare them for unexpected situations during gameplay.
- **Adaptive Training Methods**: Implementing adaptive training methods that adjust the difficulty and complexity of training scenarios based on the model’s performance could foster more efficient learning. This approach ensures that the AI is always challenged but not overwhelmed, optimizing the learning curve.

### Enhanced Data Collection and Analysis
- **Improved Data Collection**: Enhancing the methods of data collection, particularly by capturing a broader spectrum of in-game interactions and outcomes, can provide richer datasets for training. This data can be used to fine-tune the models and correct specific deficiencies in the AI’s behaviour.
- **Advanced Analytical Tools**: Employing more advanced analytical tools to evaluate the effectiveness of the training sessions and the in-game performance of the AI can provide deeper insights into how the models can be improved.

### Real-time Learning and Adaptation
- **Online Learning Capabilities**: Developing real-time or online learning capabilities where the AI can adjust and learn from each interaction within the game could lead to highly adaptive and intelligent systems. This continuous learning approach would allow the AI to refine its strategies based on new information, maintaining its effectiveness as the game evolves.


## Acknowledgements
Special thanks to Prof. Adam Mally for continuous guidance, and my friend Utkarsh for his help with learning Unity, and setting up the environment. 
