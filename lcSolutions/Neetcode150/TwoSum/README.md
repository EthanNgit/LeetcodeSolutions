Two sum is a pretty good mapping problem

*  First you can create a map, where we will map the value n to the index i
*  Then in python to save some extra typing we can enumerate nums, calculating the difference of the target and the current value
*  Which makes it possible to now check, if that value is in the map then we can return the Maps value of the difference (returns a index) and the current index we are at
*  Else we can just add it to the map and move on

*  This works because there is a garunteed solution, and that means even if we dont find the value in the first run, by the end it will be garunteed to be found
