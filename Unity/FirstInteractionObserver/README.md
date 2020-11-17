# Beispiel für ein Projekt mit verschiedenen Packages

Dieses Verzeichnis verwendet drei verschiedene Packages für die Erstellung von Unity-Anwendugnen:

1. Desktop-Anwendung mit Unity, ohne weitere Packages
1. VR-Anwendung mit MiddleVR 1.x, setzt eine Installation von MVR voraus.
1. VR-Awendung mit Vive Input Utility, mit einem Build für Windows (Simulator oder Vive Pro).

## Aufbau des Projekts
Um die Teste zu erleichtern sind alle verwendeten Packages im repo enthalten. Die Szene enthält immer nur eine sehr einfache Konfiguration, wir sehen einige Kugeln und eine Visualisierung des Weltkoordinatensystems. 

Für jedes der Packages gibt es eine Szene, die neben den Assets die Klassen aus VIU oder MVR enthält. Die Szenen heißen

- helloScene
- helloVIU
- helloMVR

Alle Szenen sollten in den Build-Settings aufgenommen sein. Für das entsprechende Build sollte nur die passende Szene aktiviert sein.

## Scripte
Wie die Demo in VRDemos führt auch dieses Projekt eine sehr einfache Interaktion durch - mit Hilfe eines Buttons können wir die Farbe eines Objekts verändern. Um zu zeigen, dass wir sehr gut Design Patterns verwenden können ist das Observer Pattern implementiert. Der Unterschied zwischen den verschiedenen Packages besteht darin, wie der vewendete Button abgefragt wird.

Dazu gibt es die Klasse View, die von der Basisklasse Observer abgeleitet ist. Dort wird alles, was unabhängig vom Package ist, für die View gesetzt. Also zum Beispiel die beiden Farben für das Highlighting. Die Abfrage des Buttons findet dann in einer der drei von View abgeleiteten Klassen

- ViewStandalone
- viewVIÜU
- View MVR

statt. Dort ist der spezifische Code für die Abfrage für das verwendete Package implementiert. In den jeweiligen Szenen wird dem Objekt, das die Farbe wechseln soll einer dieser drei Klassen zugewiesen.

# To Dos
Dieses Projekt ist vor der Arbeit am Repository VRKL entstanden und verwendet deshalb noch nicht das Package MBU. Das sollten wir in Zukunft ändern, aber da der Fokus auf der Arbeit mit verschiedenen Packages liegt wurde aktuell darauf verzichtet.

In MBU ist die Hello-World-Szene verfügbar, auch die Basisklassen für das Observer-Pattern liegen in diesem Package.
