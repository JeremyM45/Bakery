# _Bakery_

#### By _**Jeremy Martin**_

#### _A console application store front for a Bakery_

## Technologies Used

* C#
* MSTests
* .NET 5.0

## Description

This console app will ask you if you want to order bread or pastries. After choosing it will ask you how many you want, then it will ask you if you want any of the other (e.g. if you choose bread then input the amount of bread loafs you want it will ask if you want to add any pastries to your order). It will total up your order and display it back to you. There are also three specials: Every 3rd bread loaf is free, Every 3rd pastry is half off, and All orders over 20 items are 10% off (discounts stack so you can order 9 loafs of bread getting 3 for free, 12 pastries getting 4 half off, and since 9+12 is over 20 the entire order will be 10% off as well) .

## Setup/Installation Requirements

### Getting Started
* Clone repo from GitHub using this link (https://github.com/JeremyM45/Bakery)

* Navigate to the Bakery.Solution folder in terminal 
```
(Users/Username/Desktop/Bakery.Solution)
```
* cd into the Bakery.Tests folder
 ```
cd Bakery.Tests
```
* Type dotnet retore in terminal
```
dotnet restore
```
* Leave the Bakery.Tests folder
```
cd ..
```
* cd into the Bakery folder
```
cd Bakery
```
* Then type dotnet run in the terminal
```
dotnet run
```

### Using the app
* The app will ask you if want to order bread or pastries, type either bread or pastries to make your choice and hit enter
* It will then ask you how many you want, input the number of how many you want and hit enter
* It will next ask you if want to add any of the other item to your order (if you first chose bread it will now ask if you want to add pastries and vice versa). Input Y for yes or N for no and hit enter.
	* If you input Y it will ask you how many you want to add to your order, input however many you want and hit enter.
	* If you input N it will move on to the next step.
* The app will now display your order back to you along with the price.
## Known Bugs

*  _No known bugs_

## License

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) _2022_  _Jeremy Martin_