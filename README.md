 #  Экзамен

 ## Base

- ### [B1] В чем идея инкапсуляции? Абстракция, интерфейс и реализация. Средства защиты и доступа.

>`Инкапсуляция` – это (самое главное) `защита инварианта объекта`, это принцип, согласно которому любой класс, и в более широком смысле – любая часть системы должны рассматриваться как «черный ящик»: пользователь класса или подсистемы должен видеть только интерфейс (т.е. список декларируемых свойств и методов) и не вникать во внутреннюю реализацию

> `Абстрагирование` – это способ выделить набор значимых характеристик объекта, исключая из рассмотрения незначимые. Соответственно, **абстракция** – это набор всех таких характеристик.

> `Абстрактный класс` — это класс, у которого не реализован один или большеметодов.

> `Интерфейс` — это абстрактный класс, у которого ни один метод не реализован, все они публичные и нет переменных класса.

> `Реализация` - это семантическое отношение между классификаторами, при котором один классификатор определяет обязательство, а другой гарантирует его выполнение.

Средства: [TODO: ПОТОМ РАССПИШУ]
> Инкапсуляция поля, коллекции, самоинкапсуляция поля
----

- ### [B2] В чем идея наследования? Простое, многоуровневое, множественное наследование.

> `Наследование` — это возможность порождать один класс от другого с сохранением всех свойств и методов класса-предка (суперкласса), добавляя при необходимости новые свойства и методы. Выражает собой очень сильную связь между двумя классами. Есть аналогичные механизмы: **агрегация и композиция** . Порой, они намного лучше

> `Простое`. Класс, от которого произошло наследование, называется базовым. Унаследованный класс называется производным. Чаще всего имеет смысл при наличии какого-либо абстрактного класса. [StudentBase -> Student].

> `Многоуровневое`. Наследование от производного класса. [Animal -> Pet -> Cat -> BlackCat].

> `Множественное`. Наследование сразу от нескольких классов. [BatteryModule], [Case], [BatteryModule, Case -> PowerBank]

> Существуеют траблы, типа `Ромбовидного наследования`, то это *TODO*

--- 

- ### [B3] В чем идея полиморфизма? Раннее и позднее (динамическое) связывание.

> Идея полиморфизма заключается в способности использовать классы-**потомки** в контексте, который был предназначен для класса-**предка**.
> Также можно сказать, что идея заключается в способности объектов производных классов по-своему обрабатывать запрос, свойственный их классу.

> При `раннем связывании` компилятор заранее знает адрес с типом, с которым будет оперировать. Например когда мы добавляем dll библиотеку в проект путём добавления ссылки Reference/Add Reference - это раннее связывание, т.к. мы заранее даём знать этот адрес компилятору. По-умолчанию при создании метода в классе связывание раннее.

> При `позднем связывании` компилятор узнаёт этот адрес в процессе выполнения программы. Если в иерархии классов встречается цепочка **виртуальных методов** (virtual, override), то компилятор строит позднее связывание. При позднем связывании вызов метода **происходит на основании типа объекта, а не типа ссылки на
базовый класс**. Поэтому во время компляции компилятор ещё не знает, по каким адрес ему надо будет прыгать. Такой механизм и позволяет воплотить полиморфизм.

На всякий ещё и виды полиморфизма:

> `Ad-hoc`. В зависимости от типа данных модулю сопоставлятся различное поведение. В строго типизированных языках инструментом реализации такого полиморфизма является перегрузка методов. В слабо типизированных языках посредством привидения типов
```
int sum(int x, int y){
		return x + y;
}
	
double sum(double x, double y){
		return x + y;
}
```

> `Параметрический полиморфизм`. "Модуль" не зависит от типа аргумента. Такой вид полиморфизма в языках часто раскрывается через Generic'и
```
void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
```

> `Полиморфизм подтипов` - Свойство системы, позволяющее использовать объекты с одинаковым интерфейсом (интерфейс в значении **контракта**) без информации о типе и внутренней структуре объекта.

---

- ### [B4] Принцип “информационного эксперта”. В чем идея? С каким принципом SOLID коррелирует?

> Главная суть принципа `Information Expert` из GRASP - информация должна обрабатываться там, где она содержится.
>Пример - у нас есть **магазин**. Есть в нем **заказ**, состоящий из **товаров**. Товары содержат **цену**.
Очевидно, что цена заказа должна подсчитываться там, где содержится информаци о цене товаров, т. е. - в заказе. В данном случае заказ -
**информационный эксперт**.
> Корелляция идет с принципом `OCP` из **SOLID** - информационный эксперт способствует увеличению инкапсуляции и стимулирует возможность переиспользовать компоненты, что помогает системе быть “открытой красширению, и закрытой для модификации”.
