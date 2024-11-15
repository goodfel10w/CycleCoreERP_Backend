# Bill of Materials (BOM) Entry und Component

## 1. BOM Entry (Stücklisteneintrag)

Ein **BOM Entry** repräsentiert eine spezifische Position in der Stückliste eines Produkts. Die Stückliste (BOM) ist eine strukturierte Liste aller Materialien, Komponenten und Unterbaugruppen, die zur Herstellung eines Endprodukts benötigt werden.

### Beispiel:
Stell dir vor, du hast ein Produkt „Kinderfahrrad“. Die Stückliste dafür könnte so aussehen:

- **Rahmen** (1x)
- **Vorderrad** (1x)
- **Hinterrad** (1x)
- **Pedale** (2x)
- **Sattel** (1x)

Jeder dieser Posten wird als ein **BOM Entry** dargestellt, der angibt, welche Komponente benötigt wird und in welcher Menge.

### Struktur eines BOM Entry:
- **BOMEntryId**: Eindeutige Identifikationsnummer des Eintrags
- **ProductId**: Referenz auf das Produkt (z.B. Kinderfahrrad)
- **ComponentId**: Referenz auf die Komponente (z.B. Rahmen, Vorderrad)
- **Quantity**: Menge der benötigten Komponente (z.B. 1x, 2x)

#### Beispiel-BOM Entry:
```json
{
  "BOMEntryId": 1,
  "ProductId": 101,
  "ComponentId": 201,
  "Quantity": 1
}
```
## 2. Component (Komponente)

Eine **Component** ist ein individuelles Bauteil, das in der Produktion verwendet wird. Diese können entweder Eigenfertigungsprodukte oder Kaufteile sein:

- **Eigenfertigungsprodukte**: Teile, die intern im Unternehmen hergestellt werden (z.B. ein spezieller Fahrradrahmen).
- **Kaufteile**: Komponenten, die von externen Lieferanten zugekauft werden (z.B. Schrauben, Sättel).

### Attribute einer Component:
- **Name**: Der Name der Komponente (z.B. „Vorderrad“, „Rahmen“).
- **IsInHouseManufactured**: Ein boolescher Wert, der anzeigt, ob die Komponente intern gefertigt wird oder zugekauft ist.
- **Cost**: Die Kosten der Komponente, was in der Kalkulation der Produktionskosten wichtig ist.

#### Beispiel einer Component:
```json
{
  "ComponentId": 201,
  "Name": "Rahmen",
  "IsInHouseManufactured": true,
  "Cost": 50.00
}
```

## 3. Beziehung zwischen BOM Entry und Component

Ein **BOM Entry** referenziert eine **Component**, um anzugeben, welche Teile für die Herstellung eines Produkts benötigt werden. Dies ermöglicht:

- **Flexible Definition von Stücklisten**: Jedes Produkt kann seine eigene Stückliste haben, die aus verschiedenen BOM Entries besteht.
- **Verfolgbarkeit und Übersicht**: Man kann nachvollziehen, welche Komponenten für ein Produkt verwendet werden und wie viele davon benötigt werden.

### Praktisches Beispiel:
Ein **BOM Entry** für ein Kinderfahrrad könnte so aussehen:

```json
{
  "BOMEntryId": 1,
  "ProductId": 101,
  "ComponentId": 201,
  "Quantity": 1
}
```

Die referenzierte Component könnte wie folgt aussehen:

```json
{
"ComponentId": 201,
"Name": "Rahmen",
"IsInHouseManufactured": true,
"Cost": 50.00
}
```