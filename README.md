

Assignment (Read the whole assignment before starting)

### Part 1: Decisions

Pick one of the following immutable datastructures

1) `LazyQueue` as described in [`Okasaki, C. (1995). Simple and efficient purely functional queues and deques. Journal of Functional Programming, 5, 583–592`](https://www.cambridge.org/core/journals/journal-of-functional-programming/article/abs/simple-and-efficient-purely-functional-queues-and-deques/7B3036772616B39E87BF7FBD119015AB#access-block). Described in section 4

2) `BinomialPriorityQueue` as described in [`Brodal, G. S., & Okasaki, C. (1996). Optimal purely functional priority queues. Journal of Functional Programming, 6, 839–857`](https://www.cambridge.org/core/journals/journal-of-functional-programming/article/abs/optimal-purely-functional-priority-queues/1A799209383FD6535F90715192863C13). Section 2 and Figure 3

Read up and until before implementing these, to get an idea of what the assignment includes.

Hint: LazyQueue require you to look into Sequences in F#.

Hint: BinomialProrityQueue 

### Part 2: Implementation

Implement the chosen data structure in F# - make sure you do not alter existing copies.

There are a `interface` for each in the fsi file and an implentation file .fs with the correct definitions. Feel free to add all the helper methods you want/need. But keep the interface as is. There are also an type definition, this is my version, and can be changed - since its only internal.


### Part 3: Performance

For different input sizes figure out how you want to test that your data structure holds the promised bounds. Use Random.org if you need random data.

E.g. use data sizes of 100000, 400000, 800000, 1200000, 1600000, 2000000, 2400000, 2800000, 3200000, 3600000 or use *10 or *100 if you computer can hold this amount of elements.

This properly requires a bit of time, since working on big lists is expensive and because you want to make an average over a number of inserts/delete.

Hint: In LazyQueue the remove operation is `O(log n)` worstcase

Hint: In BinomialPriorityQueue both insert and deleteMin take `O(log n)` worst case.

### Part 4: Visualize

Since the complexity for these operations is Logarithmic, consider plotting this on a logarithmic paper/chart - who uses paper :)

### Part 5: Handin

Handin link to repository + charts on Brigthspace