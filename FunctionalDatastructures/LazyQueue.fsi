module FunctionDatastructures.LazyQueue

type LazyQueue<'a> = (seq<'a> * int * 'a list)

val empty: unit -> LazyQueue<'a>
val isEmpty: LazyQueue<'a> -> bool

val cons: 'a -> LazyQueue<'a> -> LazyQueue<'a>
val head: LazyQueue<'a> -> 'a
val tail: LazyQueue<'a> -> LazyQueue<'a>

val insertLq: 'a list -> LazyQueue<'a> -> LazyQueue<'a>


