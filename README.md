**Задача**: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Пример**:

*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

1. Задаём массив строк
2. Выделяем память для массива
3. Вводим индекс для массива ответов
4. Перебираем входной массив (Проверка, меньше ли длина строки или равна 3)
5. Если длина строки меньше или равна 3 
- Добавляем строку в массив ответов
6. Выводим массив ответов
