#include <cheri.h>
#include <cheri/cheric.h>
int main() {
// Benign memcpy. Idea: use memcpy like we do in the perm swap and address swap hacks,
// but try not to get in trouble.
__uint64_t* ourPtr;
ourPtr = (__uint64_t*)malloc(sizeof(__uint64_t));
// imagine we do have perms
ourPtr = cheri_program_counter_get();

__daddr_t intPtr = cheri_cap_to_ptr(ourPtr, 8);
__uint64_t* pcc;
pcc = (__uint64_t*)malloc(sizeof(__uint64_t));
int tag = cheri_gettag(pcc);

printf("Tag value = %d\n", tag);
pcc = __cheri_set_low_ptr_bits(pcc, intPtr);
tag = cheri_gettag(pcc);

printf("Tag value = %d\n", tag);
//*pcc = 20;
printf("The value at the secret is %lu\n", sizeof(pcc));
}