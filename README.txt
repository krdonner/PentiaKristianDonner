Navigering:

NavBar, Pentia Car Dealership - tar en till Home/Index
NavBar, Home - tar en till Home/Index
NavBar, About - tar en till Home/About
NavBar, Contant - tar en till Home/Contact
NavBar, Customers - tar en till Customers/Index


Customers/Index:

// Dessa metoder �r inte testade fullt ut s� reserverar mig f�r att de kan fallera. 
Create New - skapa ny customer
Edit - �ndra customer 
Details - Se detaljer i lista 
Delete - Ta bort anv�ndare
--------------------------

Anv�nd s�kf�ltet f�r att s�ka via antingen namn, adress, tillverkare, modell eller f�rs�ljare. 
Detta g�rs genom att trycka p� respektive knapp. 
En s�ktsr�ng skickas till Index metoden i CustomerControllern. D�r g�rs en check f�r att 
verifiera vilken knapp som �r tryckt. D�refter skickas s�kstr�ngen till respektive metod i SQLHandler/Searches beroende p� vad 
man valt att s�ka p�. D�r anv�nds LINQ f�r att s�ka i databasen. 
Metoderna returnerar sedan en lista med modellen Customer som returneras till View f�r att visa s�kresultatet. 


K�nner ni att ni vill ha mer testadata s� k�r migrations-filen. Notera att jag ej tagit bort contexts i Web.config. 
