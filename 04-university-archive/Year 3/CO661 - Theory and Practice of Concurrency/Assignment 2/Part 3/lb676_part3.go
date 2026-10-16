//Part 3: The Assistant

//3.a
package main

import( 
	"fmt"
	"time"
	"math/rand"
)

func main() {
	dent := make(chan chan int)
	wait := make(chan chan int, 5)
	hwait := make(chan chan int, 100)
	lwait := make(chan chan int, 5)
	go dentist(wait, dent)
	high := 10
	low :=  3
	
	for i := low; i < high; i++ {
		go patient(hwait, dent, i)
	}
	
	for i := 0; i < low; i++ {
		go patient(lwait, dent, i)
	}
	
time.Sleep(50 * time.Second)
}

//unfinished
func assistant(hwait chan chan int, lwait <-chan chan int, wait chan<- chan int){
	var currentPatient chan int
		select{
		case currentPatient = <-hwait:
			fmt.Println("Assistant has a High Priority patient from the waiting room")
			break
		default:
			fmt.Println("No high priority patiens")
			select{
			case currentPatient = <-lwait:
				fmt.Println("Assistant has got Low Priority patient from the waiting room")
				break
			default:
				
			}
		}
}

func dentist(wait chan chan int, dent <-chan chan int){
	for {
		var currentPatient chan int
		select{
		case currentPatient = <-wait:
			fmt.Println("Dentist has got a patient")
			break
		default:
			fmt.Println("Dentist is sleeping")
			currentPatient = <-dent
			
			fmt.Println("Dentist has got someone directly")
		}
		
		fmt.Println("Dentist is awake and working")
		currentPatient<-1
		n := rand.Intn(3)
		time.Sleep(time.Duration(n) * time.Second)
		currentPatient<-2
		<-currentPatient
		fmt.Println("Dentist is done with a patient")
	}
}

func patient(wait chan<- chan int, dent chan<- chan int, id int){
	channel := make(chan int)
	select{
	case dent<-channel: // if the dentist is sleeping (reading on dent) send on dent
		fmt.Println("Patient goes to wake up sleeping dentist")
		break
	default: // if the dentist is busy (not reading on dent) sent on wait
		fmt.Printf("Patient %d is waiting\n", id)
		wait<-channel
	}
	<-channel
	fmt.Printf("Patient %d is having a treatment!\n", id)
	<-channel
	fmt.Printf("Patient %d has shiny teeth!\n", id)
	channel<-3
}

//3.b
//
//