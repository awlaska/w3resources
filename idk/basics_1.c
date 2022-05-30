#include <stdio.h>

void _001(){
    printf("\nWrite a C program to print your name, date of birth. and mobile number.");

    char _001_name[200];
    int _001_year, _001_month, _001_day, _001_phone;

    printf("Insert your name: ");
    scanf("%i", &_001_name);

    printf("Nome controlo: %c", _001_name);

    printf("Insert your year, month and date of birth: ");
    scanf("%i %i %i", &_001_year, &_001_month, &_001_day);

    printf("Insert your phone number: ");
    scanf("%i", &_001_phone);

    printf("Name:	%c\nDOB:	%i/%i/%i\nMobile:	%i", _001_name, _001_year, _001_month, _001_day, _001_phone);
}

void _002(){
    print("\n");
}

int main(){

    int i;

    printf("Insert the number of the exercise you want: ");
    scanf("%i", i);

    switch (i){
        case 1:
            _001();
            break;
        case 2:
            _002();
            break;
    }
    return 0;
}
