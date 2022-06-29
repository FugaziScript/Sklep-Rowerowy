# ProjektPO

Dokumentacja


Projekt: “Hurtownia/magazyn sprzętu rowerowego”

Programowanie Obiektowe
Politechnika Śląska
Wydział Elektryczny

Przygotowali:


Kacper Czerwiński
Igor Hałas
Błażej Janus

Spis Treści
Ogólne założenia projektu
Prezentacja architektury oprogramowania
Omówienie zastosowanych technologii
Struktura obiektowa
4.1 Interfejsy
	4.1.1 IDataSource
	4.1.2 Item
4.2 Klasy
	4.2.1 Koszyk
	4.2.2 Klasy implementujące IDataSource
	4.2.3 Klasy implementujące Item
	4.2.4 Dodatkowe klasy abstrakcyjne i ich klasy potomne
Struktura danych
5.1 Podstawowe struktury
5.2 Typy wyliczeniowe

Ogólne założenia projektu

Projekt ma obejmować system zarządzania magazynem części rowerowych.
Konieczna jest realizacja następujących zadań:
	- możliwość kupna towaru przez klienta (GUI)
	- obsługa koszyka dla klienta (GUI)
	- możliwość sprzedaży całego roweru złożonego z części
	- możliwość złożenia roweru z części dostępnych w magazynie
	- obsługa dostaw towaru do magazynu
Projekt ma wykorzystywać bazę danych do przechowywania informacji o stanie magazynu. 
Dostęp do bazy danych ma być realizowany za pomocą odpowiedniej klasy. Konieczna jest kontrola nad stanem magazynu, np. klient nie powinien móc zamówić więcej towaru niż jest w magazynie.
Dla klienta sklepu przygotowany zostanie interfejs graficzny, w którego skład ma wejść:
	- Strona z kategoriami:
		- kategorie np. ramy, hamulce, opony itd.
		- sortowanie
		- dostępność produktu
	- Strona koszyka:
		- możliwość dodawania usuwania towaru
		- możliwość zmiany ilości towaru
		- możliwość kupienia towaru
		- możliwość wyczyszczenia koszyka
		- koszyk musi wyświetlać sumaryczną cenę, 
		  aktualizowaną samoczynnie po zmianie zawartości koszyka
	- Strona składania roweru:
		- możliwość dobrania ramy
		- możliwość dobrania podzespołów kompatybilnych z ramą
		- konieczność dodania wszystkich niezbędnych elementów
		- możliwość, ale nie konieczność dodania 
		 opcjonalnych elementów
	- Strona z informacjami o sklepie
Prezentacja architektury oprogramowania

Aplikacja do przechowywania danych ma wykorzystywać bazę danych.
Za komunikację z bazą danych ma być odpowiedzialna klasa DataSourceSQL, implementująca interfejs IDataSource.

Prezentacja danych klientowi ma być realizowana przy użyciu Windows Forms lub WPF.

Podstawą dla typów danych reprezentujących poszczególne części jest interfejs Item. Wszystkie ww typy danych implementują ten interfejs. 
Ze względu na taki sposób przechowywania informacji o towarze naturalnym staje się zastosowanie list generycznych list<Item>.
Rozwiązanie takie umożliwia przechowywanie i przekazywanie między poszczególnymi funkcjami informacji o elementach w spójny, prosty 
i wygodny sposób. 
W programie użyjemy wielu typów wyliczeniowych reprezentujących wartości poszczególnych parametrów właściwych podzespołów.
Omówienie zastosowanych technologii

W naszym programie wykorzystaliśmy technologie takie jak:
	- SQLite - system relacyjnych baz danych SQL
	- Windows Forms/WPF - GUI


SQLite jest stosunkowo prostą, nie wymagającą wielu zasobów implementacją silnika relacyjnej bazy danych SQL.
Biblioteka ta została napisana w języku C. 
Jest dostępna na licencji domeny publicznej.

Z uwagi na brak jednoznacznego wyboru technologii stosowanej do stworzenia GUI, informacja na temat takiej technologii zostaną dodane później.

W celu zapewnienia lepszych możliwości współpracy, umożliwienia wygodnej asynchronicznej pracy na współdzielonych zasobach wykorzystaliśmy w naszej pracy system kontroli wersji Git.
Do hostowania projektu wykorzystaliśmy platformę GitHUB.


Projekt napisany został w języku C# przy użyciu środowiska Microsoft Visual Studio 2019 Community.
