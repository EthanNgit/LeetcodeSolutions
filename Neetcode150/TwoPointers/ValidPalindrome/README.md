-ValidPalindrome
 *  Pretty simple two pointer example
 *  there are two ways to go about this with two pointers
 *  one you format the string initially, saving effort on the 
 main algorithm or you move according to the string during
 the algorithm, which is more work, so i chose to format the string
 beforehand.
 *  Using list comprehension in python its pretty simple you just only take
 alpha numeric characters and store the lower case version in a list
 *  then while the left pointer is not crossing the right pointer 
 check to see if the characters are different, because if they are
 that means its not a palindrome and you can return false
  * if it gets through the entire loop without that, you can return true
![ValidPalindrome_Run](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/9c86785c-a049-4444-adca-ea31ef85c30e)
