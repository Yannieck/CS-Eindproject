# Startdocument voor de camping opdracht

Startdocument van **Yannieck Blaauw**. Student number **4976207**.

## Problem Description

Bij een camping komen reserveringen binnen. De volgende tarieven worden
door de camping gehanteerd: Per plaats € 15,-. Daarbij per persoon € 2,50 en
voor de auto € 3,-. Van 11 juli t/m 15 augustus geldt een toeslag van 25%.
Er dient een programma te worden ontwikkeld waarmee voor iedere reservering de begin- en einddatum (formaat ddmmjjjj), evenals het aantal personen
en wel of geen auto kunnen worden ingevoerd. Voor elke reservering moeten
de verschuldigde kosten worden berekend getoond. Verder moeten cumulatief
de totale inkomsten, het gemiddeld aantal dagen waarvoor gereserveerd wordt
en het totaal aantal personen worden getoond. 

### Input & Output

In dit onderdeel zullen de in- en output van de aplicatie beschreven worden.

#### Input

In de onderstaande tabel zal de input beschreven worden.

|Case|Type|Conditions|
|----|----|----------|
|Customer number|`integer`|0 < `number` < 20|
|Name Of Customer|`String` |not empty|
|City Of Customer|`String` |not empty|
|Customer Discount|`double`|0 < `number` <= 100|
|Product name|String|not empty|
|Product price|`double`|`number` > 0|

#### Output

In de onderstaande tabel zal de output beschreven worden.

|Case|Type|
|----|----|
|Customers from a certain city|`ArrayList<Customer>`|
|The profit of the store|`double`|
|The price of a order|`double`|

#### Calculations

| Case              | Calculation                        |
| ----------------- | ---------------------------------- |
| Price of an order | The sum of all the product prices. |

#### Remarks

* Input will be validated.
* Only the Main class will contain `System.out.println`
* Unit Tests will be provided.

## Class Diagram

![Class Diagram](images/classdiagram.png "Second Version of the class diagram")

## Testplan

In this section the testcases will be described to test the application.

### Test Data

In the following table you'll find all the data that is needed for testing.

#### Product

| ID            | Input                             | Code                              |
| ------------- | --------------------------------- | --------------------------------- |
| `playstation` | name: PlayStation<br />price: 250 | `new Product("PlayStation", 250)` |
| `imac`        | name: iMac<br />price: 1400       | `new Product("iMac", 1400)`       |

#### Customer

| ID        | Input                                                        | Code                                               |
| --------- | ------------------------------------------------------------ | -------------------------------------------------- |
| `jan`     | number: 1<br />name: Jan<br />city: Emmen                    | `new Customer(1, "Jan", "Emmen")`                  |
| `martijn` | number: 2<br />name: Martijn<br />city: Emmen<br />discount: 20% | `new PremiumCustomer(2, "Martijn", "Emmen", 20.0)` |

#### Store

| ID           | Input | Code          |
| ------------ | ----- | ------------- |
| `mediamarkt` |       | `new Store()` |

#### Order

| ID           | Input               | Code                 |
| ------------ | ------------------- | -------------------- |
| `appleorder` | customer: `jan`     | `new Order(jan)`     |
| `psorder`    | customer: `martijn` | `new Order(martijn)` |

#### Attach Products To Orders

| Order        | Code                      |
| ------------ | ------------------------- |
| `appleorder` | `addProduct(imac)`        |
| `psorder`    | `addProduct(playstation)` |
| `psorder`    | `addProduct(playstation)` |

### Test Cases

In this section the testcases will be described. Every test case should be executed with the test data as starting point.

#### #1 Customer Number Prefix

Verifying the prefix of the user. The customer number should be prefixed.

|Step|Input|Action|Expected output|
|----|-----|------|---------------|
|1| `jan` | `getNumberWithPrefix()` |MM_1|

#### #2 Get All The Customers From A City

Testing the method to get all the customers from a city. 

|Step|Input|Action|Expected output|
|----|-----|------|---------------|
|1|`mediamarkt`|`getCustomersFromCity("Emmen")`|Empty ArrayList|
|3|`mediamarkt`|`addOrder(appleorder`)||
|4|`mediamarkt`| `getCustomersFromCity("Emmen")` | ArrayList with customer `jan` |

#### #3 Remove Customers With A Smaller Customer ID

Testing that we can remove customers based on the id lower than the given input.

|Step|Input|Action|Expected output|
|----|-----|------|---------------|
|1|`mediamarkt`|`removeCustomers(1)`||
|2| `mediamarkt` |`getCustomers()`|ArrayList with only customer `martijn`|

#### #4 Get Order Price

Testing the price method for an order. The `psorder` has a `PremiumCustomer` attached.

| Step | Input        | Action       | Expected output |
| ---- | ------------ | ------------ | --------------- |
| 1    | `appleorder` | `getPrice()` | 1400            |
| 2    | `psorder`    | `getPrice()` | 400             |

#### #5 Get Store Profit

Testing the total store profit.

| Step | Input        | Action                 | Expected output |
| ---- | ------------ | ---------------------- | --------------- |
| 1    | `mediamarkt` | `addOrder(appleorder)` |                 |
| 2    | `mediamarkt` | `getProfit()`          | 1400            |
| 3    | `mediamarkt` | `addOrder(psorder)`    |                 |
| 4    | `mediamarkt` | `getProfit()`          | 1900            |
