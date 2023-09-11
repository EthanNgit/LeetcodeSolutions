Longest consecutive sequence.
* This problem is easy. (idk what happned before for the errors, this time was an indentation error)
* Since you have to do it in O(n) time that means you cant sort it
* But that means you can use a hashmap(set) in this case for O(1) lookup
* Simply convert the array to a set in python (which is O(n))
* Then loop through it and check for each number if there is a smaller number in the set
* If there is, then just skip it for now, we are looking to find the smallest numbers
* Then while the number plus the length of the sequence, ie the length of string
* Check if it is in the map, if it is then you can increase the length till there isnt
* Store result in a variable and move on
* Although this is not exactly O(n) given that you can potentially loop some elements 2 times
* Since it averages out to linear runtime in terms of calculations it runs.
  ![LongestConsecutiveSequence](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/a5940709-781a-4da3-852b-a7f3f7e235a5)
