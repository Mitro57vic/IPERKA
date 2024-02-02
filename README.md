# IPERKA

`Mitrovic`

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

✍️ Ihr Gruppenname und Ihre Nachnamen

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1  |    Kann         |   Qualität   | Als ein User möchte ich eine Belohnung bei first try richtigen antworten erhalten, damit ich mehr motivation zum Spielen habe. |
| 2  |        kann        |  Qualität    | Als ein User möchte ich das mir angezeigt wird ob meine geratene Zahl zu gross oder zu klein ist. |
| 3  |            Kann     |  Qualität  | Als ein User möchte ich bei falschen Antworten eine kleine Hilfe bekommen, damit ich schneller zu einer Lösung kommen kann. |
| 4  |        Muss        |      | Als ein User möchte ich eine klare Fragestellung haben, damit ich keine unklarheiten habe.                                   |
|  5    |      Kann  |     Qualität   | Als ein User möchte ich einen Limit von versuchen haben, damit ich herausgefordert bin.         |
|6|Muss|Funktional|Als ein USer möchte ich wissen ob meine geratene ZAhl korrekt ist damit ich weiss ob ich das Spiel gewonnen habe|

✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |     Programm starten         |   eine Zahl      |     Wenn die Zahl beim ersten Versuch richtig ist bekommt man eine kleine Belohnung           |
| 1.2 |     Programm starten         |  Falsche Versuche       |     Wenn die geratene Zahl falsch ist soll es im Programm ausgegeben werden ob die geheime Zahl grösser oder kleiner als seine  geratene Zahl ist .              |
|1.3|Die richtige Zahl wurde eingegeben und das Programm soll fragen ob er ein neues Spiel spielen möchte|Ja, ich möchte ein neues Spiel spielen|Wenn der USer ein neues Spiel spielen möchte wird im Programm ein Random Generator ausgeführt und ausgegeben.|
|1.4|Die richtige Zahl wurde eingegeben und das Programm soll fragen ob er ein neues Spiel spielen möchte|Nein ich möchte kein neues Spie spielen|Programm wird beendet|
|1.5|Programm fragt nach nochmal ein neues Spiel|Ja|Eine Zahl zwischen 1-120 soll solange vom User geraten werden bis  die geheime Zahl richtig erraten worden ist|
|1.6|Programm fragt nach nochmal ein neues Spiel|Nein|Programm soll beendet werden|

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.


![Github](https://user-images.githubusercontent.com/110892641/186121092-8e8044b6-6a6c-43c0-98f1-4aac9b66c830.png)




## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  30.08     |    Filip Mitrovic       |     Das Programm soll nach jeder falschen Eingabe eine neue Chance kriegen sie richtig zu erraten.         |  30-45 Minuten|
| 2.A |    06.09   |     Filip Mitrovic      |      Das Programm soll Hinweise zu falsch geratenen Zahlen ausgeben.        |    30 Minuten           |
|3.A|06.09|Filip Mitrovic|Das Programm soll mich fragen ob ich ein neues Spiel spielen möchte.|30 Minuten|
|4.A|06.09|Filip Mitrovic|Das Programm soll klar für mich sein was ich zu tun habe.|30 Minuten|
|5.A|06.09|Filip Mitrovic|Das Programm soll den User solang spielen lassen so oft er möchte |30-45 Minuten|
|6.A|06.09.2022|Filip Mitrovic|Das Programm soll eine Random Zahl ausgeben|30-45 Minuten|
|7.A|06.09.2022|Filip Mitrovic|Das Programm soll ein zweites Spiel vorschlagen zu spielen|30-45 Minuten|
Total: 7 Arbeitspakete = 3 Stunden -> Ich habe  um die 3-4 h gebraucht

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| Programmieren | 30.08.2022      |           | 80 Min              |    120 Min               |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.A  |   30.08.2022    |    Das Programm gibt dem User die Möglichkeit eine neue Eingabe enzugeben      |    Filip Mitrovic  |
| 2.A  |   06.09.2022    |     Das Programm gibt dem User Hinweise zu seiner geratenen Zahl umd bei seiner neuen Eingabe einfacher die Zahl zu erraten      |   Filip Mitrovic |
|3.A|06.09.2022|Das Programm fragt den USer ob er ein neues Spiel spielen möchte oder wieder das gleiche Spiel spielen möchte|Filip Mitrovic|
|4.A|06.09.2022|Das Programm ist für den User verständlich und es hat keine unklarheiten|Filip Mitrovic|
|5.A|06.09.2022|Das Programm lässt den User das Spiel solange spielen solang er möchte|Filip Mitrovic|
|6.A|06.09.2022|Das Programm gibt eine Random Zahl aus|Filip Mitrovic |
|7.A|06.09.2022|Das Programm schlägt ein zweites Spiel dem USer vor|Filip Mitrovic|

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    | Programm gestartet (Filip Kritzner) | $ | Programm gibt Fehler aus  | Programm ist abgestürzt |
| II | Programm gestartet (Filip Kritzner) | 23 | Es wird ausgegeben, ob die Zahl zu gross oder zu klein ist | Programm wird beendet |                      |
| III| Erste Zahl erraten und nochmal ein Spiel gestartet (Filip Kritzner) | 3 | Programm fragt, ob ich noch ein Spiel spielen will | "Geben Sie eine Zahl zwischen 1-120 ein um unsere geheime Zahl zu erraten" |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.
kdjfkjdfkojfkdshghhjghjjhhjhjghjjhjhghghjghjghghjghkjghhjghjuhuhjbhnbnnjbnnbb
## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
