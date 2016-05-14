Blister Wizard
------------
A Unity game clone of bubble shooter games.

How To Play
-----------
1. Use the mouse to move the cannon.
2. Click the mouse to fire a bubble at the cursor's direction.
3. Connect 3 or more bubbles of the same color to make them fall down.
4. You win when there are no more bubbles left.
5. You can click "play again" to play again after winning.

Build Notes
-----------

### Build 5
* Include 5 bubble colors
* Fix start button using obsolete library
* Add special bubble that only gains color when connected to bubbles
* Load level through .data file in the assets
* Reformat whitespaces to be more consistent


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

