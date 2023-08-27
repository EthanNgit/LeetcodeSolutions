Initially I used a different method, which was checking if the sets were equal length to each other (otherwise it would be impossible to be an anagram anyways), then checking if the sorted version of each string would match, if they do its an anagram... 
This is O(s log(n)), where s is the amount of strings sorted, and log(n) is the sorting.

Then since I was using python, i figured it would be easier (and more performant) to use the builtin counter datastructure
O(sn), where s is the amount of strings converted to a counter, and n is the time it takes to convert to a counter.

![ValidAnagram_Run](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/204b61ea-943f-449f-a4fb-fe189cd73896)
