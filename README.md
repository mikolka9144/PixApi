# PixApi
Biblioteka pozwalająca na programowanie w PixBlocks w języku C#

Jak zainstalować i używać mojej biblioteki.

1. Zainstaluj program PixBlocks w wersji MSI (nie OneClick)(No chyba, że już zainstalowałeś. To wtedy nie).
2. Pobierz bibliotekę PixApi.dll z najnowszego wydania wraz z Template.zip .
3. SKOPIUJ bibliotekę PixApi.dll do katalogu C:\Program Files (x86)\PixBlocks.
4. Wypakuj plik zip, który wcześniej pobrałeś.
5. Skopiuj gdzieś pliki PixBlocks.exe, PixBlocks.Server.DataModels.dll i PixBlocks.ServerFasade.dll z katalogu C:\Program Files (x86)\PixBlocks.
6. Otwórz projekt z pliku zip za pomocą Visual Studio 2019 (Zainstaluj go, jeżeli go niemasz. Jednak pamiętaj o zaznaczeniu pakietu "Programowanie aplikacji klasycznych dla platformy .NET")
7. kliknij PPM na tekst "Zależności" i wybierz z listy opcję "Dodaj odwołanie do projektu...".(Szukaj tego napisu po prawej stronie okna programu.).
8. W oknie, które się pojawiło klinij "Przeglądaj" i przycisk "Przeglądaj" na dolnym pasku.
9. Teraz w tym oknie znajdź i zaznacz następujące pliki: kopie PixBlocks.exe, PixBlocks.Server.DataModels.dll i PixBlocks.ServerFasade.dll oraz PixApi.dll i zatwierdź zmiany przyciskiem OK.
10. Przejdź do pliku Code.cs i kod swój pisz w metodzie YourCodeHere.

Jak uruchomić skompilowany kod.
1. Pobierz plik tekstowy "code for PixBlocks.txt" z najnowszego wydania i skopiuj całą zawartość.
2. Uruchom Pixblocks i otwórz w nim edytor python (są one w zakładce "Moja twórczość\Python").
3. Wklej skopiowany kod.
4. Znajdź skompilowaną bibliotekę (Powinna być w Template(Katalog projektu)\bin\Debug\netstandard2.0\Template.dll)
5. kliknij ją PPM trzymając Shift i wybierz opcję "Kopiuj jako ścieżkę".
6. podmień tekst TEMPLATE na ścieżkę, którą skopiowałeś (Pamieta o zamienieniu znaku \ na \\).
7. Uruchom.
