#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main() {
	// Address swap hack. Idea: we have a protected CHERI pointer without perms,
	// can we swap the adddress part into a CHERI pointer with perms we like.

	__uint64_t* secretPtr;
	secretPtr = (__uint64_t*)malloc(sizeof(__uint64_t)); // imagine we dont have perms
	*secretPtr = 1;

	__uint64_t* ourPtr;
	ourPtr = (__uint64_t*)malloc(sizeof(__uint64_t)); // imagine we do have perms
	printf("Fail One");
	//memcpy(ourPtr+8, secretPtr+8, 8); // The metadata and address in a CHERI ptr take 8 bytes each
	printf("Fail Two");

	*ourPtr = 42;

	printf("The value at the secret is %lu\n", *secretPtr);
}