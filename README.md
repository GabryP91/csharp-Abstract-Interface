# csharp-Abstract&Interface

  1. Creare una classe astratta che rappresenterà una figura geometrica generica con due metodi astratti: calcolaArea(); e calcolaPerimetro();
     
  2. Creare almeno tre classi, che rappresentano delle figure geometriche piane, come ad esempio il triangolo ed il cerchio, che estenderanno la classe di base. Dotare le tre classi delle variabili appropriate,
     dei costruttori e fare l’override dei due metodi in modo tale da riuscire a calcolare perimetro ed area. Istanziare almeno due oggetti per classe e stampare perimetro ed area delle figure.
     
  3. Sviluppare le seguenti classi:
     
      − Rectangle
      − Square
     
     Sviluppare, inoltre, la classe Point2D che tiene traccia della posizione nello spazio delle due figure geometriche.
     Scrivere un caso di test per testare il corretto funzionamento dei metodi sviluppati.
     
  4. Si modifichi l’esercizio 3, in modo da implementare anche le interfacce Shape e TwoDShape che contengono il metodo draw() l’una e i metodi area() e perimetro() l’altra.
     
  5. Sviluppare un programma console che permetta la gestione di StandardUser e SuperUser per un sistema di sicurezza. StandardUser e Superuser sono sottoclassi di classe astratta User.
     StandardUser e Superuser necessitano di uno username, una descrizione del profilo e una password.
     
      Implementare un sistema che permetta la creazione di una password e la modifica della stessa.
      • Le password per standardUser devono rispettare 10 caratteri di lunghezza
      • Le password per superUser devono rispettare 20 caratteri di lunghezza
      • Le password non potranno contenere caratteri vuoti
      Utilizzare un'interfaccia chiamata IControl per i metodi di controllo
     
  7. Si scriva un programma che tenga conto del guadagno degli impiegati di una fabbrica.
     Si implementino le seguenti 4 classi:
      − Employee
      − Technician
      − Laborer
      − Engineer
    
      In particolare un Laborer baserà il suo guadagno anche sul totale di ore e sul numero di pezzi
      lavorati.
    
      Testarne la corretta implementazione.
