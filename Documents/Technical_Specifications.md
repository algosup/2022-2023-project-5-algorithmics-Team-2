# 2022-2023 - PROJECT 5 - ALGORITHMS & DATA STRUCTURE - TEAM 2

## Technical Specifications

___

<details>
<summary>📖 Table of content</summary>

- [2022-2023 - PROJECT 5 - ALGORITHMS \& DATA STRUCTURE - TEAM 2](#2022-2023---project-5---algorithms--data-structure---team-2)
  - [Technical Specifications](#technical-specifications)
    - [I. Introduction of the project](#i-introduction-of-the-project)
      - [A. Client](#a-client)
      - [B. Goal of the project](#b-goal-of-the-project)
      - [C. Team Members](#c-team-members)
    - [II. Solution](#ii-solution)
      - [A. Descritpion](#a-descritpion)
      - [B. Software architecture](#b-software-architecture)
      - [C. Technical constraints](#c-technical-constraints)
      - [D. How is it work ?](#d-how-is-it-work-)
      - [E. Program architecture diagram](#e-program-architecture-diagram)
    - [III. Further considereations](#iii-further-considereations)
      - [A. Cost estimation](#a-cost-estimation)
      - [B. Security](#b-security)
      - [C. Accessibility](#c-accessibility)
    - [IV. Success evaluation](#iv-success-evaluation)
    - [V. Glossary](#v-glossary)

</details>

___

### I. Introduction of the project

#### A. Client

The client is the House Krug Champagne[^1], conceptor of wine and champagne since 1843. Based in Reims, they try to make each year the best products thanks to the respect of the vineyards.

#### B. Goal of the project

The objectif of the project is to implement a program who blend many wines to realize an unique blending with the lowest complexity[^2] for the program and the least loss of wine in the tanks.

#### C. Team Members

| ROLE | NAME |
| :-: | :-: |
| Project Manager | [Clement CATON](https://github.com/ClementCaton) |
| Program Manager | [Vivien Bistrel TSANGUE CHOUNOU](https://github.com/Bistrel2002) |
| Tech Leader | [Grégory PAGNOUX](https://github.com/Gregory-Pagnoux) |
| Software Engineer | [Clémentine CUREL](https://github.com/Clementine951) |
| Quality Assurance | [Alexandre BOBIS](https://github.com/AlexandreBobis) |

### II. Solution

#### A. Descritpion

We have an application where the user can log in and arrives on the home page. He can choose the production tab to enter the capacity of each tanks manually and also the formula of blending.
After entering all the parameters and validating them, the program calculates, as quickly as possible, the path between the tanks that the wine must take for the blends with the least amount of loss.

#### B. Software architecture

The software could be developed using a layered architecture[^3], with each layer responsible for a specific set of functionalities.

The presentation layer[^4] would be the user interface that the Cellar Master[^5] and her team would interact with. This layer would be developed using .NET 6.0's WPF[^6] framework, which provides a modern, visually appealing interface with advanced data binding and styling capabilities.

The business logic layer[^7] would handle the core functionality of the software, including the blending algorithms and data validation. This layer would be developed using C# and .NET 6.0's latest features, such as C# 10 and the new record types, to ensure maximum performance and maintainability.

The data access layer[^8] would be responsible for handling data storage and retrieval, such as keeping track of the tanks and their current contents. This layer would be developed using .NET 6.0's EF Core[^9] framework, which provides a powerful and flexible ORM[^10] (Object-Relational Mapping) toolset for working with databases.

To ensure that the software is reliable and fault-tolerant, it would be designed using the SOLID principles[^11] and unit tested extensively using .NET 6.0's built-in testing framework. Additionally, the software could be deployed using Docker containers and managed using Kubernetes to ensure scalability and resilience.

Overall, this architecture would provide a robust and scalable software solution for the Krug Champagne blending process, built using the latest and most advanced technologies in the .NET ecosystem.

#### C. Technical constraints

The most important thing to consider throughout the project is to have an `O(X)` with `X =` `1`, `log n` or `n`. The values to be avoided absolutely for the efficiency of the program, is an `O(X)` with `X =` `n²`, `2^n` and `n!`.

1. C# coding convention :

| Notation | How | Usage | Exemple |
| :-: | :-: | :-: | :-: |
| Pascal Casing | we attach each word and capitalize it to know where the next word starts (ex: DataService) | naming Class | <pre>```public class DataService```<br>```{```<br>```}```</pre> |
|  |  | naming record | <pre>```public record PhysicalAddress(```<br>```)```</pre> |
|  |  | naming structure | <pre>```public struct ValueCoordinate```<br>```{```<br>```}```</pre> |
|  |  | naming interface | <pre>```public interface IWorkerQueue```<br>```{```<br>```}```</pre> |
|  |  | naming public members | <pre>```public class Example```<br>```{```<br>    ```public IWorkerQueue WorkerQueue { get; init; }```<br>```{```</pre> |
| Camel Casing = _ | prefix them | naming private or internal fields | <pre>```public class DataService``` <br>```{``` <br>    ```private IWorkerQueue _workerQueue;``` <br>```}```</pre> |
|  | prefix `s_` | static fields that are private or internal | <pre>```public class DataService``` <br>```{``` <br>    ```private static IWorkerQueue s_workerQueue;``` <br>```}```</pre> |
|  | prefix `t_` | thread static fields that are private or internal | <pre>```public class DataService``` <br>```{``` <br>    ```[ThreadStatic]```<br>    ```private static TimeSpan t_timeSpan;``` <br>```}```</pre> |
| dot = . | separate name too long |  | <pre>```var currentPerformanceCounterCategory = new System.Diagnostics.```<br>    ```PerformanceCounterCategory();```</pre> |
Write only one statement or declaration per line.
If subsequent lines are not automatically indented, indent them by one tab stop (four spaces).
Add at least one blank line between method definitions and property definitions.
Use parentheses to make the clauses of an expression apparent.
- Exemple :
```
if ((val1 > val2) && (val1 > val3))
{
    // Take appropriate action.
}
```
*source : [learn Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)*

2. Objects description :

|  | Tanks | Wines | Main |
| :-: | :-: | :-: | :-: |
| **Vocabulary** | capacity [float] | ID [int] | margin [float] |
|  | wines [list] | quantity [float] |  |
|  | errorMargin [float] |  |  |
|  | Similarity [float] |  |  |
|  |  |  |  |
| **Function** | <pre>```get Similarity()```<br>  ```transferFrom(Tank[] tanks)```<br>  ```transferTo(Tank[] tanks)```</pre> | constructor : `wine(id, quantity)` | `tank[] tank_arr` |
|  | `<wines> get winePercent()` |  | <pre>```for(int i=O; i<maxTank; i++)```<br>  ```tank_arr.append(new Tank())```</pre> |
|  | `isGood(<wines> wine, errorMargin)` |  |  |
|  | <pre>```Tank()```<br>  ```this.capacity = (random % 99)+1```<br>  ```this.wine = new List<wines>();```</pre> |  |  |
|  |  |  |  |

3. Different solution to create an interface :

| INTERFACE | POSITIVE | NEGATIVE |
| :-: | :-: | :-: |
| Terminal | light weight | not user friendly |
| Blazor web | 1 big server to be fast + Mobile compatibility | cost online + heavy depend |
| Blazor app | secure (local) + offline | heavy on the  user's machine |
| API | can connect any interface + Mobile compatibility | depend of it + server cost |
| GUI (Graphic User Interface) | not to heavy + user friendly (design) + Mobile compatibility | midde weight + might take too long for creation + heavier |

#### D. How is it work ?

1. Interface :


2. Program :


#### E. Program architecture diagram

![program architechture diagram]()

### III. Further considereations

#### A. Cost estimation

To make the project, the cost don't depends of the program, but rather if we create an interface or not and thanks to which tool. Certain tool needed pay servers, as explained in Part II. C. point number 2.

#### B. Security

Each data collected are stocked on secure server.

#### C. Accessibility

The interface is accessible by 

### IV. Success evaluation

The program is scored according to the following criteria :

1. Correctness: no crash, no half full or half empty tanks
2. How close your final product is from the input formula
3. Comments and idiomatic style
4. Minimum number of steps to get to the result
5. Complexity and Speed of the code

___

### V. Glossary

[^1]: [House Krug Champagne](https://www.krug.com/fr/la-maison-krug)

[^2]: **Complexity :**
It is a measure of the time it would take an algorithm to run with an input of size n. The complexity is denoted O(X) (big-O). It can be linear if the search time is proportional to the size of the input (X=n). It is logarithmic if as the input increases, the number of significant operations increases very slowly (X=log n). It is constant if the execution time does not increase when the input increases massively (X=1). It is quadratic when the input is doubled, and the execution time of the calculations is multiplied by 4 (X=n^2).
*source : [Devopedia](https://devopedia.org/algorithmic-complexity) / [Towards data science](https://towardsdatascience.com/logarithms-exponents-in-complexity-analysis-b8071979e847#9063) / [University of Picardie](https://home.mis.u-picardie.fr/~furst/docs/3-Complexite.pdf)*

[^3]: **layered architecture :**
The layered architecture style is one of the most common architectural styles. The idea behind layered architecture is that modules or components with similar functionality are organised in horizontal layers. Thus, each layer plays a specific role in the application.
The layered architecture style places no restrictions on the number of layers the application can have, to support the concept of separation of concerns.
*source : University of Waterloo* [PDF](https://cs.uwaterloo.ca/~m2nagapp/courses/CS446/1195/Arch_Design_Activity/Layered.pdf)

[^4]: **Presentation layer :**
The presentation layer is the first of two layers in the so-called "three-tier architecture" (based on the client-server environment, see attached diagram).
![Three-tier architecture](Images/three-tier_architecture.png)
It's the "Client" part thanks an interface to use the program.
*source : [Wikipedia](https://fr.wikipedia.org/wiki/Architecture_trois_tiers)*

[^5]: **Cellar Master :**
A person who supervises the making of wine in a winery.
*source : [Merriam-Webster](https://www.merriam-webster.com/dictionary/cellar%20master)*

[^6]: **WPF (Windows Presentation Foundation) :**
It's a UI (user interface) framework that creates desktop client applications
*source : [learn Microsoft](https://learn.microsoft.com/en-gb/visualstudio/get-started/csharp/tutorial-wpf?view=vs-2022)*

[^7]: **Business logic layer :**
Also known as the business processing of data, corresponding to the second tier "Server" of the diagram in Definition 4. It is the implementation of all the business rules and application logic.
*source : [Wikipedia](https://fr.wikipedia.org/wiki/Architecture_trois_tiers)*

[^8]: **Data access layer :**
Data access or persistent data is data that is intended to be retained over time or even permanently. This is the third tier "Database"  of the diagram in Definition 4.
*source : [Wikipedia](https://fr.wikipedia.org/wiki/Architecture_trois_tiers)*

[^9]: **EF Core (Entity Framework Core) :**
Entity Framework (EF) Core is an extensible, open source, cross-platform version of Entity Framework. EF Core can serve as an object-relational mapper (O/RM), which allows .NET developers to work with a database using .NET objects and eliminates the need for much of the data access code that typically must be written. It supports many database engines.
With EF Core, data is accessed using a model. A model consists of entity classes and a context object that represents a session with the database. The context object allows the interrogation and registration of data. With this, it can generate a model from an existing database, manually code a model to match the database.
Once a model is created, it is possible to use EF Migrations to create a database from the model, allowing the database to grow as the model changes.
*source : [learn Microsoft](https://learn.microsoft.com/en-gb/ef/core/)*

[^10]: **ORM (Object-Relational Mapping) :**
L'ORM est en quelque sorte la couche qui relie la programmation orientée objet (OOP) aux bases de données relationnelles et simplifie l'interaction entre les deux.
*source : [Free code camp](https://www.freecodecamp.org/news/what-is-an-orm-the-meaning-of-object-relational-mapping-database-tools/)*

[^11]: **SOLID principles :**
The SOLID Principles are five principles of Object-Oriented class design. They are a set of rules and best practices to follow while designing a class structure.
The 5 principles are : Single Responsibility (a class should do one thing and therefore it should have only a single reason to change) / Open-Closed (classes should be open for extension and closed to modification) / Liskov Substitution (subclasses should be substitutable for their base classes) / Interface Segregation (separating the interfaces) / Dependency Inversion (classes should depend upon interfaces or abstract classes instead of concrete classes and functions)
*source : [Free code camp](https://www.freecodecamp.org/news/solid-principles-explained-in-plain-english/)*

[^12]: ****

*source : []()*