//Part 1: The Dentist Problem
package main

import (
	"fmt"
	"math/rand"
	"time"
)

func main() {
	m := 5
	n := 5
	dent := make(chan chan int)    // creates a synchronous channel
	wait := make(chan chan int, n) // creates an asynchronous channel of size n
	go dentist(wait, dent)
	time.Sleep(3 * time.Second)

	for i := 0; i < m; i++ {
		go patient(wait, dent, i)
		time.Sleep(1 * time.Second)
	}

	time.Sleep(1000 * time.Millisecond)
}

func dentist(wait <-chan chan int, dent <-chan chan int) {
	for {
		var currentPatient chan int
		select {
		case currentPatient = <-wait:
			fmt.Println("Dentist has got someone from the waiting room")

		default:
			fmt.Println("Dentist is sleeping")
			currentPatient = <-dent

			fmt.Println("Dentist has got someone directly")
		}

		fmt.Println("Dentist is awake and working")
		currentPatient <- 1

		n := rand.Intn(3)
		time.Sleep(time.Duration(n) * time.Second)

		currentPatient <- 2
		<-currentPatient
		fmt.Println("Dentist is done with a patient")
	}
}

func patient(wait chan<- chan int, dent chan<- chan int, id int) {
	channel := make(chan int)
	select {
	case dent <- channel: // if the dentist is sleeping (reading on dent) send on dent
		fmt.Println("Patient goes to wake up sleeping dentist")

	default: // if the dentist is busy (not reading on dent) sent on wait
		fmt.Printf("Patient %d is waiting\n", id)
		wait <- channel
	}
	<-channel
	fmt.Printf("Patient %d is having a treatment!\n", id)
	<-channel
	fmt.Printf("Patient %d has shiny teeth!\n", id)
	channel <- 3
}
