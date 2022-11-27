# 🌵 PiantApp
<!--Hai mai voluto--> 
PiantApp è un'applicazione che consente agli utenti di condividere conoscenze e parlare di piante. Ogni utente può condividere informazioni sulle piante che ha piantato, vedere le piante dei propri amici e moltre altre funzioni

## ✨ Funzionamento
Per utilizzare il programma esegui il server e fai partire il servizio premendo il pulsante apposito. Successivamente esegui i client ed effettua il login.
Una volta aperto il client ed effettuato l'accesso verrà mostrato nella home un post; puoi mettere mi piace, commentare, visitare il profilo dell'utente che ha postato oppure passare al prossimo post. In questo modo, verrà mostrato un post per volta.
Tramite i tasti laterali si può passare alle sezioni:
  - Home
  - Pubblica post
  - Cerca utente
  - Ultimi "mi piace"
  - Logout

## ⚙️ Architettura
### ⌨️ Architettura client-server
 - Server (uno): accettare le richieste dei client e risponde con le informazioni richieste
 - Client (da uno a n): richiedere informazioni al server e visualizzarle
### 🗃️ Basi di dati
 - /json/users.json contiene gli utenti registrati
 - /json/posts.json contiene i post

## 🔎 Analisi casi d'uso 

### Utenti
| ID Utente | Nome utente        | Descrizione                                                                          |
| --------- | ------------------ | ------------------------------------------------------------------------------------ |
| U1        | Utente non loggato | Utente che non ha effettuato il login a cui viene richiesto di autenticarsi          |
| U2        | Utente loggato     | Utente che ha effettuato l'accesso e che quindi può richiedere tutte le funzionalità |
| U3        | Admin              | Utenti con privilegi superiori, per controllare/eliminare i contenuti                |

### Funzionalità
| ID Funzionalità | Nome sintetico        | Utenti interessati | Descrizione                                                                        |
| --------------- | --------------------- | ------------------ | ---------------------------------------------------------------------------------- |
| F1              | Login e registrazione | U1                 | L'utente deve inserire username e password per procedere                           |
| F2              | Visualizzare post     | U2, U3             | Nella home dell'utente, deve essere presente un post                               |
| F3              | Pubblicare contenuti  | U2                 | L'utente può essere in grado di pubblicare un post                                 |
| F4              | Cerca utenti          | U2, U3             | L'utente può cercare altri utenti per vedere i loro contenuti tramite il nickname  |
| F5              | Interagire con i post | U2, U3             | Mi piace, condividere, commentare...                                               |

## 💻 Protocollo
| ID Funzionalità | Nome sintetico        | Comando1                                   | Comando2                                               |
| --------------- | --------------------- | -----------------------------------------  | ------------------------------------------------------ |
| F1              | Login/registrazione   | ``` login nickname password$```            | ``` register surname name nickname email password$ ``` |
| F2              | Visualizzare post     | ``` post$ ```                              |                                                        |
| F3              | Pubblicare contenuti  | ``` add title author data description$ ``` |                                                        |

## 🚀 Roadmap
- [ ] F1: Login e registrazione
  - [X] F1.1: Login con username e password prefissati
  - [X] F1.2: Login con username e password scelti dall'utente
  - [X] F1.3: Registrazione
  - [X] F1.4: Controlla email valida e password con numeri e caratteri speciali
  - [X] F1.5: Controlla input vuoti nel login
  - [ ] F1.6: Controlla che il nickname e la mail sia libero
  - [ ] F1.7: Utilizzare un metodo hash per cifrare le password
  - [X] F1.8: L'utente può scegliere un'immagine preimpostata
  - [X] F1.9: Modificare le piante del proprio account (aggiungi e rimuovi)
- [ ] F2: Visualizzare post
  - [X] F2.1: Vedere un post di prova
  - [X] F2.2: Leggere tutti i post da database
  - [X] F2.3: Vedere un post random
  - [ ] F2.4: Visualizzare il post con una UI decente
  - [ ] F2.5: Le richieste possono essere effettuate solo da utenti loggati
  - [ ] F2.6: Cambiare il post restituito in base agli interessi
  - [ ] F2.7: Visualizzare i post recenti (solo frontend)
- [ ] F3: Pubblicare contenuti
  - [X] F3.1: Scrivere un post sul database (aggiornando l'elenco di post effettuati da ogni persona)
  - [X] F3.2: Controllare i dati inseriti
  - [ ] F3.3: Aggiungere un'immagine dal web
  - [ ] F3.4: Le richieste possono essere effettuate solo dal utenti loggati
- [ ] F4: Cerca utenti
  - [X] F4.1: Vedere tutti gli utenti presenti nel database
  - [X] F4.2: Cercare un utente in base al nickname
  - [X] F4.3: Visualizzare tutte le informazioni sull'utente in una form (like, piante...)
- [ ] F5: Interagire con i post
  - [ ] F5.1: Like ai post
  - [ ] F5.2: Commenti ai post
- [ ] UI:
  - [ ] Cambia il design delle finestre secondarie
  - [ ] Aggiungi dettagli piante
- [ ] Aggiunte varie
  - [ ] Visualizzare se un utente è online
  - [ ] Controlla le risposte delle richieste
  - [X] Immagini di profilo predefinite
  - [X] Data automatica quando compilo un nuovo post
  - [ ] Aggiungi img profili
- [ ] Bug
  - [X] Compaiono popup a caso, magari toglili <3
  - [X] Quando faccio login e esco senza loggare, scompare il signup
  - [X] Responsive server
  - [X] Quando finisce registrazione, chiude form
  - [X] Quando il client chiede il post si chiude la form
  - [ ] Restituire lo stesso post di fila
  - [X] Quando pubblico un post nella descrizione compare un $
  - [X] Se nel post pubblicato ci sono spazi da problemi
  - [ ] Titolo univoco

## ❤️ Credits
### Immagini
| Nome            | Autore                | Link                                                                  |
| --------------- | --------------------- | --------------------------------------------------------------------- |
| Test account    | Icons8                | https://icons8.com/icon/7Ffvtg1xmgaV/test-account                     |
| Shuttle         | Freepik               | https://www.flaticon.com/free-icon/shuttle_2285485term=start%20button&page=1&position=1&page=1&position=1&related_id=2285485&origin=tag   | 
| Plant icons	| Freepik		      | https://www.flaticon.com/free-icons/plant                                       |
| Lens            | Javis V. Pérez        | https://icon-icons.com/it/icona/ricerca-lente-di-ingrandimento/145939 |
| Plus            | Becris                | https://icon-icons.com/icon/plus-add-more-detail/82972                |  
| Next icons      | Smashicons - Flaticon | https://www.flaticon.com/free-icons/next
| Cipresso		| brgfx                 | https://www.freepik.com/free-vector/isolated-tree-white-background_29280578.htm#query=cartoon%20tree&position=20&from_view=keyword |
| Cuore verde	| rawpixel.com          | https://it.freepik.com/vettori-gratuito/illustrazione-dell-icona-medica_2606899.htm#query=green%20heart&position=21&from_view=search&track=sph |
| Plants falling  | rawpixel.com      | https://www.freepik.com/free-vector/illustration-hanging-plant-isolated-white-background_2616106.htm#query=watercolor%20plants&position=11&from_view=keyword |
| Coccinella      | jcomp             | https://www.freepik.com/free-vector/set-lady-bug-cute-bee-with-flower-cartoon-animal-element-drawing-water-color-graphic-designer-flat-design-vector-illustration_25273063.htm#query=cute%20leaves%20paint&position=5&from_view=search&track=sph |