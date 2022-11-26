//using System;
//using System.Text;

//void fillMatrix(double[,] matrix)
//{
//    for (int i = 0; i <= 7; i++)
//    {
//        for (int j = 0; j <= 7; j++)
//            matrix[i, j] = 1.0 / ((i + 1) + (j + 1) - 1);
//        matrix[i, 8] = 8.0 / ((i + 1) * (i + 1));
//    }
//}

//void printMatrix(double[,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        Console.Write("| ");
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (i == j) Console.BackgroundColor = ConsoleColor.Blue;
//            Console.Write(String.Format("{0,9}", matrix[i, j].ToString("G3")));

//            Console.BackgroundColor = ConsoleColor.Black;
//            Console.Write(" | ");
//        }
//        Console.WriteLine();
//    }

//    Console.BackgroundColor = ConsoleColor.Black;
//}

//double[,] matrix = new double[8, 9];
////double[,] matrix = new double[8, 9]
////{
////    { 6, 9, 9, 0, 5, 7, 9, 7, 7 },
////    { 9, 4 ,9, 1 ,9, 0, 6 ,2, 2 },
////    { 5 ,9 ,5 ,5, 3 ,9, 3, 0, 6 },
////    { 9, 6 ,7 ,3 ,3, 9 ,4 ,9 ,8 },
////    { 7, 1, 2 ,5 ,6 ,7, 6, 2, 4 },
////    { 9, 6, 9, 6 ,0 ,9 ,8 ,4, 9 },
////    { 2, 5, 3, 9, 3, 9, 5, 9, 0 },
////    { 3, 8, 5, 9, 9, 4, 0, 6, 6 }
////};

//double[,] inverseMatrix = new double[8, 8]
//{
//    { 10.048770312618676107, -40.619884462033647722,  8.487950093194760565,   56.213333678119884604,   -37.331406146891522862,  94.022596325402505243,   -115.40982004566721527,  21.195704219206554569 },
//    {-40.619884462033647657, 207.77825036165391286,   45.55642478674996545,    -521.30375183651470152,  106.3416920363300052,    -520.3776345303482825,   1367.1366431264114947,   -623.83524497141642903 },
//    { 8.487950093194760172,  45.55642478674996773,    -646.561238642241649,    947.85048901913850019,   170.1931199120251672,    1139.4425524747055701,   -3775.6544979729614323,  2101.3533655277177711 },
//    { 56.213333678119885257, -521.30375183651470559,  947.85048901913850604,   -178.99117150378920277,  1110.2575362605095289 ,  -4018.0081671446090323 , 3115.8424286954241135,   -504.45990695748960003 },
//    {-37.331406146891522911, 106.341692036330004, 170.1931199120251704,    1110.2575362605095285,   -5747.0625909653691598,  5378.780569330600525,    1466.3947519299017447,   -2468.9313542257411891 },
//    { 94.022596325402504755, -520.37763453034827709,  1139.4425524747055572 ,  -4018.0081671446090324,  5378.7805693306005404 ,  2855.59404314011669, -7327.6475654659681299,  2291.5774043436863142},
//    { -115.40982004566721521,    1367.1366431264114947,   -3775.6544979729614331,  3115.8424286954241212,   1466.3947519299017333,   -7327.6475654659681279,  10234.001850299854333,   -4982.8018592995299582 },
//    { 21.195704219206554721, -623.83524497141643103 , 2101.3533655277177769 ,  -504.45990695748960458 , -2468.9313542257411911 , 2291.5774043436863194  , -4982.8018592995299596 , 4325.757875877835597 }
//};
//double rowSum = 0, rowSumInv = 0;

//fillMatrix(matrix);

//double[,] copyMatrix = new double[8, 9];
//for (int i = 0; i <= 7; i++)
//    for (int j = 0; j <= 8; j++)
//        copyMatrix[i, j] = matrix[i, j];

//Console.WriteLine("---------------------");
//Console.WriteLine("| Матрица Гильберта |");
//Console.WriteLine("---------------------");

//printMatrix(matrix);
//Console.WriteLine();

//Console.WriteLine("--------------------");
//Console.WriteLine("| Обратная матрица |");
//Console.WriteLine("--------------------");
//printMatrix(inverseMatrix);
//Console.WriteLine();

