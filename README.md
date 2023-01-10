 #  Экзамен

 ## Base

- ### [B1] В чем идея инкапсуляции? Абстракция, интерфейс и реализация. Средства защиты и доступа.

> `Инкапсуляция` – это (самое главное) `защита инварианта объекта`, это принцип, согласно которому любой класс, и в более широком смысле – любая часть системы должны рассматриваться как «черный ящик»: пользователь класса, модуля или подсистемы должен видеть только предоставляемый контракт (интерфейс, список декларируемых свойств и методов) и не вникать во внутреннюю реализацию.
>
> `Абстрагирование` – это способ выделить набор значимых характеристик объекта, исключая из рассмотрения незначимые. Соответственно, **абстракция** – это набор всех таких характеристик.
>
> `Абстрактный класс` — это класс, у которого не реализован один или большеметодов.
>
> `Интерфейс` — это абстрактный класс, у которого ни один метод не реализован, все они публичные и нет переменных класса.
>
> `Реализация` - это семантическое отношение между классификаторами, при котором один классификатор определяет обязательство, а другой гарантирует его выполнение.
>
Как можно обеспечить инкапсуляцию? :
```
// №1 ИНКАПСУЛЯЦИЯ ПОЛЯ
private int foo;

public int Foo
{
    get
    {
        return foo;
    }
    set
    {
        // Любая угодная вам валидация во имя защиты инварианта
        Guard.AboveZero(value);
	Guard.NotNull(value);
	foo = value
    }
}

// №2 ИНКАПСУЛЯЦИЯ КОЛЛЕКЦИИ

private List<int> bar;
public IReadOnlyCollection<int> Bar => bar;

// №3 САМОИНКАПСУЛЯЦИЯ ПОЛЯ
/*
Создайте геттер и сеттер для поля, и пользуйтесь для доступа к полю только ими.
*/

class Range 
{
  private int low, high;
  
  int Low {
    get { return low; }
  }
  
  int High {
    get { return high; }
  }
  
  bool Includes(int arg) 
  {
    return arg >= Low && arg <= High;
  }
}
```
> Инкапсуляция поля, коллекции, самоинкапсуляция поля
----

- ### [B2] В чем идея наследования? Простое, многоуровневое, множественное наследование.

> `Наследование` — это возможность порождать один класс от другого с сохранением всех свойств и методов класса-предка (суперкласса), добавляя при необходимости новые свойства и методы. Выражает собой очень сильную связь между двумя классами. Есть аналогичные механизмы: **агрегация и композиция** . Порой, они намного лучше
>
> `Простое`. Класс, от которого произошло наследование, называется базовым. Унаследованный класс называется производным. Чаще всего имеет смысл при наличии какого-либо абстрактного класса. [StudentBase -> Student].
>
> `Многоуровневое`. Наследование от производного класса. [Animal -> Pet -> Cat -> BlackCat].
>
> `Множественное`. Наследование сразу от нескольких классов. [BatteryModule], [Case], [BatteryModule, Case -> PowerBank]
>
> Существуеют траблы, типа `Ромбовидного наследования`, то это *TODO*

--- 

- ### [B3] В чем идея полиморфизма? Раннее и позднее (динамическое) связывание.

> Идея полиморфизма заключается в способности использовать классы-**потомки** в контексте, который был предназначен для класса-**предка**.
> Также можно сказать, что идея заключается в способности объектов производных классов по-своему обрабатывать запрос, свойственный их классу.
>
> При `раннем связывании` компилятор заранее знает адрес с типом, с которым будет оперировать. Например когда мы добавляем dll библиотеку в проект путём добавления ссылки Reference/Add Reference - это раннее связывание, т.к. мы заранее даём знать этот адрес компилятору. По-умолчанию при создании метода в классе связывание раннее.
>
> При `позднем связывании` компилятор узнаёт этот адрес в процессе выполнения программы. Если в иерархии классов встречается цепочка **виртуальных методов** (virtual, override), то компилятор строит позднее связывание. При позднем связывании вызов метода **происходит на основании типа объекта, а не типа ссылки на
базовый класс**. Поэтому во время компляции компилятор ещё не знает, по каким адрес ему надо будет прыгать. Такой механизм и позволяет воплотить полиморфизм.
>
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
>
>Пример - у нас есть **магазин**. Есть в нем **заказ**, состоящий из **товаров**. Товары содержат **цену**.
Очевидно, что цена заказа должна подсчитываться там, где содержится информаци о цене товаров, т. е. - в заказе. В данном случае заказ -
**информационный эксперт**.
>
> Корелляция идет с принципом `OCP` из **SOLID** - информационный эксперт способствует увеличению инкапсуляции и стимулирует возможность переиспользовать компоненты, что помогает системе быть “открытой красширению, и закрытой для модификации”.
---

