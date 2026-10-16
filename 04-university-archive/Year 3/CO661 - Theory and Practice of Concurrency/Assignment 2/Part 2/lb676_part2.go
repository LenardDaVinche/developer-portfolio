//Part 2: Introducing Priorities

//2.a
package main

import( 
	"fmt"
	"time"
	"math/rand"
)

func main() {
	dent := make(chan chan int)
	hwait := make(chan chan int, 100)
	lwait := make(chan chan int, 5)
	go dentist(hwait, lwait, dent)
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

func dentist(hwait chan chan int, lwait <-chan chan int, dent <-chan chan int){
	
	// timer := time.NewTimer(2 * time.Second)
	// go func(){
	// 	for{
	// 		select{
	// 			case timer 
	// 				<-timer.C
	// 			default:
	// 				<-ch
	// 		}
	// 	}
	// }()
	
	for {
		var currentPatient chan int
		select{
		case currentPatient = <-hwait:
			fmt.Println("Dentist has got High Priority patient from the waiting room")
			break
		default:
			fmt.Println("No high priority patients")
			select{
			case currentPatient = <-lwait:
				fmt.Println("Dentist has got Low Priority patient from the waiting room")
				break
			default:
				fmt.Println("Dentist is sleeping")
				currentPatient = <-dent
				
				fmt.Println("Dentist has got someone directly")
			}
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

//2.b
//Assuming there is no fair semantics within Golang, then hwait would continously have patients being added into due to FIFO, 
//meaning that the 1 patient in lwait will be waiting indefinetely.
//To implement fairness within this scenario, would be to have a timer to schedule when a patient would be getting treatment. 
//As to have the ability to move low priority patients to high priority, 
//but still be able to serve the patients that arrived first so that starvation would not occur.