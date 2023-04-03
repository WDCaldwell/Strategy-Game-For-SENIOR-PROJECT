# Overview
It will be a tuned based strategy game where each match played on a square tile board that will be no smaller than 5 tiles by 5 tiles.

Initial planning will be around the idea that all the units will be set up in an initialization phase for ‘turn 0’ where the game will play from there.

Any specifics of units, ability’s, spells shall be determent at a later date. Any such as implementing a card game style twist or an additional strategic layer where multiple matches will be played in a single game will be stretch goals. The question right now is if multiplayer would fall under the stretch goals.

## Components
### User Interface
At base the user interface would have a turn 0 state where players would be able to add units to the board. Afterwards it would be used to control the units on the board receiving updates from the Logic Engines.

### Logic Engines
The main muscle of the program. contains the following programs.
  A dynamic list to keep what minions are in play first populated by the database.
  The main logic engine that decides the order of operations that player actions go in.
  Movement Engine that checks if a movement is valid.
  The Damage engine to determine the results of combat.
  

### Database
There are three main databases.
  1)Minion Database- Contains the base stats of a minion.
  2)Abilities database-A list of abilities and their name.
  3)Assignment database-determines what minions have what abilities.


![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/746cd2f9173306e07a30f72d28a32b2b2d40dd98/ReadMe%20Images/components.png)

# Draft
## Turn 0 UI
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/4a1a45e28305de5753411d4ccc0f96250449e433/ReadMe%20Images/wireframe_turn_0.png)
Note in this example has 3 minions added to the blue side and 1 to the red side with red picking to add another minion to their line up (shown by the yellow circle) and picking a minion form the selection table(Shown by the yellow box). As such when selecting a minion already in a line the buttons can be used to remove them or add another of that type Alongside the ability to start the game.

## Turn 1+ UI
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/4a1a45e28305de5753411d4ccc0f96250449e433/ReadMe%20Images/wireframe_turn_1.png)
Note in this example blue player has already has the "2" minion defeated by being reduced to 0 health with red having inputted there actions as read in the text box waiting for the red player to click the confirm button or cancel. This would go till all units red player has have no actions left or red player hits the end turn button which would switch to blue players turn refilling their minions’ actions. where they would do these same with this loop going till one side has no more minions.

# Requirements 
|ID|Requirement|
|-|-|
|1|A player can add and remove units to the board|
|2|A player can start the game, and end their turn|
|3|The AI will move the pices under their command|
|4|A units will deal damage and take damage|
|5|A unit that has reach zero healh shall be removed from the board|
|6|Unit abilites work as intended|

# User Stories
### 
1)As a first-time player
2)I want a quick to start game
3)So that I can play the game

### 
1)As a short on time player
2)I want a short game
3)So that it fits in my schedule

### 
1)As a color-blind player
2)I need clear UI
3)So that I can play the game

### 
1)As a player that likes to think
2)I want options
3)So that I can try things out and compare

### 
1)As an invested player
2)I want the game to be responsive
3)So that it can do what I want it to do without having to repeat actions.

# Use-Cases
### 
Player wants to add a minion to one of sides. they click the empty unit slot button or a copy of the unit they want to add and click add unit if it is turn 0.

### 
A player selects a minion and moves it as long it is an unoccupied space.

### 
A player selects and attacks with a unit. they select a minion and pick a unit to attack. the damage engine runs and updates the UI with the result and removes a unit from the board if its health is reduced to 0.

### 
A player ends their turn, and another player starts their turn. They hit the end turn button and their turn ends and the next player starts their turn, and their minions refresh their actions.

### 
Player wants to Remove a minion to one of sides. A copy of the unit they want to add and click remove the unit if it is turn 0 and they have a copy of the unit in their lineup.

# Use Case Diagram
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/4a1a45e28305de5753411d4ccc0f96250449e433/ReadMe%20Images/use_case_diagram.png)

# ERD
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/000657594cbf3e031c024efba347fc263d4f3d8d/ReadMe%20Images/chennotation_entity_relationship_diagram_.png)

# UML Class Diagram 
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/000657594cbf3e031c024efba347fc263d4f3d8d/ReadMe%20Images/UML%20Class%20Diagram.png)

# protype
![Protype](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/6cc484c56659ecee1731011303d1f0cb60fead63/Protype/ReadMeProtype.md)

# Data Access Layer
### Unit
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/ReadMe%20Images/Data%20Access/unit.PNG)
Data scheme for the unit table. will be used to contain a units base stats.
![Controller](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/Protype/Strategy%20game%20for%20SENIOR%20PROJECT/Controllers/UnitController.cs)
![Data](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/Protype/Strategy%20game%20for%20SENIOR%20PROJECT/Models/Unit.cs)

### Abilty
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/ReadMe%20Images/Data%20Access/Ability.PNG)
Ability scheme for the Ability table. will be used to get the name of the abilites to prevent excess data entries.
![Controller](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/Protype/Strategy%20game%20for%20SENIOR%20PROJECT/Controllers/AbilityController.cs)
![Data](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/Protype/Strategy%20game%20for%20SENIOR%20PROJECT/Models/Ability.cs)

### UnitAbilty
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/ReadMe%20Images/Data%20Access/UnitAbility.PNG)
UnitAbilty scheme used to assaigne abilites to units. Later the logic engine will do a check to determ the abilities effects.
![Controller](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/Protype/Strategy%20game%20for%20SENIOR%20PROJECT/Controllers/UnitAbilityController.cs)
![Data](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/ed4c77ee02bbd343d88d526f6bc0ebe23362dbb6/Protype/Strategy%20game%20for%20SENIOR%20PROJECT/Models/UnitAbility.cs)



