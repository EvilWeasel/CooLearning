# IEnumerable und der ForEach Loop

Das IEnumerable-Interface in C# ist eine wichtige Schnittstelle, die in vielen Situationen in der Programmierung nützlich ist. Grundsätzlich ermöglicht sie es, Objekte durchzugehen, eines nach dem anderen.

Stell dir vor, du hast eine Sammlung von Daten, sei es eine Liste, ein Array oder etwas anderes. Indem du das IEnumerable-Interface implementierst, ermöglichst du, dass Objekte in dieser Sammlung nacheinander durchlaufen werden können.

Das foreach-Statement in C# verwendet IEnumerable, um durch die Elemente einer Sammlung zu iterieren. Wenn du also deine eigene Datenstruktur erstellst und das IEnumerable-Interface implementierst, kannst du diese Struktur genauso einfach mit einer foreach-Schleife durchgehen wie eine reguläre Liste, eine Map, ein Array oder ähnliche Datenstrukturen.

## Aufgabe

Im folgenden Code haben wir einen Compiler-Fehler in der Program.cs. Da unsere `GamesLibrary` noch nicht `IEnumerable` implementiert, können wir noch nicht durch den `foreach` loop iterieren.

## Zur Umsetzung

Du musst zwei Schnittstellen implementieren:

**IEnumerable und IEnumerator**

### IEnumerable

Das IEnumerable-Interface enthält folgende Methoden/Eigenschaften:

- GetEnumerator() => gibt eine Instanz von IEnumerator zurück.

Der Enumerator ist Verantwortlich dafür, wie durch die Sammlung iteriert wird.

### IEnumerator

Die IEnumerator-Schnittstelle wiederum enthält folgende Methoden/Eigenschaften:

- Dispose() => wird aufgerufen, bevor der Garbage-Collector den Speicher des Enumerator freigibt.
  - Diese kann für unser Beispiel ignoriert werden.
- MoveNext() => um `Current` zum nächsten Element zu wechseln.
  - Verändert `Current` so, dass es auf den nächsten Wert in der iteration zeigt und gibt **true** zurück, solange iteriert werden kann. Wenn die Collection zu Ende ist und wir keinen nächsten Wert haben, so muss **false** zurückgegeben werden.
- Current => Ruft das aktuelle Element ab.

## Definition of Done

**Die Aufgabe gilt als erfüllt, wenn das Programm kompiliert UND ausgeführt werden kann**, ohne dabei eine Änderung an der `Program.cs` Datei vorzunehmen.

Viel Erfolg!
