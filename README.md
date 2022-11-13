# 🌵 PiantApp
<!--Hai mai voluto--> 
PiantApp è un'applicazione che consente agli utenti di condividere conoscenze e parlare di piante. Ogni utente può condividere informazioni sulle piante che ha piantato, vedere le piante dei propri amici e moltre altre funzioni

## 👷🏻‍♂️ Utilizzo
Per utilizzare il programma esegui il server e fai partire il servizio premendo il pulsante apposito. Successivamente esegui i client ed effettua il login

## ✨ Funzionamento
Una volta aperta l'app ed effettuato l'accesso, verrà mostrato nella home uno dei nuovi post; puoi mettere mi piace, commentare, visitare il profilo dell'utente che ha postato, oppure passare al prossimo post. In questo modo, verrà mostrato un post per volta.
Tramite i tasti laterali si può passare alle sezioni:
  - Home
  - Cerca utente
  - Ultimi "mi piace"

## ⚙️ Architettura
L'architettura è client-server
* Server (uno): accettare le richieste dei client e risponde con le informazioni richieste
* Client (da uno a n): richiedere informazioni al server

## 🔎 Analisi casi d'uso 

### Utenti
| ID Utente | Nome utente        | Descrizione                                                                          |
| --------- | ------------------ | ---------------------------------------------------------------------------          |
| U1        | Utente non loggato | Utente che non ha effettuato il login a cui viene richiesto di autenticarsi          |
| U2        | Utente loggato     | Utente che ha effettuato l'accesso e che quindi può richiedere tutte le funzionalità |
| U3        | Admin              | Utenti con privilegi superiori, per controllare i contenuti                          |

### Funzionalità
| ID Funzionalità | Nome sintetico        | Utenti interessati | Descrizione                                                                       |
| --------------- | --------------------- | ------------------ | --------------------------------------------------------------------------------- |
| F1              | Login                 | U1                 | L'utente deve inserire username e password per procedere                          |
| F2              | Visualizzare post     | U2, U3             | Nella home dell'utente, deve essere presente un post                              |
| F3              | Cerca utenti          | U2, U3             | L'utente può cercare altri utenti per vedere i loro contenuti tramite il nickname |
| F4              | Pubblicare contenuti  | U2                 | Coming soon...                                                                    |
| F5              | Interagire con i post | U2, U3             | Mi piace, condividere, commentare...                                              |

## 🚀 Roadmap
- [X] F1: Login e registrazione
  - [X] F1.1: Login con username e password prefissati
  - [X] F1.2: Login con username e password scelti dall'utente
  - [X] F1.3: Registrazione
  - [X] F1.4 Controlla email valida e password con numeri e caratteri speciali
  - [X] F1.5 Controlla input vuoti nel login
  - [ ] F1.6 Controlla che il nickname e la mail sia libero
- [ ] F2: Visualizzare post
  - [X] F2.1: Vedere un post di prova
  - [X] F2.2: Leggere tutti i post da database
  - [ ] F2.3: Vedere un post random
  - [ ] F2.4: Visualizzare il post con una UI decente
  - [ ] F2.5: Le richieste possono essere effettuate solo da utenti loggati
  - [ ] F2.6: Cambiare il post restituito in base agli interessi
  - [ ] F2.7: 
- [ ] F3: Cerca utenti
- [ ] F4: Pubblicare contenuti
- [ ] F5: Interagire con i post
- [ ] Aggiunte varie
  - [ ] Visualizzare se un utente è online
- [ ] Bug
  - [X] Compaiono popup a caso, magari toglili <3
  - [X] Quando faccio login e esco senza loggare, scompare il signup
  - [X] Responsive server
  - [X] Quando finisce registrazione, chiude form

## ❤️ Credits
### Immagini
| Nome            | Autore          | Link                                              |
| --------------- | --------------- | ------------------------------------------------- |
| Test account    | Icons8          | https://icons8.com/icon/7Ffvtg1xmgaV/test-account |
| Shuttle         | Freepik         | https://www.flaticon.com/free-icon/shuttle_2285485term=start%20button&page=1&position=1&page=1&position=1&related_id=2285485&origin=tag | 
| Plant icons	| Freepik		| https://www.flaticon.com/free-icons/plant
