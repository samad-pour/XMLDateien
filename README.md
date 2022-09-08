# XML-Dateien

XML ist ein weitverbreitetes, plattformunabhängiges Datenformat, das sich zum universellen Datenaustausch eignet.

## 1 Schreiben in eine XML-Datei

### 1.1 XmlTextWriter

Das Objekt dient als »Schreibwerkzeug« zur Erzeugung einer XML-Datei.

### 1.2 WriteStartDocument()

Die Methode schreibt die Kopfzeile der XML-Datei.

### 1.3 WriteStartElement() & WriteEndElement()

Die Methoden begrenzen die Ausgabe eines XML-Elements.

### 1.4 WriteAttributeString()

Die Methode dient der Ausgabe eines Attributs und des zugehörigen Werts innerhalb eines XML-Elements.

### 1.5 Close()

Die Methode beendet das Schreiben der XML-Elemente und schliesst die Datei.
 
##	2 Lesen aus einer XML-Datei

### 2.1 XmlTextReader

Das Objekt der Klasse dient als »Lesegerät« zum Lesen von Daten aus einer XML-Datei.

### 2.2 Read()

Die Methode liest einen Knoten, stellt die Daten dieses Knotens zur Verfügung und wechselt zum nächsten Knoten.

### 2.3 NodeType

Die Eigenschaft beinhaltet den Typ des Knotens.

### 2.4 AttributeCount

Die Anzahl der Attribute.

### 2.5 MoveToNextAttribute()

Es ermittelt die einzelnen Attribute.

### 2.6 Close()

Die Methode beendet das Lesen der XML-Elemente und schliesst die Datei.

##	3 Schreiben von Objekten

Es sollen mehrere Objekte einer Klasse in einer XML-Datei gespeichert werden.

##	4 Lesen von Objekten

Nun sollen mehrere Objekte einer Klasse aus einer XML-Datei gelesen werden.
 
