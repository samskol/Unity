# otherStuff

##### Scenes: 

getBonePosition gives the transform position of an empty gameObject attached to a character at a certain animation frame.
You need an animator Controller that has all the animations attached. 
After that just attach the script getBonePosition.cs to the character and add in the animamtion clip and frame.

ScriptableObjects requires no setup. Hit play and when the player hits the object a Game Event will go off using SO architecture.

##### Editor and debug functions:

The levelSettings SO and levelSettings script show how to edit and create your own menu while saving right in the editor.

the debug script fixCharData will take charData and normalize the values. All animation chances should add up to 100 and all 
(semiVal,aimVal,miss) elements should add up to 100. Sometimes you have to click the function twice to get all values to 100.

debug/print global posiiton will take any selected object and show its global position.
