function canBuyBeer(looksAsAge, hasId, ageFromId) {
    // Sjekker om personen kan kjøpe øl basert på ulike betingelser
    if (looksAsAge >= 25 || (hasId && ageFromId >= 18)) {
        return true; // Returnerer true hvis personen kan kjøpe øl
    } else {
        return false; // Returnerer false hvis personen ikke kan kjøpe øl
    }
}

/*

Kode visualisert på code2flow.com

start;
if (ser ut som > 25) {
    Får kjøpe øl;
} else {
    if (Ikke har legitimasjon) {
        Får IKKE kjøpe øl;
    } else if (er under 18) {
        Får IKKE kjøpe øl;
    } else {
        Får kjøpe øl;
    }
}
slutt;

start;
if (ser ut som > 25 || har legitimasjon && er over 18) {
    Får kjøpe øl;
} else {
    Får IKKE kjøpe øl;
}
slutt;

*/



Forklaring:

//Funksjonen canBuyBeer tar tre argumenter: looksAsAge (ser ut som alder), hasId (har legitimasjon), og ageFromId (alder fra legitimasjon).//
//Inne i funksjonen sjekker vi om personen kan kjøpe øl ved å vurdere to betingelser://
//Enten hvis looksAsAge er større eller lik 25, noe som ville tillate kjøp av øl uavhengig av andre faktorer.//
//Eller hvis personen har legitimasjon (hasId) og alderen fra legitimasjonen (ageFromId) er større eller lik 18.//
//Hvis en av disse betingelsene er sann, returnerer funksjonen true, noe som indikerer at personen kan kjøpe øl.//
//Hvis ingen av betingelsene er oppfylt, returnerer funksjonen false, noe som indikerer at personen ikke kan kjøpe øl.//
//De to kodeblokkene under kommentarene (/* ... */) viser alternative måter å representere den samme logikken ved hjelp av kode2flow-diagrammer. Disse diagrammene viser hvordan beslutningene tas basert på alder, legitimasjon og kjøpsmuligheter.//




