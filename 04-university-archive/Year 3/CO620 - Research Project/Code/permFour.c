#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <cheri.h>
int main() {
	// Benign memcpy. Idea: use memcpy like we do in the perm swap and address swap hacks,
	// but try not to get in trouble.

	__uint64_t* secretPtr;
	secretPtr = (__uint64_t*)malloc(sizeof(__uint64_t)); // imagine we dont have perms
	*secretPtr = 1;

	__uint64_t* ourPtr;
	ourPtr = (__uint64_t*)malloc(sizeof(__uint64_t)); // imagine we do have perms

	//memcpy(ourPtr, secretPtr, 16); // The metadata and address in a CHERI ptr take 8 bytes each
	cheri_address_get(secretPtr);

	printf("The value at the secret is %lu\n", *secretPtr);
}