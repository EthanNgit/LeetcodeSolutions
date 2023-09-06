Valid Parentheses
* This is a basic Stack problem
* Stacks are Last in First out (LIFO) based so that means they can be good for this situation
* First you can create a map so as you go into the string you can check if it is a opening or closing parentheses
* Then loop through the string and check if its not in map, if it is append it and then continue to the next loop
* It is important to break that current loop because there could be nothing in the stack yet
* Then check the failing conditions, this saves performance technically as it should return early in the case you do not have valid parantheses
* These conditions are the stack is empty (and there is still a closing parentheses) or the last in element of the stack is not a opening of the current closing
* otherwise we can append the parentheses to the stack and continue
* ![ValidParentheses](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/dcfffcbc-1f02-4ac0-9d03-33a4fe4b29e3)
