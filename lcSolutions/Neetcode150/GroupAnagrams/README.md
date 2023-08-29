Group Anagrams
* given that each anagram will be returned in a list we can map the word to all of its anagrams
* The easiest way to do that is to first sort the current string, which if another word is an anagram it will be the same
* Then in a map we can append the current string to the sorted version, in python you can use a default dict to avoid getting missing key errors
* Then at the end you can simply return a list of the maps values (which is just list of strings for each anagram).
 
 ![GroupAnagrams_Run](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/8b4bd92e-4f9c-4856-8d2c-7ca0d09ec520)
