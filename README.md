# LemonadeStand

As a developer, if I don’t know what Lemonade Stand game is, I will play the game online for a bit to get familiar with the gameplay.
---(5 points): As a developer, I want to make good, consistent commits.
---(25 points): As a player, I want the basic Lemonade Stand gameplay to be present.
---(10 points): As a player, I want a weather system that includes a forecast and actual weather, so that I can get a 
---predicted forecast for a day or week and then what the actual weather is on the given day.
//should predicted forecast for the week dictate what the weather actually is on any given day?
---(10 points): As a player, the price of product as well as weather/temperature should affect demand, so that if the price is ----too high, 
---sales will decrease, or if the price is too low, sales will increase, etc. 
---(10 points): As a player, I want each customer to be a separate object with its own chance of buying a glass of lemonade, 
---so that how much lemonade is purchased and how much a customer is willing to pay will vary from customer to customer.
//customers are seperate objects, but they dont have individual characterstics like often exampled in lectures (stingy old man, ect.)
---(5 points): As a player, I want the ability to make a recipe for my lemonade, so thatI can include x-amount of lemons, x-amount of sugar, 
---and x-amount of ice. 
---(10 points): As a player, I want my game to be playable for at least seven days.
---(10 points): As a player, I want my daily profit or loss displayed at the end of each day, so that I know how much money my ---lemonade stand has
----made. I also want mytotal profit or loss to be a running total that is displayed at the end of each day,
---so that I know how much money my lemonade stand has made. 
---(10 points): As a developer, I want to implement the SOLID design principles as well as C# best practices in my project, 
----so that project is as well-designed as possible.
----(10 points (5 points each)): As a developer, I want to pinpoint at least two placeswhere I used one of the SOLID design 
---principles 
 ----and discuss my reasoning, so that I can properly understand good code design. Minimum of two SOLID design principlesmust be ---used. 

        Bonus Points:
---(5 points): As a player, I want the game to be playable for more than one player, so that I can have 
----multiple humans play each other or a human play a computer.
---(5 points) As a developer, I want to integrate a Weather API, so that my game has real-time weather based on a current 
----temperature and forecast.

        Classes You Will Use (you may need more than what is provided):
        Program 
        Weather
        Customer
        Game
        Inventory
        Player
        Store
        Day
        User Interface

        ---Show where in code you've used each of these---
        //-Single responsibility principle[6]
        A class should have only a single responsibility, that is, only changes to one part of the software's specification 
        should be able to affect the specification of the class.
        //-Open–closed principle[7]
        "Software entities ... should be open for extension, but closed for modification."
        -Liskov substitution principle[8]
        "Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." 
        See also design by contract.
        -Interface segregation principle[9]
        "Many client-specific interfaces are better than one general-purpose interface."[4]
        -Dependency inversion principle[10]
        One should "depend upon abstractions, [not] concretions."[4]
        ---------------------------------------------------------------
        --try to use each one of these--
	Take out any random() from member variables (customer class)
        Static class UI
        Abstraction
        Encapsulation
        Inheritance
        Polymorphism
        Get and set inventory and money to zero if/when it hits the negative range
        ---------------------------------------------------------------
        
