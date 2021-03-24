module FunctionDatastructures.LazyQueue

open System

type LazyQueue<'a> = (seq<'a> * int * 'a list)


let empty (): LazyQueue<'a> = Seq.empty, 0, []

let isEmpty (queue: LazyQueue<'a>): bool = 
    match queue with
        | (_,0,_) -> true
        | _ -> false


let rec rot (left: seq<'a>) (right: 'a list) (returnSeq: 'a list) : 'a list = 
    match Seq.length left with
        | 0 -> (List.head right) :: returnSeq
        | _ -> (Seq.head left) :: (rot (Seq.tail left) (List.tail right) ((List.head right) :: returnSeq))

let makeQ (queue: LazyQueue<'a>): LazyQueue<'a>=
    let (s,i,l) = queue
    match (i, l.Length) with
        | (x,y) when x >= y -> queue
        | (x,y) when x < y -> (seq (rot s l ([])), i+l.Length, [])
        | _ -> raise (ArgumentException "something went wrong")
        

let cons (a: 'a) (queue: LazyQueue<'a>): LazyQueue<'a> = 
    let s,i,l = queue
    makeQ (s ,i ,a::l)


let head (queue: LazyQueue<'a>): 'a = 
    let s,_,_ = queue
    Seq.head s


let tail (queue: LazyQueue<'a>): LazyQueue<'a> =
    let s,i,l = queue
    makeQ (Seq.tail s, i-1,l)


let rec insertLq (list: 'a list) (myLQ: LazyQueue<'a>): LazyQueue<'a> =
    match list.Length with
        | 0 -> myLQ
        | _ -> insertLq list.Tail (cons list.Head myLQ)

