# StudyResult1
итоговая работа по выбору специализации

Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма

###блок схема в файле scheme.pdf

###программа в папке HW1/Program.cs

## описание программы

1. Задаем размерность массива (вводим размер вручную), присваеваем значение переменной size

2. инициализируем массив newarray

3. пишем метод заполнения линейного массива размером size

*пишем цикл for для заполнения каждого элемента i<size

*предлагаем ввести символы для массива (i Раз)

*вводим символы вручную

4.инициализируем новый массив newarray2

5.пишем метод поиска длины нового массива на основании массива newarray

*пишем цикл for для поиска количества элементов, в которых колич символов <4

*подсчитываем колич таких элементов, записываем их колич как длину нового массива  = size2

*создаем новый массив

*пишем цикл for для заполнения нового массива i<size, в котором колич символов каждого 
элемента <4

*возвращаем новый массив newarray2

6. выводим новый массив на экран


