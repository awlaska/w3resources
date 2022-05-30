#include <stdio.h>

int _001(){
	printf("\nWrite a C program to print your name, date of birth. and mobile number.");
	
	char _001_name[50];
	int _001_year, _001_month, _001_day, _001_phone;
	
	printf("\n\nInsert your name: \n");
	scanf("%s", _001_name);
	
	printf("\nNome controlo: %s", _001_name);
	
	printf("\nInsert your year, month and date of birth: \n");
	scanf("%i %i %i", &_001_year, &_001_month, &_001_day);
	
	printf("\nInsert your phone number: ");
	scanf("%i", &_001_phone);
	
	printf("Name:	%s\nDOB:	%i/%i/%i\nMobile:	%i", _001_name, _001_year, _001_month, _001_day, _001_phone);
}

int _002(){
	printf("\nWrite a C program to get the C version you are using.");
	
	if (__STDC_VERSION__ >=  201710L){
		printf("We are using C18!\n");
		else if (__STDC_VERSION__ >= 201112L){
			printf("We are using C11!\n");
			else if (__STDC_VERSION__ >= 199901L){
				printf("We are using C99!\n");
				else{
					printf("We are using C89/C90!\n");
				}
			}
		}
	}
}

int main(){
	
	int i;
	
	printf("Insert the number of the exercise you want: ");
	scanf("%i", &i);
	
	switch (i){
		case 1:
			_001();
			
			break;
		case 2:
			_002();
			break;
		case 0:
			return 0;
			break;
	}
	return 0;
}
