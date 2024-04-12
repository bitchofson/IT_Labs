# Задача 1
## Класс «Линейный_список».
- Свойства: текущий элемент, количество элементов, признак пуст ли список (IsEmpty).
- Методы: добавления и удаления элементов, перехода к следующему элементу (если переход к следующему элементу не возможен, возвращает false, иначе - true), переход в начало.
## Запуск
Клонировать репозиторий локально к себе на проект.
```
git clone https://github.com/bitchofson/IT_Labs.git
```
Перейти по следующему пути ```Lab_1/bin/Release/net8.0/win-x64``` и запустить `Lab_1.exe`.

# Задача 2
## Класс «Геометрическая_фигура».
- Базовый класс: геометрическая фигура (содержит координаты центра фигуры, абстрактрные методы, возвращающие координаты прямоугольника, в который заключена фигура, площадь фигуры).
- Производные классы: точка, линия, многоугольник, эллипс. У линии и точки площадь равна 0, у остальных - вычисляются. У каждой фигуры задаются свои свойства, определяющие её геометрию.
## Запуск
Клонировать репозиторий локально к себе на проект.
```
git clone https://github.com/bitchofson/IT_Labs.git
```
Перейти по следующему пути ```Lab_2/bin/Release/net8.0/win-x64``` и запустить `Lab_2.exe`.

# Задача 3
## Реализация рефлексии.
- На основании реализованного второго таска реализовать доступ к классам по средствам рефлексии.
## Запуск
Клонировать репозиторий локально к себе на проект.
```
git clone https://github.com/bitchofson/IT_Labs.git
```
Перейти по следующему пути ```Lab_3/bin/Release/net8.0/win-x64``` и запустить `Lab_3.exe`. Далее необходимо загрузить dll библиотеку (она находится в директории dlls), после чего программа будет готова к работе.