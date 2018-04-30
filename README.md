# SALAD CHEF #
Demo of a "programmer-art” version of a salad chef simulation in Unity 
## TOOLS USED ##
* UNITY 3D 2017.2.0f3
* Visual Studio Code
* Adobe PhotoShop

## SUPPORTED PLATFORMS ##
Theoritycally it should support all the platforms supported by Unity. I have Tested on Windows and Mac, So far I havn't noticed any platform dependent bugs.


## CODE STRUCTURE ##
Most of the codes can be found inside **Scripts/Controllers** Folder. Games Constants are defined in Constants.cs.
**Gamecontroller.cs** handles the game play of the application . It also handles Reloading the game and resetting everyting.
**HUDController.cs** handles the display of Scores and Times. 

**Player Controller.cs** handles the follwing functionalities.
* Movement of Player
* Picking Up Vegetables from Sides
* Droping Vegetables to Chopping Board
* Droping Combinations to Trash
* Droping to Customer Tables.

Most of the collisions are handled using Triggers and Tags. All the definations of the tags can be found in constants.cs

##TODO##
* Adjustment of Colliders. 
* Position change after picking from plate
* Display timer when player can't move
* Resize the Game play Area 




