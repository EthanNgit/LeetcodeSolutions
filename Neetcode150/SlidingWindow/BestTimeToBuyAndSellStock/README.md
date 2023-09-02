Best Time to Buy and Sell Stock

* Pretty simple (Ignore the failed runs, i was hacked)
* So basically its like two pointers, but instead you start both at the beginning
* Start from the left and check while the right pointer sweeps the array if the maxProfit changed
* Max profit is found by subtraction the right from the left
* Then if the right pointer is less in value that the left you know that the left pointer should
  move there since it would save more money
* Finally if thats the case just set the left pointer to the right pointer
  ![BestTimeToBuyAndSellStock](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/31f9d2ff-22e9-423b-8d6b-694f5a6fecf7)
