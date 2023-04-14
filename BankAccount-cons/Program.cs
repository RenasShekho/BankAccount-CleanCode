using BankAccount_cons;
using System;
using System.Runtime.InteropServices;
/* Opgave 2

 1-Lave en klasse BankAccount, som har en instance variable balance og to metoder withdraw og deposit
 2-Lav en print metode, som udskriver balencen
 3-Gør balance privat, så den kun kan tilgåes via metoder
 4-Lav withdraw modstandsdygtig overfor overtræk
 5-Lav en "brugergrænseflade" til bank systemet i en separat fil */


BankAccount account = new BankAccount(500);
User.Menu(); // call Menu method in user class    
User.optins(account);



