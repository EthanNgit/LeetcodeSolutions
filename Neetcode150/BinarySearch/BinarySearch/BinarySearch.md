Binary search
* Simple algorithm here
* Basically if a array is sorted, you know that you can use a binary search to search for things in log time
* you can check each side with pointers and set a mid point between the two, if they are the target return it
* Otherwise you can check if the left side is less than the target, which means target is further down the list
* and the middle is not target, you can simple search the other zone (the right side) only skipping multiple potential searches
* ![BinarySearch_RUN](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/7fc658bf-f1b7-4036-aabc-715bba7fa817)
* a
