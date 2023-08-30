- Twosum two is very straightforward
 * Given that the array is sorted that means
 *  if you are looking for a sum you can start with 
 *  a pointer at the beginning of an array and end of an array
 *  then while those pointers dont cross each other move them accordingly:
 *  if they add up to target return the pointers in an array + 1 (wierd for this problem)
 *  else if the sum is less than target then move the left pointer up since its sorted moving 
 the left pointer up will increase our sum
 *  else if the sum is more than the target move the right pointer down...
