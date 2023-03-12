# Reqirments
| ID  | Requirement |
| ------------- | ------------- |
| 1  | The player should be able to set up the team |
| 1.1| The player should be able to reset the starting state|
| 2  | The player should be able to start the game  |
| 2.1| The player should be able to end the game  |
| 3  | The player should be able to Control their units once per round|
| 3.1  | The player should be able to make a unit move|
| 3.2  | The player should be able to make a unit attack|
| 4 | The player should be able to end a round|
| 5 | the game should be able to keep track of the game rules|

# Protype Sketch
[Protype Sketch](../Protype/protype.html)
![](https://github.com/WDCaldwell/Strategy-Game-For-SENIOR-PROJECT/blob/457ea2edb0308d056253b88b6e96743052311316/Protype/Protype%20Sketch.png)
Note that this is rough boxing draft for a game state.
Also is missing out on a "Start menu" or other pop up menus planed.

## Explanation
Their is 3 main areas of the game. 
+ Red team
+ Play Area
+ Blue team
### Blue team and red team
+ These two are mirror with it being split up with an identifying text that will be lined up with some matching-colored background shading later.
+ Along side each unit will get its own placement. Current plan is each spot showing each minions current health and attack, abilities, and if they have moved this turn.
+ Note number of minions are to be determined based off board size.
### Play Area
+ Board is the focus in this block up it is a 5x5 square. This may be increased in the final product but 5x5 is the minimal size.
+ The Board will display where both teams’ units are on the board. Graphics are in flux currently.
+ The Activity log lists what the current player intends to do with the unit they are currently moving. Note it is planed that only one unit can move at a time and only once per round. With both taking a turn first before a new round.
+ It is currently undecided if it’s a one unit activation be fore switching active team or all one team units activate then swap to the other team for the definition of term turn
+ The activity log also contains the buttons that will confirm a queued up action, reset the choice, or bring up a pop up menu that is planed to end the game and start a new or exit out of the program. Saving a current match is a potential feature.
