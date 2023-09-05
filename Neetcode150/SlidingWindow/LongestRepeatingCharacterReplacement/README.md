Longest repeating character replacement
* This problem is is kinda hard compared to the previous ones
* Same principal though, sliding window
* The main idea with this one is to constantly check the 'cheapest' way to switch replace the string (the current window)
* This is easily found by checking for the most common character in the current window, the current string that is
* then since you can find the leftover by subtracting the window length found by subtracting l from r and adding 1
* you can now find the amount of replacements it would take to convert the current string, being windowLength - mostCommonCharacter
* If that value is less than or equal to k, where k is the max amount of replacements you can do, then you can continue moving the right side of the window
* Otherwise (the case where it is more than k replacements), you can then shift the left side of the window over till it no longer is more than k.
  ![LongestRepeatingCharacterReplacement_Run](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/dbc355a2-9dfc-4baa-8702-49eb5f7f2cf5)
