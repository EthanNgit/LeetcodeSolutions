Evaluate reverse polish notation
* This is a pretty easy stack problem, the hardest part is probly the division reuirements.
* So reverse polish notation is where the numbers come first then have operators after them.
* This makes it great to solve with a stack as we can add numbers to a stack then when an operation comes we can just pop the last 2 numbers and append the new sum and continue
* So for each character in this array (remember they are characters not integers so you have to convert the integers) you check what it is operator or number
* If it is a number add it to the stack and move on, if it is not then on the "+" or "*" operator you can directly just use stack.pop on them
* For "-" and "/" you have to save the result first so you can use the second number first
* After any operation just add it back to the stack and continue till the last operator, since it is garunteed to have a solution
  ![EvaluateReversePolishNotation_RUN](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/3b028ce4-0344-42f8-bf8a-074e45fad25b)