////Расчет норм матрицы
//for (int i = 0; i < 8; i++)
//{
//    double curRowSum = 0, curRowSumInv = 0;
//    for (int j = 0; j < 8; j++)
//    {
//        curRowSum += Math.Abs(matrix[j, i]);
//        curRowSumInv += Math.Abs(inverseMatrix[j, i]);
//    }
//    if (curRowSum > rowSum)
//        rowSum = curRowSum;

//    if (curRowSumInv > rowSumInv)
//        rowSumInv = curRowSumInv;
//}

//Console.WriteLine("-----------------");
//Console.WriteLine("| Этапы решения |");
//Console.WriteLine("-----------------");

////Прямой проход (зануление левого нижнего и правого верхнего угла)
//for (int m = 0, n = 0; m <= 7 && n <= 7; m++, n++)
//{
//    //////Выбор главного элемента//////
//    double max = 0;
//    int col = 0, row = 0;

//    //Находим максимальный элемент из всей матрицы
//    for (int i = m; i <= 7; i++)
//        for (int j = n; j <= 7; j++)
//            if (Math.Abs(matrix[i, j]) > max)
//            {
//                max = Math.Abs(matrix[i, j]);
//                col = j;
//                row = i;
//            }

//    Console.WriteLine($"Максимальный элемент {max}");
//    Console.WriteLine($"Смена столбцов {n + 1} и {col + 1}");
//    Console.WriteLine($"Смена строк {m + 1} и {row + 1}");


//    //Смена столбцов
//    for (int i = 0; i <= 7; i++)
//    {
//        max = matrix[i, n];
//        matrix[i, n] = matrix[i, col];
//        matrix[i, col] = max;
//    }

//    //Смена столбцов для матрицы-дублера
//    for (int i = 0; i <= 7; i++)
//    {
//        max = copyMatrix[i, n];
//        copyMatrix[i, n] = copyMatrix[i, col];
//        copyMatrix[i, col] = max;
//    }

//    //Смена строк
//    for (int j = 0; j <= 8; j++)
//    {
//        max = matrix[m, j];
//        matrix[m, j] = matrix[row, j];
//        matrix[row, j] = max;
//    }



//    //////Алгоритм Гаусса//////
//    double k = matrix[m, n];
//    if (matrix[m, n] != 1)
//        for (int j = n; j <= 8; j++)
//            matrix[m, j] /= k;

//    Console.WriteLine($"Получили единицу в {m + 1}-ем столбце, разделив {m + 1}-ю строку на {k}");
//    printMatrix(matrix);
//    Console.WriteLine();

//    for (int i = 0; i <= 7; i++)
//    {
//        if (i == m) continue;
//        k = matrix[i, n];
//        for (int j = n; j <= 8; j++)
//            matrix[i, j] -= matrix[m, j] * k;
//    }

//    Console.WriteLine($"Занулили {m + 1}-ий столбец");
//    printMatrix(matrix);
//    Console.WriteLine();
//}

//Console.WriteLine("-----------------------------------");
//Console.WriteLine("| Матрица, после алгоритма Гаусса |");
//Console.WriteLine("-----------------------------------");
//printMatrix(matrix);
//Console.WriteLine();

//Console.WriteLine("---------------------------");
//Console.WriteLine("| Обусловленность матрицы |");
//Console.WriteLine("---------------------------");
//Console.WriteLine($"||A|| = {rowSum}");
//Console.OutputEncoding = Encoding.GetEncoding(65001);
//Console.WriteLine($"||A\u207B\u00B9|| = {rowSumInv}");
//Console.WriteLine($"Cond(A) = {rowSum * rowSumInv}");

//Console.WriteLine();
//Console.WriteLine("-------------------");
//Console.WriteLine("| Корни уравнений |");
//Console.WriteLine("-------------------");

//for (int i = 0; i <= 7; i++)
//    Console.WriteLine($"x{i + 1} = {(matrix[i, matrix.GetLength(1) - 1]).ToString("G17")}");

//Console.WriteLine();
//Console.WriteLine("---------------------------------------------------------");
//Console.WriteLine("| Результат подстановки значений переменных в уравнения |");
//Console.WriteLine("---------------------------------------------------------");

//double res = 0;
//for (int i = 0; i <= 7; i++)
//{
//    for (int j = 0; j <= 7; j++)
//        res += copyMatrix[i, j] * matrix[j, matrix.GetLength(1) - 1];

//    Console.WriteLine($"Уравнение {i + 1}: {res}");
//    res = 0;
//}
