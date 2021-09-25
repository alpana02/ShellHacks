# ShellHacks

## Inspiration
- The COVID-19 pandemic brought a complex array of challenges which had mental health repercussions for everyone, including children and adolescents. 
- Grief, fear, uncertainty, social isolation, and parental fatigue have negatively affected the mental health of children.
- Fun and entertainment was in sheer need to overcome the stress and monotonicity during the Covid period. 

## Solution
It is a platform that enables users to have virtual gaming experience, from the comfort of their own home. 
### AR BUDDY –
- Augmented reality (AR-Buddy) is a socially interactive model which resides in a real-world environment 
- It superimposes a pre-created playful environment on top of a user’s actual environment.

 ### ML BUDDY –
- The main objective of utilizing AI in gaming is to deliver a realistic gaming experience for players to battle against each other on a virtual platform. 
- In addition, AI in gaming also helps to increase the player’s interest and satisfaction over a long period of time. Here the player competes with our pre-trained ML model and is scored accordingly.


## How we built it
### AR BUDDY 
- Imported Vuforia in Unity, then an image target was provided such that Vuforia Engine can detect and track the surface on which it can superimpose the 3d character. 
- The AR character can perform various actions like walk, kick and run. And the user can control its actions through various buttons. 
- We added animator transitions and controlled its movement and actions using c#. 
- After this, we modified each time stamp for handling the actions in order.
### ML BUDDY
- We had four labels: rocks, paper, scissors, and none.
- We had used transfer learning where the squeeze net model is used. and later preprocessed it according to models input from the feed of webcam.
- The ml bubby classifies our moves according to the label and makes its own moves.
- It is a self-learning model. After each round, it learns the game in order to win. 
- For detecting the user moves we extracted the region of interest within the rectangle and gave predictions to the user interface.


![WhatsApp Image 2021-09-26 at 00 50 29](https://user-images.githubusercontent.com/64356997/134787154-715dd20a-fbb3-40df-9a88-abba9f01390f.jpeg)
