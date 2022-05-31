# Startdocument voor de camping opdracht

Startdocument van **Yannieck Blaauw**. Student number **4976207**.

## Problem Description

Bij een **camping** komen reserveringen binnen. De volgende tarieven worden
door de **camping** gehanteerd: *Per **plaats** € 15,-. Daarbij per persoon € 2,50 en*
*voor de auto € 3,-. Van 11 juli t/m 15 augustus geldt een toeslag van 25%.*
Er dient een programma te worden ontwikkeld waarmee voor iedere **reservering** de *begin- en einddatum (formaat ddmmjjjj)*, evenals het *aantal personen*
en *wel of geen auto kunnen worden ingevoerd*. Voor elke **reservering** moeten
de *verschuldigde kosten* worden berekend. Verder moeten cumulatief
de *totale inkomsten*, het *gemiddeld aantal dagen waarvoor gereserveerd wordt*
en het *totaal aantal personen* worden getoond. 

### Invoer & Uitvoer

In dit onderdeel zullen de in- en output van de aplicatie beschreven worden.

#### Invoer

In de onderstaande tabel zal de invoer beschreven worden.

| Case              | Type       | Conditions   |
| ----------------- | ---------- | ------------ |
| Camping naam      | `string`   | not empty    |
| Camping adres     | `string`   | not empty    |
| Reserveringsdatum | `DateTime` | `date` > now |
| Reserveringsduur  | `int`      |`number` > 0  |
| Aantal personen   | `int`      | `number` > 0 |
| Auto              | `boolean`  | -            |
| Plaatsnaam        | `string`   | not null     |

#### Uitvoer

In de onderstaande tabel zal de uitvoer beschreven worden.

| Case                        | Type    |
| --------------------------- | ------- |
| Reserveringsprijs           | `float` |
| Gemiddelde reserveringsduur | `int`   |
| Totaal aantal personen      | `int`   |
| Totale inkomsten            | `float` |

#### Berekeningen

| Case                        | Calculation                                                               |
| --------------------------- | ------------------------------------------------------------------------- |
| Reserveringsprijs           | De prijs om een plek te reserveren aan de hand van personen, auto en duur |
| Gemiddelde reserveringsduur | De gemiddelde duur van alle reserveringen                                 |
| Totaal aantal personen      | Het aantal personen op de camping                                         |
| Totale inkomsten            | De inkomsten van de camping                                               |

#### Opmerkingen

* Input zal gevalideerd worden.

## Klassendiagram

![Klassendiagram](ClassDiagram.png "Eerste versie van het klassendiagram")

## Testplan

In dit onderdeel zal beschreven worden hoe de aplicatie getest gaat worden.

### Test Data

In de volgende tabel staat alle benodigde data nodig voor het testen.

#### Camping

| Naam                | Adres                | Invoer | Code                                                     |
| ------------------- | -------------------- | ------ | -------------------------------------------------------- |
| `Camping de Lakens` | `Zeeweg 60 Overveen` |        | `new Camping("Camping de Lakens", "Zeeweg 60 Overveen")` |

#### Reservering

| Begindatum    | Einddatum     | Aantal Personen | Auto    | Invoer| Code                                                      |
| ------------- | ------------- | --------------- | ------- | ----- | ----------------------------------------------------------|
| `May 20 2022` | `Jun 20 2022` | 4               | `true`  |       | `new Reservation("May 20 2022", "Jun 20 2022", 4, true)`  |
| `Jun 12 2022` | `Jun 19 2022` | 2               | `false` |       | `new Reservation("Jun 12 2022", "Jun 19 2022", 2, false)` |

#### Plaats

| Plaatsnaam   | Invoer | Code               |
| ------------ | ------ | ------------------ |
| `A100`       |        | `new Place(A100)`  |
| `B101`       |        | `new Place(B101)`  |

### Test Cases

In dit gedeelte zullen de testgevallen omschreven worden. Alle testgevallen moeten uitgevoerd worden met de test data als startpunt.

|Reserveringsprijs|`float`|
|Gemiddelde reserveringsduur|`int`|
|Totaal aantal personen|`int`|
|Totale inkomsten|`float`|

#### #1 Reserveringsprijs

Verifieer de prijs van een reservering.

| Stap | Invoer                              | Actie              | Verwachte Uitvoer |
| ---- | ----------------------------------- | ------------------ | ----------------- |
| 1    | `May 20 2022, Jun 20 2022, 4, true` | `calculatePrice()` | `868,00`          |

#### #2 Gemiddelde Reserveringsduur

Verifieer de gemiddelde reserveringsduur.

| Stap | Invoer                        | Actie                              | Verwachte Uitvoer |
| ---- | ----------------------------- | ---------------------------------- | ----------------- |
| 1    |                               | Reserveringen ophalen uit database |                   |
| 2    | Reserveringsduur uit database | Gemiddelde berekenen               | `19`              |

#### #3 Totaal Aantal Personen

Verifieer het aantal personen op de camping.

| Stap | Invoer                       | Actie                              | Verwachte Uitvoer |
| ---- | ---------------------------- | ---------------------------------- | ----------------- |
| 1    |                              | Reserveringen ophalen uit database |                   |
| 2    | Aantal personen uit database | Aantal personen optellen           | `6`               |

#### #4 Totale Inkomsten

Verifieer de totale inkomsten

| Stap | Invoer                           | Actie                              | Verwachte Uitvoer |
| ---- | -------------------------------- | ---------------------------------- | ----------------- |
| 1    |                                  | Reserveringen ophalen uit database |                   |
| 2    | Reserveringsprijzen uit database | Prijzen optellen                   | `1028,00`         |
