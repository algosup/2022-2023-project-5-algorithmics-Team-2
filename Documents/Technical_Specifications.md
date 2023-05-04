# 2022-2023 - PROJECT5 - ALGORITHMS & DATA STRUCTURE - TEAM 2

# Technical Specifications

<details>

<summary>📖 Table of content</summary>

- [2022-2023 - PROJECT5 - ALGORITHMS \& DATA STRUCTURE - TEAM 2](#2022-2023---project5---algorithms--data-structure---team-2)
- [Technical Specifications](#technical-specifications)
  - [Introduction of the project](#introduction-of-the-project)
    - [Client](#client)
    - [Goal of the project](#goal-of-the-project)
    - [Team Members](#team-members)
  - [Solution](#solution)
    - [Descritpion](#descritpion)
    - [Software architecture](#software-architecture)
    - [Architecture diagram](#architecture-diagram)
    - [Technical constraints](#technical-constraints)
    - [How is it work ?](#how-is-it-work-)
  - [Further considereations](#further-considereations)
    - [Cost estimation](#cost-estimation)
    - [Security](#security)
    - [Accessibility](#accessibility)
  - [Success evaluation](#success-evaluation)
  - [Glossary](#glossary)

</details>

## Introduction of the project

### Client

The client is the House Krug Champagne[^1], conceptor of wine and champagne since 1843. Based in Reims, they try to make each year the best products thanks to the respect of the vineyards.

### Goal of the project

The objectif of the project is to implement a program who blend many wines to realize an unique blending with the lowest complexity[^2] for the program and the least loss of wine in the tanks.

### Team Members

| ROLE | NAME |
| :-: | :-: |
| Project Manager | [Clement CATON](https://github.com/ClementCaton) |
| Program Manager | [Vivien Bistrel TSANGUE CHOUNOU](https://github.com/Bistrel2002) |
| Tech Leader | [Grégory PAGNOUX](https://github.com/Gregory-Pagnoux) |
| Software Engineer | [Clémentine CUREL](https://github.com/Clementine951) |
| Quality Assurance | [Alexandre BOBIS](https://github.com/AlexandreBobis) |

## Solution

### Descritpion

### Software architecture

The software could be developed using a layered architecture, with each layer responsible for a specific set of functionalities.

The presentation layer would be the user interface that the Cellar Master and her team would interact with. This layer would be developed using .NET 6.0's WPF (Windows Presentation Foundation) framework, which provides a modern, visually appealing interface with advanced data binding and styling capabilities.

The business logic layer would handle the core functionality of the software, including the blending algorithms and data validation. This layer would be developed using C# and .NET 6.0's latest features, such as C# 10 and the new record types, to ensure maximum performance and maintainability.

The data access layer would be responsible for handling data storage and retrieval, such as keeping track of the tanks and their current contents. This layer would be developed using .NET 6.0's EF Core (Entity Framework Core) framework, which provides a powerful and flexible ORM (Object-Relational Mapping) toolset for working with databases.

To ensure that the software is reliable and fault-tolerant, it would be designed using the SOLID principles and unit tested extensively using .NET 6.0's built-in testing framework. Additionally, the software could be deployed using Docker containers and managed using Kubernetes to ensure scalability and resilience.

Overall, this architecture would provide a robust and scalable software solution for the Krug Champagne blending process, built using the latest and most advanced technologies in the .NET ecosystem.

### Architecture diagram

### Technical constraints

(description of the technical constraints to be taken into account in the development of the software)

Objects description :

| Tanks | Wines | Main |
| :-: | :-: | :-: |
| capacity [float] | id [int] | margin [float] |
| wines [list] | quantity [float] |  |
| errorMargin [float] |  |  |
| Similarity [float] |  |  |
| <pre>```get Similarity()```<br>  ```transferFrom(Tank[] tanks)```<br>  ```transferTo(Tank[] tanks)```</pre> | constructor : `wine(id, quantity)` | `tank[] tank_arr` |
| `<wines> get winePercent()` |  | <pre>```for(int i=O; i<maxTank; i++)```<br>  ```tank_arr.append(new Tank())```</pre> |
| `isGood(<wines> wine, errorMargin)` |  |  |
| <pre>```Tank()```<br>  ```this.capacity = (random % 99)+1```<br>  ```this.wine = new List<wines>();```</pre> |  |  |
|  |  |  |

Different solution to create an interface :

| INTERFACE | POSITIVE | NEGATIVE |
| :-: | :-: | :-: |
| Terminal | light weight | not user friendly |
| Blazor web | 1 big server to be fast + Mobile compatibility | cost online + heavy depend |
| Blazor app | secure (local) + offline | heavy on the  user's machine |
| API | can connect any interface + Mobile compatibility | depend of it + server cost |
| GUI (Graphic User Interface) | not to heavy + user friendly (design) + Mobile compatibility | midde weight + might take too long for creation + heavier |

### How is it work ?

## Further considereations

### Cost estimation

To make the project, 

### Security

### Accessibility

## Success evaluation

The program is scored according to the following criteria :

1. Correctness: no crash, no half full or half empty tanks
2. How close your final product is from the input formula
3. Comments and idiomatic style
4. Minimum number of steps to get to the result
5. Speed of the code

## Glossary

[^1]: [House Krug Champagne](https://www.krug.com/fr/la-maison-krug)
[^2]: Complexity
...
