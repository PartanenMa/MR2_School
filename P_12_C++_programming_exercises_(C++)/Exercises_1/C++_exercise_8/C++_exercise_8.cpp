/*Header filet:

C++:n header-tiedostoja k‰ytet‰‰n funktioiden, luokkien
ja muuttujien ilmoittamiseen, joita voidaan k‰ytt‰‰ uudelleen
useissa l‰hdetiedostoissa. Header-tiedostojen k‰ytˆn t‰rkein etu on,
ett‰ ne tarjoavat tavan erottaa moduulin k‰yttˆliittym‰ (ilmoitus) sen
toteutuksesta (m‰‰ritelm‰), mik‰ helpottaa koodin yll‰pitoa ja v‰hent‰‰
p‰‰llekk‰ist‰ koodia.

Ero header-tiedoston ja cpp-tiedoston v‰lill‰ on se, ett‰ header-tiedosto
(tunniste .h tai .hpp) sis‰lt‰‰ vain ilmoituksia, kun taas cpp-tiedosto
(tunniste .cpp) sis‰lt‰‰ sek‰ ilmoitukset ett‰ m‰‰ritelm‰t.

Kun header-tiedosto sis‰llytet‰‰n l‰hdetiedostoon k‰ytt‰m‰ll‰ esik‰sittelyohjetta
"#include", otsikkotiedoston sis‰ltˆ liitet‰‰n l‰hdetiedostoon sis‰llytt‰miskohdassa.
T‰m‰ sallii header-tiedostossa ilmoitettujen funktioiden, luokkien ja muuttujien
k‰ytˆn l‰hdetiedostossa.

Jos header-tiedosto ja cpp-tiedosto sis‰lt‰v‰t m‰‰ritelmi‰ samalle entiteetille,
cpp-tiedoston m‰‰ritelm‰ on ensisijainen ja header-tiedoston m‰‰ritelm‰ ohitetaan.*/