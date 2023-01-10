# Итоговая проверочная работа.

## Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первонаяальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуеться пользоваться коллекциями, лучше обойтись исключительно массивами.

### Пример:
["hello", "2", "world", ":-)"]->["2", ":-)"]

["1234", "1567", "-2", "computer science"]->["-2"]

["Russia", "Denmark", "Kazan"]->[]

### Блок схема:

![Блок схема кода](/images/Block_diagram.png)

### Описание программы:

Программа имеет две функции. После выполнения функций выводит новый массив, заполненый строками заданной длины в терминал.

#### Первая функция: 

В заданном массиве находит строки заданной длины и подчитывает их колличество. После создает массив заданной длины из колличества строк нужной длины.

#### Вторая функция: 

Выполняет заполнение пустого массива строками из заданного массива строками заданной длины.
