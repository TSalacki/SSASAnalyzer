# SSASAnalyzer

1. Zadanie:
   - Zadaniem przygotowywanej aplikacji jest umożliwienie użytkownikowi nawiązywania połączenia z wielowymiarową lub tabelaryczną bazą danych, przygotowywanie planu zapytań, wykonania go, dokonania pomiarów czasowych i zaprezentowania wyników w czytelny sposób. Ze względu na potencjalną pracę z użytkownikami nieprzyzwyczajonymi do pracy z aplikacjami konsolowymi, aplikacja posiada czytelny i przejrzysty interfejs graficzny.
2. Wykorzystane biblioteki i frameworki:
   - Windows Forms
   - AMO
   - ADOMD.NET
   - Json.NET
3. Główne okno
![Image of Main Window](https://i.imgur.com/0u9UBrh.png)
   - Connections: odpowiada za rozłączanie się oraz za nawiązywanie połączenia z
modelem wielowymiarowym lub tabelarycznym
   - Cache: odpowiada za ustawienia dotyczące cachowania po stronie serwera – czy po
każdym zapytaniu cache ma być czyszczony oraz daje możliwość wysłania żądania z
wyczyszczeniem w danym momencie
   - Chart: odpowiada za wyświetlenie okna z analizą wyników dla obecnie znajdujących
się w pamięci pomiarów oraz umożliwia ich wyczyszczenie
   - QueryPlan: odpowiada za zapisanie obecnego planu zapytań do pliku lub wczytanie
takowego z pliku.
4. Okno analiz
![Image of Analysis](https://i.imgur.com/9lNuxzr.png)
