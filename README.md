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

# Draft
## Turn 0 UI
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/4a1a45e28305de5753411d4ccc0f96250449e433/ReadMe%20Images/wireframe_turn_0.png)
Note in this example has 3 minions added to the blue side and 1 to the red side with red picking to add another minion to their line up (shown by the yellow circle) and picking a minion form the selection table(Shown by the yellow box). As such when selecting a minion already in a line the buttons can be used to remove them or add another of that type Along side the ability to start the game.

## Turn 1+ UI
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/4a1a45e28305de5753411d4ccc0f96250449e433/ReadMe%20Images/wireframe_turn_1.png)
Note in this example blue player has already has the "2" minion defeated by being reduced to 0 health with red having inputed there actions as read in the text box waiting for the red player to click the confirm button or cancel. This would go till all units red player has have no actions left or red player hits the end turn button which would switch to blue players turn refilling their minions actions. where they would do thes same with this loop going till one side has no more minions.

# User Stories
### 
1)As a first time player
2)I want a quick to start game
3)So that I can play the game

### 
1)As a short on time player
2)I want a short game
3)So that it fits in my schedual

### 
1)As a color blind player
2)I need clear UI
3)So that I can play the game

### 
1)As a player that likes to think
2)I want options
3)So that I can try things out and compare

### 
1)As a invested player
2)I want the game to be responsive
3)So that it can do what I want it to do with out having to repeat actions.

# Use-Cases
### 
Player wants to add a minons to one of sides. they click the empty unit slot button or a copy of the unit they want to add and click add unit if it is turn 0.

### 
A player selects a minons and moves it as long it is an unoccupide space.

### 
A player selects and attacks with a unit. they select a minons and pick a unit to attack. the damage engine runs and updates the UI with the result and removes a unit from the board if its health is reduced to 0.

### 
A player ends their turn and another player starts their turn. They hit the end turn button and their turn ends and the nextplayer starts their turn and their minons refresh their actions.

### 
Player wants to Remove a minons to one of sides. A copy of the unit they want to add and click remove the unit if it is turn 0 and they have a copy of the unit in their line up.

# Use Case Diagram
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/4a1a45e28305de5753411d4ccc0f96250449e433/ReadMe%20Images/use_case_diagram.png)