- ### [B5] В чем заключается смысл принципов низкой связности и высокого зацепления (Low coupling & High cohesion)?
>
> `Low Coupling` - необходимо распределить ответственности между классами так, чтобы обеспечить минимальную связанность. Самым ярким примером нарушения этого принципа является циклическая зависимость. Чем меньше связей между классами - тем проще их переиспользовать. Соблюдение **Information Expert** и **Creator** как раз приводит к уменьшению количества ненужных связей между классами.
>
> `High Cohesion` - модуль должен стараться выполнять как можно меньше не специфичных для негозадач и иметь вполне определенную область применения.Если модуль несет много разноплановой ответственности, он сложнее в поддержке и переиспользовании.

![image](https://user-images.githubusercontent.com/56086653/211169913-b15c5620-cca8-4287-96ee-188742f54ca4.png)

- ### [B6] В чем заключается смысл принципа подстановки Лисков? В каком случае и как нарушается принцип в проблеме эллипса-окружности (квадрата-прямоугольника)?

> Ну тут мы все знаем формулу: `«В том случае, если q(x) — свойство, верное по отношению к объектам х некого типа T, то свойство q(y) тоже будет верным относительно ряда объектов y, которые относятся к типу S, при этом S — подтип некого типа T»`
>
>  Ну а если серьезно, то **`LSP`** говорит о том, что поведение наследующих классов не должно противоречить поведению, заданному базовым классом, то есть поведение наследующих классов должно быть ожидаемым для кода, использующего переменную базового типа.

> Часто вместо принципа Лисков используются формальные правила на предусловия и постусловия из `контрактного программирования`:
> 
> - **Предусловия в подклассе не могут быть усилены — подкласс не должен требовать большего, чем базовый класс**
> - **Постусловия подкласса не могут быть ослаблены — подкласс не должен предоставлять (обещать) меньше, чем базовый класс**
> - **Инварианты базового класса должны сохранятся и в классе потомке**
>
> Например, в методе класса потомока, мы не можем добавить обязательный параметр, которого не было в базовом классе — потому что так мы усиливаем предусловия. Или мы не можем бросать исключений в переопределенном методе, т.к. нарушаем инварианты базового класса. И т.д.

> `Квадрат-Прямоугольник` : `если можно написать хоть какой-то осмысленный код, в котором замена объекта базового класса на объекта класса потомка, его сломает, то тогда не стоит их друг от друга-то наследовать»`. Именно в этом и проблема "наследовать квадрат от прямоугольника" или же наоборот. Можно сделать assert на точное соответствие классу, или сделать if, который будет работать для разных классов по-разному или другую тягомотину. С течением времени мы можем получить, что:
> - у класса потомка окажется переопределена большая часть методов
> - рефакторинг или добавление методов в базовый класс будет ломать код, использующий потомков
> - в коде, использующем объекты базового класса будут if-ы, с проверкой на класс объекта, а поведение для потомков и базового класса отличается
>
>
> Решение: создать абстрактный класс Shape и от него пронаследовать Square и Rectangle.
> 
> TODO: http://askofen.blogspot.com/2011/07/blog-post.html ОКРУЖНОСТЬ И ЭЛЛИПС

---

- ### [B7] Дайте описание принципам S, I, D из SOLID

> `Single Responsibility Principle` - принцип декларирует, что каждый объект должен иметь **одну обязанность** и эта обязанность должна быть полностью инкапсулирована в класс, а все его сервисы должны быть направлены **исключительно на обеспечение этой обязанности**.

> `Interface Segregation Principle` - принцип в формулировке [Роберта Мартина](https://www.labirint.ru/books/634082/) декларирует, что клиенты **не должны зависеть от методов, которые они не используют**. 
> 
> То есть если какой-то метод интерфейса не используется клиентом, то изменения этого метода не должны приводить к необходимости внесения изменений в клиентский код. Следование принципу ISP заключается в создании интерфейсов, которые достаточно специфичны и требуют только необходимый минимум реализаций методов.
>
>  Избыточные интерфейсы, напротив, могут требовать от реализующего класса создание большого количества методов, причём даже таких, которые не имеют смысла в контексте класса.

> `Dependency Inversion Principle` - принцип декларирует, что **модули верхних уровней не должны зависеть от модулей нижних уровней**, а оба типа модулей **должны зависеть от абстракций**; сами **абстракции не должны зависеть от деталей**, а вот детали должны зависеть от абстракций.
>
> Следование принципу инверсии зависимостей «заставляет» реализовывать высокоуровневые компоненты без встраивания зависимостей от конкретных низкоуровневых классов, что, например, сильно упрощает замену используемых зависимостей как по бизнес-требованиям, так и для целей тестирования.

---

- ### [B8] Дайте описание принципам O, L из SOLID.
> `Open Closed Principle` - принцип, cформлированный [Бертраном Мейером вот тут](https://www.amazon.com/Object-Oriented-Software-Construction-Book-CD-ROM/dp/0136291554), устанавливающий следующее положение: «программные сущности (классы, модули, функции и т. п.) должны быть открыты для расширения, но закрыты для изменения»

> Существует два варианта соблюдения этого принципа:
> **По Майеру**: нелогичная хрень, если хотите погуглите, даже не буду рассписывать 
>
> **По дяде Бобу**: Созданный изначально интерфейс должен быть закрыт для модификаций, а новые реализации как минимум соответствуют этому изначальному интерфейсу, но могут поддерживать и другие, более расширенные. Если просто: мы должны создавать абстракции, и новые модули будут просто реализововать эти абстракции, никак их не трогая.

> Главное преимущество следования этому принципу в том, что посколько при добавлении нового функционала мы не изменяем уже имеющийся код, нам не нужно заново тестировать уже накопившуюся кодовую базу, и новых багов очевидно там не появится :)
---

- ### [B9] Gateway и Mapper. В чём идея? В чём ключевые различия?.

> `Gateway` -  подобие паттерна Посредник/Адаптер, который инкапсулирует в себе доступ к внешней системе и ресурсу.

> ПО редко функционирует в изоляции от внешнего мира. Даже самая строго объектно-ориентированная система часто вынуждена взаимодействовать с "не объектами", например реляционная БД, CICS транзакции или структурами XML.
>
> При доступе к такого рода внешним ресурсам, обычно используется API. Однако, API изначально являются чем-то сложным, потому что принимают во внимание структуру ресурса. Каждый, кто хочет понять какой-нибудь ресурс, должен понять его API - будь то JDBC и SQL для реляционных БД или W3C или JDOM для XML. Это делает ПО не только менее понятным, но ещё это делает изменения гораздо более сложными, например, если вы собираетесь перейти со временем с SQL на XML.
>
> Решением здесь является **обёртывание всего специального API в класс, интерфейс которого выглядит как интерфейс обычного объекта**. Остальные объекты обращаются к ресурсу через этот `Шлюз`, который транслирует эти простые вызовы в соответствующий специальный API-код

![image](https://user-images.githubusercontent.com/56086653/211609584-4624de81-ef8d-4115-b30c-aa82a9f1e6b8.png)

![image](https://user-images.githubusercontent.com/56086653/211606455-f3f6583c-9fc8-447b-8df6-0ce6133832a8.png)

> Пример Gateway-контроллера для картинки выше:
```
[Route("[action]")]
[ApiController]
public class ConsumerGatewayController : ControllerBase
{
    private readonly HttpClient _httpClient;
    
    public ProxyController(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient();
    }
    
    [HttpGet]
    public async Task<IActionResult> Books()
        => await ProxyTo("https://localhost:44388/books");
	
    [HttpGet]
    public async Task<IActionResult> Authors()
        => await ProxyTo("https://localhost:44307/authors");
	
    private async Task<ContentResult> ProxyTo(string url)
        => Content(await _httpClient.GetStringAsync(url));
}
> По Фаулеру шлюз должен быть максимально простым, насколько это возможно. Шлюх должен просто выполнять операции с нужными ему объектами и возвращать значение. Вся более сложная логика должна содержаться в **клиентах шлюза**.
```

> Зачастую для создание шлюзов применяют системы автогенерации кода.
>
> **Gateway** применяется горазно чаще, чем **Mapper**, посколько gateway намного проще и написании и использовании.

--- 

> `Mapper` - объект, который управляет сообщением между независимыми друг от друга объектами. Очень похож на Посредник, но подсистемы не в курсе о существовании Mapper.
>
> Зачастую маппер используется для простого перемещения данных из одной подсистемы в другую
>
> Самый сложный аспект mapper'а - это его запуск. Поскольку ни одна подсистема не должна знать о его наличии, придется использоваться новую подсистему для его запуска,
> либо же реализовать паттерн [Observer](#) /*потом вставлю ссылку*/, где mapper будет следить за системами и перехватывать в них события 

![image](https://user-images.githubusercontent.com/56086653/211610775-7ab61221-3de3-4066-96d2-3631ee4beb34.png)





