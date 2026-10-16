
(* Initial Exercises - Part 1 *)
(* By: Leandro J. Gomes Baroca (lb676) *)

(* Exercise 1 *)

let rec count (x : 'a) (xs : 'a list) : int =
    match xs with
    | [] -> 0
    | (y::ys) -> if y==x then 1 + (count x ys) else (count x ys)

(* Exercise 2 *)

let rec nub (xs : 'a list) : 'a list = 


(* Exercise 3 *)


let rec nub (xs : 'a list) : 'a list =


(* Exercise 4 *)

let rec subseq (xs : 'a list) (ys : 'a list) : bool = 
    match xs, ys with
    | [] -> true
    | (x::xs, y::ys) -> if y==x && subseq xs ys then true else subseq xs ys

(* Exercise 5 *)

let rec frontseq (xs : 'a list) (ys : 'a list) : bool = 
    match xs,ys with
    | [] -> true
    | (x::xs, y::ys) -> if y==x && frontseq xs ys then true else false

(* Exercise 6 *)

let rec seq (xs : 'a list) (ys : 'a list) : bool =
    match ys with
    | [] -> false
    | y::ys -> if frontseq (xs) (ys) then true else seq (xs) (yss)

(* Exercise 7 *)

type turn_result = Draw | P1Win | P2Win

(* Exercise 8 *)

type final_result = Draw | P1Win | P2Win

(* Exercise 9 *)

let sum (x : int) : bool =
    if x then true else then false

let rec game (xs : 'a list) (ys : 'a list) =
    match xs, ys with
    | [], [] -> []
    | [], _ -> []
    | _, [] -> []
    | x::xs, y::ys ->
        (if sum (x + y) then P1Win else P2Win else if x = y then Draw) :: (game xs ys)

(* Exercise 10 (Game) *)


(* Exercise 10 (Strategy) *)


(* Exercise 11 *)


(* Exercise 12 *)
