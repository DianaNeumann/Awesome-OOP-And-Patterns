 ## Architecture (Three-Tier Architecture)

- ### [A1] Какие слои присутствуют в классической 3х уровневой архитектуре. Дайте краткое описание и назначение каждого слоя.

> Тут сперва предлагаю рассказать, что вообще за "слоёность" и откуда это взялось.
> 
> Разделение кода на слои помогает раскладывать сложные системы на более простые части. Также каждый "промежуточный слой" скрывает нижний слой от верхнего.
> Нижние слое не осведомлены о налиичии верхних.
> 
> Такое расчленение системы имеет плюсы:
> - Можно воспринимать каждый отдельный слой как единое, самодостаточное целое, не заботясь об остальных слоях
> - Сведится к минимуму зависимость между слоями.
> - Нам ничего не мешает развернуть *([задеплоить](https://ru.wikipedia.org/wiki/%D0%90%D0%BD%D0%B3%D0%BB%D0%B8%D1%86%D0%B8%D0%B7%D0%BC%D1%8B))* много серверов с **Application слоем**
> - Базе данных не нужно устанавливать соединение с каждым клиентом - требуются соединения только с меньшим количеством серверов приложений (те самые серверы, на которых крутиться **Application слой**).
> - Защита целостности данных БД, ибо вся информация проходит через **Application слой**, который гарантирует надежность добавленных в БД данных
> - **Presentation слой** может кешировать запросы -> снижение нагрузки.
> 
> Но обладает и минусами:
> - Слои способны удачно инкапсулировать многое, но не всё: модификация одного слоя влечет за собой каскадные изменения в остальные слои. Пример: новое поле в БД (каскадное изменение бизнес-логики и представления)
> - Наличие избыточных слоёв нередко снижает производительность. Например, при переходе от слоя к слою, сущности подвергаются различных преобразованиям.  


> `Presentation Layer` - уровень, с которым непосредственно взаимодействуетпользователь. Этот уровень включает компоненты пользовательского интерфейса, механизм получения ввода от пользователя.

> `Application Layer` - содержит набор компонентов, которые отвечают за обработку полученных от уровня представлений данных, реализует всю необходимую логику приложения, все вычисления, взаимодействует с базой данных и передает уровню представления результат обработки.

> `Data Access Layer` - хранит модели, описывающие используемые сущности, также здесь размещаются специфичные классы для работы с разными технологиями доступа к данным, например, класс контекста данных Entity Framework. Здесь также хранятся репозитории, через которые уровень бизнес-логики взаимодействует с базой данных.

---

- ### [A2] 2. Какие обязанности берет на себя слой DAL? С какими слоями и как он связан?


