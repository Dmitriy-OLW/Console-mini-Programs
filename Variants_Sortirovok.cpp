#include <iostream>
#include <time.h>

int main() {
    // Cортировка одномерного массива
    int n;
    int mas[100];
    srand(time(NULL));
    bool flag = true;
    scanf_s("%d", &n);
    for(int i = 0; i <n; i++){
        mas[i] = rand() % 10;
    }

    for(int i = 0; i < n; i++){
        printf("%2d", mas[i]);
    }

    printf("\n");

    while(flag){
        flag = false;
        for(int i = 0; i < n - 1; i++){
            if (mas[i] > mas[i + 1]){
                int z = mas[i];
                mas[i] = mas[i + 1];
                mas[i + 1] = z;
                flag = true;
            }
        }
    }

    for(int i = 0; i < n; i++){
        printf("%2d", mas[i]);
    }


    // Сортировка двумерного массива змейкой
    int n, m;
    int mas[100][100];
    bool flag = true;
    srand(time(NULL));
    scanf_s("%d%d", &n, &m);
    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            mas[i][j] = rand() % 10;
        }
    }

    int mas2[10000];
    int count = 0;

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            mas2[count] = mas[i][j];
            count++;
        }
    }

    int n2 = count;

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            printf("%3d", mas[i][j]);
        }
        printf("\n");
    }

    for(int i = 0; i < n2; i++){
        printf("%2d", mas2[i]);
    }

    printf("\n");

    while(flag){
        flag = false;
        for(int i = 0; i < n2 -1; i++){
            if(mas2[i] > mas2[i + 1]){
                int z = mas2[i];
                mas2[i] = mas2[i + 1];
                mas2[i + 1] = z;
                flag = true;
            }
        }
    }



    for(int i = 0; i < n2; i++){
        printf("%2d", mas2[i]);
    }

    printf("\n");

    count = 0;

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            mas[i][j] = mas2[count];
            count++;
        }
        printf("\n");
    }

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            printf("%3d", mas[i][j]);
        }
        printf("\n");
    }


    // Сортировка двумерного массива по строкам
    int n, m;
    int mas[100][100];
    bool flag = true;
    srand(time(NULL));
    scanf_s("%d%d", &n, &m);
    for(int i = 0; i < n; i++){
        for(int j = 0; j < m; j++){
            mas[i][j] = rand() % 10;
        }
    }

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            printf("%3d", mas[i][j]);
        }
        printf("\n");
    }

    while(flag){
        flag = false;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m - 1; j++){
                if(mas[i][j] > mas[i][j + 1]){
                    int z = mas[i][j];
                    mas[i][j] = mas[i][j + 1];
                    mas[i][j + 1] = z;
                    flag = true;
                }
            }
        }
    }

    printf("\n");

    for (int i = 0; i < n; i++){
        for (int j = 0; j < m; j++){
            printf("%3d", mas[i][j]);
        }
        printf("\n");
    }

    // Сортировка двумерного по столбцам
    int n, m;
    int mas[100][100];
    bool flag = true;
    srand(time(NULL));
    scanf_s("%d%d", &n, &m);
    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            mas[i][j] = rand() % 10;
        }
    }

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            printf("%3d", mas[i][j]);
        }
        printf("\n");
    }

    while (flag) {
        flag = false;
        for (int j = 0; j < m; j++) {
            for (int i = 0; i < n - 1; i++) {
                if (mas[i][j] > mas[i + 1][j]) {
                    int z = mas[i][j];
                    mas[i][j] = mas[i + 1][j];
                    mas[i + 1][j] = z;
                    flag = true;
                }
            }
        }
    }

    printf("\n");

    for (int i = 0; i < n; i++) {
        for (int j = 0; j < m; j++) {
            printf("%3d", mas[i][j]);
        }
        printf("\n");
    }
}