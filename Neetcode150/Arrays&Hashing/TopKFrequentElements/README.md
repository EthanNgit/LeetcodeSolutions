Top K Frequent Elements
* There are more readable methods you can use, i think python just has a built in most frequent method with the counter as well
* Basically you can think that if you want the most frequent, a counter counts the occurance when converting
* Then if you sort that counter by the values not the keys, you then get the Counter in order of least occuring values to most
* Then reverse it so the most occuring are at the front, and then take the first k values
  ![TopKFrequentElements_Run](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/eecbb172-5e44-4a97-9303-596e415a387b)
