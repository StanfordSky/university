#define _CRT_SECURE_NO_WARNINGS
/*

	������� ���� � �������������� ������������
	������������� � ���������� �������.������� ��������� ���� ���
	������ ������������ ������.

*/
#include <stdio.h>  
#include <string.h>

int offsets[26];


// ������ ����� � ���������� ������������� � ���������� �������.
void ReadFile() {

	FILE* mf;
	char str[50];
	char* estr;

	int fseenum = 0;

	mf = fopen("info.txt", "r");
	if (mf == NULL) { printf("Error\n"); return ; }

	printf("Strings: \n");
	//������ (���������) ������ �� ����� � ����������� �����
	while (1)
	{
		// ������ ����� ������  �� ����a
		estr = fgets(str, sizeof(str), mf);

		//�������� �� ����� ����� ��� ������ ������
		if (estr == NULL)
		{
			// ���������, ��� ������ ���������: �������� ����
			// ��� ��� ������ ������
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

		// ������� ������� ������ ����� �������� ��� ����������� ���������� �����
		fseenum += strlen(estr) + 1;
		if (strlen(estr) == 3)
			printf("%d - %s", fseenum, estr);
	}
	// ��������� ����
	printf("Closing file: ");
	if (fclose(mf) == EOF) printf("Error\n");
	else printf("Completed\n");
}


//�������� ����� �������� ����������������� ���������� �����
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

	
	//������ (���������) ������ �� ����� � ����������� �����
	while (1)
	{
		// ������ ����� ������  �� ����a
		estr = fgets(str, sizeof(str), mf);
		
		//�������� �� ����� ����� ��� ������ ������
		if (estr == NULL)
			break; 
		// ������� ������� ������ ����� �������� ��� ����������� ���������� �����
		fseenum += strlen(estr)+1;

		//��������� ����������� ��� ��� ������ ������
		char third[30];
		snprintf(third, sizeof third, "%d - %s", fseenum, estr);
		
		//���������� ������ � ����
		if (strlen(estr) == 3)
			fputs(third, pf);	
	}
	// ��������� �����
	fclose(mf);
	fclose(pf);

}

void SearchInFile(int seek) {
	FILE* mf;
	char str[50];
	char* estr;

	mf = fopen("info.txt", "r");
	if (mf == NULL) { printf("Error\n"); return; }

	//���������� ������� �����
	fseek(mf, seek, 0);
	// ������ ����� ������  �� ����a
	estr = fgets(str, sizeof(str), mf);

	//�������� �� ����� ����� ��� ������ ������
	if (estr == NULL)
		return;

	printf("\n\nIn position %d: %s\n\n",seek, estr);

	// ��������� ����
	fclose(mf);

}

int main(void)
{
	CreateIndexDemonstrationFIle();
	ReadFile();
	
	SearchInFile(241);

	return 0;
}