Navigering:

NavBar, Pentia Car Dealership - tar en till Home/Index
NavBar, Home - tar en till Home/Index
NavBar, About - tar en till Home/About
NavBar, Contant - tar en till Home/Contact
NavBar, Customers - tar en till Customers/Index


Customers/Index:

Create New - skapa ny customer
Edit - ändra customer
Details - Se detaljer i lista 
Delete - Ta bort användare
--------------------------

Använd sökfältet för att söka via antingen namn, adress, tillverkare eller modell. 
Detta görs genom att trycka på respektive knapp. 
En söktsräng skickas till Index metoden i CustomerControllern. Där görs en check för att 
verifiera vilken knapp som är tryckt. Därefter skickas söksträngen till respektive metod i SQLHandler/Searches beroende på vad 
man valt att söka på. Där används LINQ för att söka i databasen. 
Metoderna returnerar sedan en lista med modellen Customer som returneras till View för att visa sökresultatet. 
