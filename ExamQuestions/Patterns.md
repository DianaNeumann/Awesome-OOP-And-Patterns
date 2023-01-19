## Patterns

```
Лучше, чем на refactoring.guru, я не распишу, поэтому каждый билет будет представлять собой 
> Ссылку на refactoring.guru
> Структуру паттерна (и примеры на диаграммах)

UPD: Оказалось, что код на экзамене писать НЕ НУЖНО, в практическом задании достаточно нарисовать схемку и объяснить архитектуру
```

- ### [P1] Паттерн одиночка. В чем идея? В чем опасность использования?
> [RG: Singleton](https://refactoring.guru/ru/design-patterns/singleton)
>
> ![image](https://user-images.githubusercontent.com/56086653/213404953-f13056d2-a99f-4c8b-8870-46acaf21dbe3.png)

---

- ### [P2] Паттерн состояние. В чем идея? Какое ключевое отличие от паттерна стратегия?
> [RG: State](https://refactoring.guru/ru/design-patterns/state)
>
> ![image](https://user-images.githubusercontent.com/56086653/213405893-d79e7bd4-be35-4bba-b603-0a8b61775294.png)
>
> Конкретный пример:
>
> ![image](https://user-images.githubusercontent.com/56086653/213418167-673e2fc4-89c4-4d0c-9660-db606b3d6700.png)

---

- ### [P3] Паттерн стратегия. В чем идея? Какое ключевое отличие от паттерна состояние?
> [RG: Strategy](https://refactoring.guru/ru/design-patterns/strategy)
>
> ![image](https://user-images.githubusercontent.com/56086653/213408058-e3b86772-287e-4595-953b-bf3f7b79fd85.png)
>
> Конкретный пример:
>
> ![image](https://user-images.githubusercontent.com/56086653/213414685-c3d5ff4b-7cb9-40f5-b54a-08be46b85621.png)

---

- ### [P4] Паттерн легковес. В чем идея? Когда его следует применять?
> [RG: Flyweight](https://refactoring.guru/ru/design-patterns/flyweight)
>
> ![image](https://user-images.githubusercontent.com/56086653/213416975-f4bede7c-457f-496e-9d10-fd9d7c4a2b82.png)
>
> Конкретный пример:
>
> !![image](https://user-images.githubusercontent.com/56086653/213417733-613127b2-de61-4624-9728-2a37ec34c5a6.png)

---

- ### [P5] Паттерн заместитель. В чем идея? Какие виды (типы) заместителей бывают? Для решения каких задач применяются?
> [RG: Proxy](https://refactoring.guru/ru/design-patterns/proxy)
>
> ![image](https://user-images.githubusercontent.com/56086653/213482306-62e8800e-36a5-417b-abc8-965afde30b66.png)
>
> Конкретный пример:
>
> ![image](https://user-images.githubusercontent.com/56086653/213482482-2c936a13-87c6-4bb4-8fea-a25a215a2975.png)

---

- ### [P6] Паттерн команда. В чем идея? Как его можно комбинировать с партнёром снимок?
> [RG: Command](https://refactoring.guru/ru/design-patterns/command)
>
> ![image](https://user-images.githubusercontent.com/56086653/213482774-9db0de44-7c65-42ac-bb59-24a334abba9b.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213482884-b6f91485-ad54-4873-a6b2-964691a5dabe.png)

---

- ### [P7] Паттерн снимок. В чем идея? Как его можно комбинировать с партнёром команда?
> [RG: Memento](https://refactoring.guru/ru/design-patterns/memento)
>
> ![image](https://user-images.githubusercontent.com/56086653/213485918-6a7b0679-bc7b-4132-a0d0-728a28f0effc.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213485990-afd8f2b9-2deb-48c0-a944-177228cacaf8.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213486079-5e122399-3327-4620-8e6f-d3b39b4dc131.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213486281-7c1b5306-1832-4b47-af72-b3618372fa41.png)

---

- ### [P8] Паттерн фабричный метод. В чем идея? В чем разница между паттернам фабричный метод и шаблонный метод?
> [RG: Factory Method](https://refactoring.guru/ru/design-patterns/factory-method)
>
> ![image](https://user-images.githubusercontent.com/56086653/213487103-cc87a76c-4d43-480e-9602-d4b6a58063bb.png)

---

- ### [P9] Паттерн шаблонный метод. В чем идея? В чем разница между паттернам фабричный метод и шаблонный метод?
> [RG: Template Method](https://refactoring.guru/ru/design-patterns/template-method)
>
> ![image](https://user-images.githubusercontent.com/56086653/213487441-10d0682a-31f2-4486-a370-75f26ef45e5d.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213487517-80bcc9ca-6f09-4ea9-9361-cdc9f6e14791.png)

---

- ### [P10] Паттерн посетитель. В чем идея? Какие требования предъявляются к классам, которые можно посещать?
> [RG: Visitor](https://refactoring.guru/ru/design-patterns/visitor)
>
> ![image](https://user-images.githubusercontent.com/56086653/213488357-67603760-68fc-4d5b-895c-9b8b3a72f1d7.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213488421-00e884c2-ceae-49a4-ba3b-2185ca309bc8.png)

---

- ### [P11] Паттерн декоратор. В чем идея? Когда следует применять?
> [RG: Decorator](https://refactoring.guru/ru/design-patterns/decorator)
> 
> ![image](https://user-images.githubusercontent.com/56086653/213526751-7cc4b0bf-9c36-498a-82fe-d4f24ae78b46.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213527287-0742dce6-1668-41a5-bbcb-99e81672618e.png)

---

- ### [P12] Паттерн адаптер. В чем идея? Когда следует применять?
> [RG: Adapter](https://refactoring.guru/ru/design-patterns/adapter)
>
> ![image](https://user-images.githubusercontent.com/56086653/213527900-811fb16f-07ef-4e58-8ed2-5fb7e7d85d56.png)

---

- ### [P13] Паттерн мост. В чём идея? Когда следует применять?
> [RG: Bridge](https://refactoring.guru/ru/design-patterns/bridge)
>
> ![image](https://user-images.githubusercontent.com/56086653/213529802-421c18f2-d28f-4d06-95b4-47505d8c2d80.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213529865-ab4fc617-5478-4ebe-ab6b-11ee7e9ba86e.png)

---

- ### [P14] Паттерн цепочка обязанностей. В чем идея? Когда следует применять?
> [RG: Chain of Responsibility](https://refactoring.guru/ru/design-patterns/chain-of-responsibility)
>
> ![image](https://user-images.githubusercontent.com/56086653/213529970-bd53ba21-7d09-4f99-a15a-2e47f3596d1f.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530027-1873dee7-5393-452a-b9fd-94ef1596de7b.png)

---

- ### [P15] Паттерн фасад. В чем идея? Когда следует применять?
> [RG: Facade](https://refactoring.guru/ru/design-patterns/facade)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530120-4b6f8e8a-a6d1-4add-a350-809cf68f158c.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530189-6818172a-b5bf-4794-93e6-c2c2a9148972.png)

---

- ### [P16] Паттерн посредник. В чем идея? Когда следует применять?
> [RG: Mediator](https://refactoring.guru/ru/design-patterns/mediator)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530305-6b938ff1-619e-45bd-abc6-5386a748fa93.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530356-b9711792-16f1-489a-803a-bf42c5d282ea.png)

---

- ### [P17] Паттерн наблюдатель. В чем идея? Когда следует применять?
> [RG: Observer](https://refactoring.guru/ru/design-patterns/observer)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530470-e46eee9a-5d64-4343-bfc0-03c599de2266.png)
>
> ![image](https://user-images.githubusercontent.com/56086653/213530526-c3e06eb8-03e3-4805-a348-bfff28d7fab7.png)



