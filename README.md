# Overview
It will be a tuned based strategy game where each match played on a square tile board that will be no smaller than 5 tiles by 5 tiles.

Initial planning will be around the idea that all the units will be set up in an initialization phase for ‘turn 0’ where the game will play from there.

Any specifics of units, ability’s, spells shall be determent at a later date. Any such as implementing a card game style twist or an additional strategic layer where multiple matches will be played in a single game will be stretch goals. The question right now is if multiplayer would fall under the stretch goals.

## Componets
### User Interface
At base the user interface would have a turn 0 state where players would be able to add units to the board. Afterwords it would be used to control the units on the board reciving updates from the Logic Engines.

### Logic Engines
The main muscle of the program. contains the following programs
  A dynamic list to keep what minions are in play first populated by the database.
  The main logic engine that decideds the order of operations that player actions go in.
  Movement Engine that checks if a movement is valid.
  The Damage engine to determin the results of combat.
  

### Database
There are three main databases
  1)Minion Database- Contains the base stats of a minion.
  2)Abilites database-A list of abilites and their name.
  3)Assignment database-determins what minions have what abilites.


![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/746cd2f9173306e07a30f72d28a32b2b2d40dd98/ReadMe%20Images/components.png)

# Wireframe Sketches
## Turn 0 UI
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/bf63c4b7e8ffcf5333cf9a21a25803785ceece2e/ReadMe%20Images/wireframe_turn_0.png)
Note in this example has 3 minions added to the blue side and 1 to the red side with red picking to add another minion to their line up (shown by the yellow circle) and picking a minion form the selection table(Shown by the yellow box).


![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/bf63c4b7e8ffcf5333cf9a21a25803785ceece2e/ReadMe%20Images/wireframe_turn_1.png)


# User Stories


# Use-Cases


# Use Case Diagram
