## Oppgave 4

Vi ønsker nå å simulere et API kall (ved bruk av `Program.cs` fila), kallet skal returnere BetalingsOppsummerings klassen, den er implementert i `BetalingsExtensions.cs`
Vi ønsker å bruke Servicen `IPersonService` til å gjøre buisness logikken vår 
Interfacet og logikken der er implementert. Men konstruktøren skal ta inn `IBetalingsRepository` og `IPersonRepository` derfor må også `BetalingsRepository` og `PersonRepository` klassene skrives om til interfacer. 

Det som skal gjøres:
- Implementer interfacet i `IBetalingsRepository`
- Implementer interfacet i `IPersonRepository`
- Implementer konstruktøren i `PersonService` klassen
- I `Startup.cs` legg til klassene `IBetalingsRepository`, `IPersonRepository` og `IPersonService` tilgjenglig for dependency injection. 