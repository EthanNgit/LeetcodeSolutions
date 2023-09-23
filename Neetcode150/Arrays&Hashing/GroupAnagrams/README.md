Group anagrams

* This problem can be tricky to figure out the first time, but then you remember sorting
* for each word you can check a hashmap with the key as the sorted version of the word (bc anagrams have to be the same letters, if you sort a word any anagram will be the same sorted word)
* then you know you can append anagrams to this value of the word, then return the values of the hashmap

![GroupAnagrams_Run](https://github.com/EthanNgit/leetcodeSolutions/assets/105979510/b7faa775-0d62-4b94-969b-8b097aa2ec4a)
