# JPK-Intyg-Writer

## Intro

Det här är ett verktyg för FadderKå 2024 och framåt så att ni slipper skriva på alla intyg. Jag orkade inte lägga allt för mycket tid på det här programmet så det finns definitivt en hel del att förbättra så om du känner dig manad är det bara att clona repot och smattra på. Programmet kan bara köras på Windows.

## Hur ska datan se ut?

I och med att det är mycket i det här programmet som är hårdkodat så måste mallarna och XLSX-filerna ha en väldigt specifik struktur.

### Krav

Dessa mappar måste finnas:

* C:\TDB23\JPK Intyg Writer\
* C:\TDB23\Fadderintyg\
* C:\TDB23\HF-intyg\

Och ja, den måste heta "TDB23" trots att det är ett annat år. Som sagt, hårdkodat och jag orkar inte ändra, u do it om det är så viktigt.

### XLSX-filen med faddrarnas information

* B-kolumnen måste vara frågan om de vill ha ett fadder/HF-intyg, och svaret mmåste vara exakt "Ja", annars kommer programmet avvisa det intyget.
* C-kolumnen måste vara namnet på personen som vill ha in tyget, förnamn och efternamn.
* D-kolumnen måste vara personnumret. Formatet spelar ingen roll, då jag har täckt det flesta vid parsning fall (tror jag, som sagt inte lagt jättemycket tid på det här) men de garanterade fallen som funkar är 10/12 siffriga utan bindestreck.
* E-kolumnen måste innehålla programförkortningen (notera att E och Ei ej ska separeras och svarsalternativet ska vara "E/Ei" i formuläret).

XLSX-filen ska också ha två blad, där det första bladet ska vara svaren från huvudfaddrarna och det andra bladet ska vara svaren från faddrarna.

### Intygs-mallarna

Mallarna måste heta "mallHF.docx" eller "mallF.docx" beroende på vilken mall det är, och de måste ligga i "C:\TDB23\JPK Intyg Writer\"

När det gäller texten i mallen så måste alla ställen som byts ut av informationen i XLSX-filen följa denna struktur:

* Alla ställen som ska bytas ut mot Fadderns fullständiga namn ska i mallen ha formatet "XXFNLNXX" (utan citationstecken)
* Alla ställen som ska bytas ut mot Fadderns personnummer ska i mallen ha formatet "XXSSNXX" (utan citationstecken)
* Alla ställen som ska bytas ut mot FK:itens sektion/sektionen faddern har faddrat för ska i mallen ha formatet "XXSECXX" (utan citationstecken)
* Alla ställen som ska bytas ut mot FK:itens namn ska i mallen ha formatet "XXYNXX" (utan citationstecken)

Var i texten dessa ligger spelar ingen roll då programmet automatiskt hittar och byter ut. Det som är ett problem här är att signaturen som sätts på i slutet har en hårdkodad plats. De ligger i dagsläget på koordinaterna x = 60 och y = 720, vilket funkar för dagens mall.

### PNG-filen som är FK:itens signatur

PNG filen ska innehålla din signatur och endast din signatur. För bästa resultat ska den vara 200px bred och 80px hög (OBS: också maxvärden!). Den ska ha transparent bakgrund och ska därför vara i png-format. Ansvaret ligger på dig, garbage in garbage out.

## Hur körs programmet?

Programmet börjar genom att be dig fylla informationen:
* Ditt fullständiga namn som FK:it
* Sökväg till XLSX-filen som innehåller informationen om faddrarna.
* Sökväg till PNG-filen som innehåller din signatur.
* Dropdown meny med programmet du var FK:it
* Checkbox för om intygen är till HF eller inte.

När detta är korrekt ifyllt klickar man på "Återskapa Magi" Programmet börjar då med att läsa in all data från XLSX-Filen och spara det i minnet. Om det är iklickat att det ska vara HF-intyg så kommer programmet att kopiera HF-mallen för varje person som filtrerats av parametrarna, alltså alla HF för ex. B. Texter byts ut, signatur smackas på och de färdiga PDF-erna placeras i mappen C:\TDB23\HF-intyg\B\. Hade HF inte varit iklickad hade det varit alla faddrar för B istället och PDF-erna hade placerates i C:\TDB23\Fadderintyg\B\ istället. Rör inte några dokument förrän du ser en dialogruta där det står "Magi återskapad", som betyder att programmet är klart.

And that's it, kontakta mig vid frågor:

tomas@perezjarnil.se

Låt oss återskapa magi.

