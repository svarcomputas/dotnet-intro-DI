##Oppgave 1

Her finnes en `PersonRepository.cs` klasse som er avhengige av en database. Databasen har en funksjon som kan hente ut person med personens Id. Ønsket er at `PersonRepository.cs` skal ta inn databasen ved bruk av dependency injection

Endringer må gjøres i:
- Legg til at Databasen kan bli hentet inn med DI i `Startup.cs`
- PersonRepository.cs 
- Implementer funksjonen i Database/IDatabase.cs