# Coding Exercise – Security Questions
## Requirement
Using Visual Studio and c#, build a console app that stores answers to security question for a specified person.  It has the
following flows :
- Prompt for Name – Initial Flow: “Hi, what is your name?”
  - If the name has no stored questions, present the Store flow
  - Else, asks if the user wants to answer a security question : “Do you want to answer a security question?”
     - If Yes, present the “Answer” flow
     - Else re-do answers through the “Store” flow
- Store : “Would you like to store answers to security questions?”
  - If yes, loop through provided questions and prompt them for answers, storing the answers
    - Out of 10 total questions the user has to choose 3
  - Present the “Prompt for Name” when finished or user declined to store
 - Answer : present questions until either the user runs out of questions or answers one correctly
    - If the user answers correctly, congratulate the user
    - If the user runs out of questions, let them know
    - Go back to the Prompt for Name flow when finished

## Storage Mechanism

I have used XML file for storing the data. it will be created in the first save in the system this application is running. if you hard delete or remove the folder it will persist data.

## Explanations
 - initialize all Sample Questions in static model.
 - program file has while loop to keep the application running until its hard close.
  - flow methods for preform workflow based on requirement in 'ProcessLogic' class
  - business logic for retrieve and store data in 'DataLogic' class
  - actual Data Access Layer in on 'UserList' class to Save and Load data from XML
  - Was not added any TEST project for TEST
