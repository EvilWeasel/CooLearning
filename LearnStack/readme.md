# Stack Implementierung in C#

## Was ist ein Stack?

Ein Stack ist eine Datenstruktur, die nach dem Last-In-First-Out (LIFO) Prinzip funktioniert. Das bedeutet, dass das zuletzt hinzugefügte Element als erstes entfernt wird. Du kannst es dir wie einen Stapel von Büchern vorstellen, bei dem du immer nur das oberste Buch hinzufügen oder entfernen kannst.

## Wofür ist ein Stack nützlich?

Ein Stack ist in vielen Anwendungsfällen nützlich, besonders wenn die Reihenfolge, in der Elemente hinzugefügt oder entfernt werden, wichtig ist. Hier sind einige Beispiele:

- **Undo-Funktionen:** Ein Stack kann verwendet werden, um Aktionen in einer Anwendung zu speichern, sodass Benutzer sie rückgängig machen können.
- **Browserverlauf:** Der "Zurück"-Button in einem Browser verwendet oft einen Stack, um die besuchten Seiten zu verfolgen.
- **Arithmetische Ausdrücke:** Beim Auswerten von arithmetischen Ausdrücken können Stacks dazu verwendet werden, den Zustand der Operanden und Operatoren zu verfolgen.

## Aufgabe

In der vorliegenden Übung musst du die Implementierung eines Stacks in C# vervollständigen. Ein vorgefertigter Code gibt vor, wie ein Stack genutzt wird, und deine Aufgabe ist es, die Methoden des "LearnStack"-Objekts zu implementieren.

### Umsetzung

Du musst die folgenden Methoden im "LearnStack"-Objekt vervollständigen:

- **Push(T item):** Füge ein Element zum Stack hinzu. Wenn der Stack voll ist, gib eine Fehlermeldung aus und tue nichts.
- **Pop():** Entferne das oberste Element aus dem Stack und gib es zurück. Wenn der Stack leer ist, gib eine Fehlermeldung aus und gib den Standardwert von T zurück.
- **Peek():** Sieh dir das oberste Element im Stack an, ohne es zu entfernen. Wenn der Stack leer ist, gib eine Fehlermeldung aus und gib den Standardwert von T zurück.
- **IsEmpty():** Überprüfe, ob der Stack leer ist.
- **PrintStack():** Gib die aktuellen Elemente des Stacks aus. Wenn der Stack leer ist, gib eine entsprechende Meldung aus.

### Definition of Done

Die Aufgabe ist erfüllt, wenn das Programm erfolgreich kompiliert und ausgeführt werden kann, ohne dass Änderungen an der `Program.cs`-Datei erforderlich sind. Die letzte Nachricht in der Konsole sollte sein: "You did it!"
Viel Erfolg beim Implementieren! 🚀👩‍💻
