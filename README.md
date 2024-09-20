# 🧩 Design Patterns Showcase 🚀

Welcome to the **design_patterns** repository! 🎨 This project is dedicated to implementing various design patterns in C# through small console applications. 
The primary goal is to apply and understand design patterns in practical scenarios, project ideas are generated with the help of ChatGPT but coded by me. 🤖💻

🚨 **Disclaimer**
This repository was created as part of my learning process for understanding design patterns in C#. 
There might be mistakes or non-optimized code. Any feedback or suggestions for improvement are welcome!
# 📚 What’s Inside?

In this repository, you’ll find:
Small console applications demonstrating different design patterns.

## 1) 📈🔔 Stock App Notifier
Implementing the **Strategy** and **Observer** patterns, this app keeps you updated on stock price changes with customizable investment strategies. 📉📈

## 2) 🎮🕹️ Game Manager
This app uses the **Singleton** pattern to ensure there's only one game manager overseeing your games, and the **Strategy** pattern to handle different game strategies. Manage and strategize across various games with ease! 🏆🎲

## 3) 📄 Document Processing System

A simple project showcasing the use of the **Factory** and **Template Method** design patterns to manage and process various types of documents. 📄
- **Factory Pattern**: Creates different document processors (e.g., invoices, letters) 🏷️
- **Template Method Pattern**: Defines a template for processing documents with customizable steps ✏️

## 4) ☕️ CompileAndDrinkCoffeeCorner 🥐
A simple coffee shop simulation built to demonstrate the **Abstract Factory** and **Template Method** design patterns in C#.
- **Abstract Factory Pattern**: Used to create families of related objects (like coffee and pastries) without specifying their exact classes.
- **Template Method Pattern**: Defines the steps for preparing coffee and pastries, allowing subclasses to specify some of the steps without changing the overall algorithm.
### 🤔 Problem Faced
While implementing the design patterns, I encountered a challenge with redundant method overrides. Initially, I created overrides for PrepareCoffee() and PreparePastry() in the concrete classes (Latte, Pie, Croissant) that simply called the base methods.
## 5) 🏡 Home Automation Console App

This project is a console application that simulates a smart home system, allowing users to control devices like bulbs and airconditioners, simple commands.

 - **Strategy**: Different devices can operate in various modes, such as EcoMode, NormalMode, and AwayMode, to suit user preferences.
 - **Command**: To handle device interactions, providing a clean and organized way to manage commands.

### 🤔 Problem Faced: Modes were specific to each device type. Allowing unrelated modes to affect different devices led to potential confusion and unintended behaviors.

To enhance the design of the home automation system, each device can inherit from a common interface, such as `IMode`. This would allow for the creation of specialized mode classes for each device type, such as:
- **IBulbMode**: An interface specifically for bulb modes.
- **AwayMode**, **EcoMode**, and **NormalMode**: Classes that implement the `IBulbMode` interface, defining the behavior for each mode.


