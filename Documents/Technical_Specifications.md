# 2022-2023 - PROJECT5 - ALGORITHMS & DATA STRUCTURE - TEAM 2

# Technical Specifications

___

<details>

<summary>📖 Table of content</summary>

- [2022-2023 - PROJECT5 - ALGORITHMS \& DATA STRUCTURE - TEAM 2](#2022-2023---project5---algorithms--data-structure---team-2)
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

## I. Introduction of the project

### A. Client

The client is the House Krug Champagne[^1], conceptor of wine and champagne since 1843. Based in Reims, they try to make each year the best products thanks to the respect of the vineyards.

### B. Goal of the project

The objectif of the project is to implement a program who blend many wines to realize an unique blending with the lowest complexity[^2] for the program and the least loss of wine in the tanks.

### C. Team Members

| ROLE | NAME |
| :-: | :-: |
| Project Manager | [Clement CATON](https://github.com/ClementCaton) |
| Program Manager | [Vivien Bistrel TSANGUE CHOUNOU](https://github.com/Bistrel2002) |
| Tech Leader | [Grégory PAGNOUX](https://github.com/Gregory-Pagnoux) |
| Software Engineer | [Clémentine CUREL](https://github.com/Clementine951) |
| Quality Assurance | [Alexandre BOBIS](https://github.com/AlexandreBobis) |

## II. Solution

### A. Descritpion

We have an application where the user can log in and arrives on the home page. He can choose the production tab to enter the capacity of each tanks manually and also the formula so that the program can calculate the best way to achieve the perfect blend of their wines.

### B. Software architecture

The software could be developed using a layered architecture, with each layer responsible for a specific set of functionalities.

The presentation layer would be the user interface that the Cellar Master and her team would interact with. This layer would be developed using .NET 6.0's WPF (Windows Presentation Foundation) framework, which provides a modern, visually appealing interface with advanced data binding and styling capabilities.

The business logic layer would handle the core functionality of the software, including the blending algorithms and data validation. This layer would be developed using C# and .NET 6.0's latest features, such as C# 10 and the new record types, to ensure maximum performance and maintainability.

The data access layer would be responsible for handling data storage and retrieval, such as keeping track of the tanks and their current contents. This layer would be developed using .NET 6.0's EF Core (Entity Framework Core) framework, which provides a powerful and flexible ORM (Object-Relational Mapping) toolset for working with databases.

To ensure that the software is reliable and fault-tolerant, it would be designed using the SOLID principles and unit tested extensively using .NET 6.0's built-in testing framework. Additionally, the software could be deployed using Docker containers and managed using Kubernetes to ensure scalability and resilience.

Overall, this architecture would provide a robust and scalable software solution for the Krug Champagne blending process, built using the latest and most advanced technologies in the .NET ecosystem.

### C. Technical constraints

1. Objects description :

| Tanks | Wines | Main |
| :-: | :-: | :-: |
| capacity [float] | ID [int] | margin [float] |
| wines [list] | quantity [float] |  |
| errorMargin [float] |  |  |
| Similarity [float] |  |  |
| <pre>```get Similarity()```<br>  ```transferFrom(Tank[] tanks)```<br>  ```transferTo(Tank[] tanks)```</pre> | constructor : `wine(id, quantity)` | `tank[] tank_arr` |
| `<wines> get winePercent()` |  | <pre>```for(int i=O; i<maxTank; i++)```<br>  ```tank_arr.append(new Tank())```</pre> |
| `isGood(<wines> wine, errorMargin)` |  |  |
| <pre>```Tank()```<br>  ```this.capacity = (random % 99)+1```<br>  ```this.wine = new List<wines>();```</pre> |  |  |

1. Different solution to create an interface :

| INTERFACE | POSITIVE | NEGATIVE |
| :-: | :-: | :-: |
| Terminal | light weight | not user friendly |
| Blazor web | 1 big server to be fast + Mobile compatibility | cost online + heavy depend |
| Blazor app | secure (local) + offline | heavy on the  user's machine |
| API | can connect any interface + Mobile compatibility | depend of it + server cost |
| GUI (Graphic User Interface) | not to heavy + user friendly (design) + Mobile compatibility | midde weight + might take too long for creation + heavier |

### D. How is it work ?

1. Interface :


2. Program :


### E. Program architecture diagram

![program architechture diagram]()

## III. Further considereations

### A. Cost estimation

To make the project, the cost don't depends of the program, but rather if we create an interface or not and thanks to which tool. Certain tool needed pay servers, as explained in Part II. C. point number 2.

### B. Security

Each data collected are stocked on secur server.

### C. Accessibility

The interface is accessible by 

## IV. Success evaluation

The program is scored according to the following criteria :

1. Correctness: no crash, no half full or half empty tanks
2. How close your final product is from the input formula
3. Comments and idiomatic style
4. Minimum number of steps to get to the result
5. Speed of the code

## V. Glossary

[^1]: [House Krug Champagne](https://www.krug.com/fr/la-maison-krug)
[^2]: Complexity
It's a measure of how long an algorithm would take to complete given an input of size n.
[^3]: 

[^4]: 

[^5]: 

