#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <cheri.h>
int main() {
	// Benign memcpy. Idea: use memcpy like we do in the perm swap and address swap hacks,
	// but try not to get in trouble.
	__uint64_t* ourPtr;
	ourPtr = (__uint64_t*)malloc(sizeof(__uint64_t));
	 // imagine we do have perms
	ourPtr = cheri_program_counter_get(); //print the value of the PCC
	*ourPtr = 60;
	printf("The value at the secret is %lu\n", *ourPtr);
}