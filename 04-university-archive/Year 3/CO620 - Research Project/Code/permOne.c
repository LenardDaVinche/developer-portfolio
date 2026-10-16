#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main() {
	__uint8_t* bytePtr;
	bytePtr = (__uint8_t*)malloc(sizeof(__uint8_t)); //give me a byte pointer
	*bytePtr = 30;
	__uint8_t* abovePtr = bytePtr+sizeof(bytePtr); //track the value of the address above it
	printf("byte value at pointer = %d\n Address above = %d\n Now lets write an int at the address (overflow)\n", *bytePtr, *abovePtr);
	
	__uint64_t* intPtr;
	memcpy(bytePtr, intPtr, 16);
	*intPtr = 0xffffffffffffffff; //max 64bit integer value
	printf("byte now = %d\n, above now = %d", *bytePtr,*abovePtr);
}