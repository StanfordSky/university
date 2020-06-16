#define _CRT_SECURE_NO_WARNINGS
/*

	Имеется файл с наименованиями компьютерных
	комплектующих в алфавитном порядке.Создать индексный файл для
	поиска наименования товара.

*/
#include <stdio.h>  
#include <string.h>

int offsets[26];


// Чтение файла с названиями комплектующих в алфавитном порядке.
void ReadFile() {

	FILE* mf;
	char str[50];
	char* estr;

	int fseenum = 0;

	mf = fopen("info.txt", "r");
	if (mf == NULL) { printf("Error\n"); return ; }

	printf("Strings: \n");
	//Чтение (построчно) данных из файла в бесконечном цикле
	while (1)
	{
		// Чтение одной строки  из файлa
		estr = fgets(str, sizeof(str), mf);

		//Проверка на конец файла или ошибку чтения
		if (estr == NULL)
		{
			// Проверяем, что именно произошло: кончился файл
			// или это ошибка чтения
			if (feof(mf) != 0)
			{

				printf("\nReading is finished\n");
				break;
			}
			else
			{

				printf("\nReading is finished(Error)\n");
				break;
			}
		}

		// Считаем позицию каждой буквы алфавита для составление индексного файла
		fseenum += strlen(estr) + 1;
		if (strlen(estr) == 3)
			printf("%d - %s", fseenum, estr);
	}
	// Закрываем файл
	printf("Closing file: ");
	if (fclose(mf) == EOF) printf("Error\n");
	else printf("Completed\n");
}


//Создание файла удобного демонстрационного индексного файла
void CreateIndexDemonstrationFIle()
{
	FILE* mf;
	FILE* pf;

	char str[20];
	char* estr;

	int fseenum = 0, i = 0;
	mf = fopen("info.txt", "r");
	pf = fopen("index.txt", "w");
	if (mf == NULL) { printf("Error\n"); return; }

	
	//Чтение (построчно) данных из файла в бесконечном цикле
	while (1)
	{
		// Чтение одной строки  из файлa
		estr = fgets(str, sizeof(str), mf);
		
		//Проверка на конец файла или ошибку чтения
		if (estr == NULL)
			break; 
		// Считаем позицию каждой буквы алфавита для составление индексного файла
		fseenum += strlen(estr)+1;

		//Формируем читабельный вид для каждой строки
		char third[30];
		snprintf(third, sizeof third, "%d - %s", fseenum, estr);
		
		//Записываем данные в файл
		if (strlen(estr) == 3)
			fputs(third, pf);	
	}
	// Закрываем файлы
	fclose(mf);
	fclose(pf);

}

void SearchInFile(int seek) {
	FILE* mf;
	char str[50];
	char* estr;

	mf = fopen("info.txt", "r");
	if (mf == NULL) { printf("Error\n"); return; }

	//Производим заданый сдвиг
	fseek(mf, seek, 0);
	// Чтение одной строки  из файлa
	estr = fgets(str, sizeof(str), mf);

	//Проверка на конец файла или ошибку чтения
	if (estr == NULL)
		return;

	printf("\n\nIn position %d: %s\n\n",seek, estr);

	// Закрываем файл
	fclose(mf);

}

int main(void)
{
	CreateIndexDemonstrationFIle();
	ReadFile();
	
	SearchInFile(241);

	return 0;
}