# 2022-2023 - PROJECT5 - ALGORITHMS & DATA STRUCTURE - TEAM 2

## Functional Specifications

<hr>
<details>
<summary>📖 Table of content</summary>

- [2022-2023 - PROJECT5 - ALGORITHMS \& DATA STRUCTURE - TEAM 2](#2022-2023---project5---algorithms--data-structure---team-2)
  - [Functional Specifications](#functional-specifications)
    - [1. Introduction - Overview](#1-introduction---overview)
    - [2. Objective](#2-objective)
    - [3. Stages of champagne production](#3-stages-of-champagne-production)
    - [4. Personas](#4-personas)
      - [A. The Tester:Client](#a-the-testerclient)
      - [B. The Workers](#b-the-workers)
    - [5. Use case](#5-use-case)
    - [6. Blending step and the formula of Krug Grande Cuvée](#6-blending-step-and-the-formula-of-krug-grande-cuvée)
    - [7. Functionalities](#7-functionalities)
    - [8. User interface](#8-user-interface)
    - [9. Software architecture](#9-software-architecture)
    - [10. Evaluation criteria](#10-evaluation-criteria)
    - [11. Conclusion](#11-conclusion)
    - [Glosary](#glosary)

</details>
<hr>

### 1. Introduction - Overview

Introduction:
Krug Champagne is a prestigious brand of champagne that is part of the LVMH group. Known for its high quality and unique flavor profile, Krug Champagne is made using the traditional method, also known as "méthode champenoise", which involves a complex process of fermentation and aging. The grapes used to make Krug Champagne are typically harvested in September or October, and the most commonly used grape varieties are Pinot Noir, Pinot Meunier, and Chardonnay.

Krug Grande Cuvée, one of Krug Champagne's flagship blends, is made using a combination of 250 wines from the current year and 150 "reserve" wines from the past 14 years. The Cellar Master, Julie Cavil, and her team spend about 9 months tasting different combinations of wines until they find the perfect formula. Once the formula is determined, the challenge becomes blending large quantities of wine in the right proportions.

Krug Champagne is highly regarded by wine connoisseurs and is often considered one of the best champagnes in the world. Its distinctive flavor profile and exceptional quality make it a sought-after luxury brand.

Overview:
The software will assist the Cellar Master and her team in blending the different still wines to create a consistent flavor profile for the Krug Grande Cuvée. The software will optimize the blending process to ensure that the final product is as close as possible to the desired formula, using the minimum number of steps, and without any waste.

### 2. Objective

Blending: The still wines from different vineyards and grape varieties are blended together to create a consistent flavor profile:

1. Develop a program that can read and parse data on the different vineyards and grape varieties, as well as their respective characteristics and flavor profiles, and use this information to create a blended wine with a consistent flavor profile.
2. Create an algorithm that can adjust the ratios of the individual wines in the blend based on their respective characteristics, such as acidity, tannins, and sweetness, in order to create a well-balanced and harmonious final product.
3. Implement a user interface that allows the user to input information on the different wines and vineyards, as well as specify the desired flavor profile for the blended wine, and displays the resulting blend with information on its characteristics and flavor profile.
4. Develop a database that can store information on the different wines and vineyards, as well as track the inventory of the individual wines and the blending process itself, in order to ensure consistency and quality control.
5. Implement a testing framework that can validate the consistency of the blended wine over time, as well as its adherence to the desired flavor profile, in order to ensure that the blending process is working effectively.

### 3. Stages of champagne production

There are nine steps for the production :

1. Harvesting:

- The most commonly used grape varieties are Pinot Noir, Pinot Meunier, and Chardonnay. They are harvested in September or October.

2. Pressing:

- We extract the juice of the grape and we stored in tanks or barrels for fermentation.

1. First fermentation:

- Inside stainless steel tanks or oak barrels, we added yeast to the juice, which convert sugar in alcohol. It's a process that takes two weeks.

4. Blending:

- We blended differents grape varieties to create a consistent flavor profile.

5. Second fermentation:

- The wine is bottled and a mixture of sugar and yeast is added. The bottles are then sealed with a cap and stored horizontally in cool, dark cellars. The second fermentation then takes place in the bottle and the carbon dioxide produced by the yeast is trapped in the wine, creating bubbles.

6. Aging:

- The bottles are aged on their lees (the dead yeast cells) for at least 15 months for non-vintage champagne, and at least three years for vintage champagne. During this period, the wine develops complex aromas and flavours.

7. Riddling:

- After aging, the bottles are gradually turned and tilted, either manually or by machine, to move the lees towards the neck of the bottle.

8. Disgorgement:

- Once the lees have settled in the neck of the bottle, the bottles are opened and the frozen cork is removed. This process is called disgorging.

9. Dosage:

- After disgorgement, a mixture of wine and sugar (known as the dosage) is added to the champagne to adjust its sweetness level. The bottles are then corked, wired, and labeled.

### 4. Personas

#### A. The Tester:Client

The client will test the flavour of the resulting mixture of several wines that have done.

#### B. The Workers

The worker will produce several flavour as much as possible by mixing particular ammounts of wines in various tanks.

### 5. Use case

### 6. Blending step and the formula of Krug Grande Cuvée

 1. Gather data on the different vineyards and grape varieties that will be used in the blend.
 2. Collect data on the individual wines that will be used in the blend. This might include information on the grapes used to make each wine, aging process, and other factors that might impact the flavor profile of the wine.
 3. Develop an algorithm that can adjust the ratios of the individual wines in the blend based on their respective characteristics. This algorithm might take into account factors such as acidity, tannins, sweetness, and aroma, as well as the desired flavor profile for the final blend.
 4. Create a user interface that allows the user to input information on the different wines and vineyards profile for the blended wine. The interface might include features such as dropdown menus, sliders, and other interactive elements to make it easy for the user to customize the blend.
 5. Implement a database that can store information on the different wines and vineyards, as well as track the inventory of the individual wines and the blending process itself. This database might include tables for storing data on the grape varieties, vineyards, and individual wines.
 6. Develop a testing framework that can validate the consistency of the blended wine over time.
 7. Once the system has been developed and tested, it can be used to blend individual batches of wine to create a consistent flavor profile over time. The user can input information on the individual wines and vineyard and the system will generate a customized blend based on the algorithm and database.

### 7. Functionalities

The system will be used to blend individual batches of wine to create a consistent flavor profile over time.
The information on the individual wines and vineyard and the system will generate a customized blend based on the algorithm and database.

### 8. User interface

The programmes will be running on both Windows and MacOS.

### 9. Software architecture

The software could be developed using a layered architecture, with each layer responsible for a specific set of functionalities.

The presentation layer would be the user interface that the Cellar Master and her team would interact with. This layer would be developed using .NET 6.0's WPF (Windows Presentation Foundation) framework, which provides a modern, visually appealing interface with advanced data binding and styling capabilities.

The business logic layer would handle the core functionality of the software, including the blending algorithms and data validation. This layer would be developed using C# and .NET 6.0's latest features, such as C# 10 and the new record types, to ensure maximum performance and maintainability.

The data access layer would be responsible for handling data storage and retrieval, such as keeping track of the tanks and their current contents. This layer would be developed using .NET 6.0's EF Core (Entity Framework Core) framework, which provides a powerful and flexible ORM (Object-Relational Mapping) toolset for working with databases.

To ensure that the software is reliable and fault-tolerant, it would be designed using the SOLID principles and unit tested extensively using .NET 6.0's built-in testing framework. Additionally, the software could be deployed using Docker containers and managed using Kubernetes to ensure scalability and resilience.

Overall, this architecture would provide a robust and scalable software solution for the Krug Champagne blending process, built using the latest and most advanced technologies in the .NET ecosystem.

### 10. Evaluation criteria

Here are the criteria that will be used to evaluate the software:

1. Correctness: no crash, no half full or half empty tanks
2. How close your final product is from the input formula
3. Comments and idiomatic style
4. Minimum number of steps to get to the result
5. Speed of the code

### 11. Conclusion

Overall, the goal of the project is to create a system that can produce high-quality blended wines with a consistent flavor profile, while also allowing for customization and flexibility based on user input.

### Glosary
