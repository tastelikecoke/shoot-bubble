Blister Wizard
------------
A Unity game clone of bubble shooter games.

How To Play
-----------
1. Use the mouse to move the cannon.
2. Click the mouse to fire a bubble at the cursor's direction.
3. Connect 3 or more bubbles of the same color to make them fall down.
4. You win when there are no more bubbles left.

Mechanics
---------
* There are 5 bubble colors: Red, Cyan, Yellow, Green, and Purple.
* A special bubble color: Rainbow, will turn into one of the 5 colors upon hit.
* Bubbles that are no longer connected to the ceiling shall fall down.
* 3 or more same colored bubbles will not pop until another bubble of same color hits them.
* The player will lose if the cannon is blocked by bubbles.

Level Editing
-------------
A file in the Assets/Data/level1.data determines the layout of the level.
The file contains several characters, some newlines, and some characters 0-5.
Each character, except for newline, represents a bubble in a grid.
The character's number, from 1-5, represents the color Red, Cyan, etc.
The character 0 represents an empty space.
The file can only represent 50 bubbles rendered in 4 rows.


Build Notes
-----------

### Build 5
* Include 5 bubble colors
* Fix start button using obsolete library
* Add special bubble that only gains color when connected to bubbles
* Load level through .data file in the assets
* Reformat whitespaces to be more consistent
* Add pop sound effects


### Build 4
* Make similar colored bubbles pop and isolated bubbles explode instead
* Added forest background in the play area
* Created a title menu and start button
* Add "play again" button for the player to play again
* Add catch for possibility of out-of-bounds bubble

### Build 3
* Added popping of similar colored bubbles through breadth first search
* Make bubbles fall down instead of pop
* Make bubbles which are not connected to top layer fall down
* Added win condition and win message


### Build 2
* Added script for creating hexagonal grid of bubbles
* Make cannon balls trigger creation of bubbles on collision
* Fix directory structure
* Fix tab indents in code and other style issues

### Build 1
* Added main Unity project
* Added bubble launching

