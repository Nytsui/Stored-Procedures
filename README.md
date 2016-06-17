# Stored-Procedures

Gruppenprojekt 'Stored Procedures' von Julia, Sefa und Justin

Aufgabe: https://eick-at-de.prossl.de/templates/test1/index.php?sid=0d02c0c83483b96bc13c23023fe76383&objectId=1344&opendirId=341&aktPosition=8&posIndex=8

1.Programmieren Sie eine Methode getRoot(int id):int in einer beliebigen Programmiersprache, die die Wurzel-ID der übergebenen ID ermittelt. Die Methode soll dabei die gespeicherte Prozedur GetRootIDbyID(int id):int aufrufen, die sich entweder selbst rekursiv aufruft bis die Root-ID gefunden ist oder mittels einer Schleife danach sucht. 

2. Die Aufgabe soll nun ohne stored procedure gelöst werden, indem sich getRoot(int id):int zur Ermittelung der ParentID jeweils eine neue DB-Abfrage macht, solange die Root-ID erreicht ist. Ziel dabei ist ein Performance-Vergleich beider Lösungsansätze.

