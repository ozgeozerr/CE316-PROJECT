#include <stdio.h>

int main() {
    char input[10];

    printf("Enter a string (up to 10 characters): ");
    scanf("%9s", input); // Reading up to 9 characters to avoid buffer overflow

    printf("You entered: %s\n", input);

    return 0;
}
