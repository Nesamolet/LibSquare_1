Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

      -Юнит-тест
      -Легкость добавления других фигур
      -Вычисление площади фигуры без знания типа фигуры в compile-time
      -Проверку на то, является ли треугольник прямоугольным.

INFO?:

      Для данного задания я сделал 2 реализаци. Данная ,библиотека больше похожа на стандартную 
      библиотеку Math, где для вызова функции подсчета площади фигуры нет необходимости создавать 
      экземпляр класса, а достаточно передать значения в функцию GetArea, определенную для классов 
      Triangle и Circle, то есть для треугольника и круга соотвественно. 
