/*
    1. Creare una classe astratta che rappresenterà una figura geometrica generica con due metodi astratti: calcolaArea(); e calcolaPerimetro();

    2. Creare almeno tre classi, che rappresentano delle figure geometriche piane, come ad esempio il  triangolo ed il cerchio, che estenderanno la classe di base. 
       Dotare le tre classi delle variabili appropriate, dei costruttori e fare l’override dei due metodi in modo tale da riuscire a calcolare
       perimetro ed area. Istanziare almeno due oggetti per classe e stampare perimetro ed area delle figure.

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

    6. Si scriva un programma che tenga conto del guadagno degli impiegati di una fabbrica.
       Si implementino le seguenti 4 classi:
        − Employee
        − Technician
        − Laborer
        − Engineer

        In particolare un Laborer baserà il suo guadagno anche sul totale di ore e sul numero di pezzi lavorati.

        Testarne la corretta implementazione. 
*/

namespace csharp_Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;

            while (true) // Loop infinito fino a scelta di uscita
            {
                Console.WriteLine("\n---------------------------------------------------\n");
                Console.WriteLine("Seleziona un esercizio da 1 a 4 oppure digita 0 per uscire:");

                Console.WriteLine("Caso [1]: Creazione istanza classi CERCHIO-ROMBO-TRAPEZIO");
                Console.WriteLine("Caso [2]: Creazione istanza classi RETTANGOLO-QUADRATO-DISEGNO PUNTI");
                Console.WriteLine("Caso [3]: Creazione istanza classi Standard&Super User");
                Console.WriteLine("Caso [4]: Creazione istanza classi Employee/Technician/Laborer/Engineer");
              


                Console.WriteLine("\nFai la tua scelta\n");

                // Controllo input utente
                while (!int.TryParse(Console.ReadLine(), out scelta))
                {
                    Console.WriteLine("Sintassi errata. Inserisci un numero intero positivo:");
                }

                if (scelta == 0)
                {
                    Console.WriteLine("Uscita dal programma...");
                    break; // Esce dal loop e termina il programma
                }

                Console.WriteLine("\n---------------------------------------------------\n");

                switch (scelta)
                {

                    case 1:
                        Console.WriteLine("ESERCIZIO 1\n");

                        //Creazione oggetti
                        Rombo rombo = new Rombo(4, 6, 5);
                        Cerchio cerchio = new Cerchio(5);
                        Cerchio cerchio2 = new Cerchio(3.5);
                        Trapezio trapezio = new Trapezio(3, 5, 4, 6, 7);
                        Trapezio trapezio2 = new Trapezio(2.8, 7.1, 6.9, 8.2, 3.7);

                        //Stampa a video
                        Console.WriteLine("Rombo: " + rombo);
                        Console.WriteLine("Cerchio: " + cerchio);
                        Console.WriteLine("Cerchio2: " + cerchio2);
                        Console.WriteLine("Trapezio: " + trapezio);
                        Console.WriteLine("Trapezio2: " + trapezio2);

                        Console.WriteLine("\nCalcolo Area e Perimetro Rombo\n" +"--------------------------------\n");

                        rombo.calcolaArea();
                        rombo.calcolaPerimetro();

                        Console.WriteLine("\nCalcolo Area e Perimetro Cerchio 1\n" +"--------------------------------\n");
                        cerchio.calcolaArea();
                        cerchio.calcolaPerimetro();

                        Console.WriteLine("\nCalcolo Area e Perimetro Cerchio 2\n" +"--------------------------------\n");
                        cerchio2.calcolaArea();
                        cerchio2.calcolaPerimetro();

                        Console.WriteLine("\nCalcolo Area e Perimetro Trapezio 1\n" +"--------------------------------\n");
                        trapezio.calcolaArea();
                        trapezio.calcolaPerimetro();

                        Console.WriteLine("\nCalcolo Area e Perimetro Trapezio 2\n" +"--------------------------------\n");
                        trapezio2.calcolaArea();
                        trapezio2.calcolaPerimetro();

                        break;
                    case 2:
                        Console.WriteLine("ESERCIZIO 2\n");

                        //Creazione oggetti

                        Rettangolo rettangolo = new Rettangolo(5, 8);

                        Point2D posizioneQuadrato = new Point2D(3, 5);
                        Quadrato quadrato = new Quadrato(6, posizioneQuadrato);


                        //Stampa a video

                        Console.WriteLine("Rettangolo: " + rettangolo);

                        Console.WriteLine("Quadrato: " + quadrato);

                        Console.WriteLine("\nCalcolo Area e Perimetro Rettangolo\n" +"--------------------------------\n");

                        rettangolo.calcolaArea();
                        rettangolo.calcolaPerimetro();

                        Console.WriteLine("\nCalcolo Area e Perimetro Quadrato\n" +"--------------------------------\n");

                        quadrato.calcolaArea();
                        quadrato.calcolaPerimetro();

                        Console.WriteLine("\nDisegno Rettangolo\n" +"--------------------------------\n");

                        rettangolo.draw();
                        Console.WriteLine("\nDisegno Quadrato\n" +"--------------------------------\n");

                        quadrato.draw();
                        Console.WriteLine("\nDisegno Punto 2D\n" +"--------------------------------\n");

                        Point2D point2D = new Point2D(3, 5);
                        point2D.draw();
                        Console.WriteLine("\nDisegno Punto 2D\n" +"--------------------------------\n");
                        point2D.draw();

                        break;
                    case 3:
                        Console.WriteLine("ESERCIZIO 3\n");

                        // Creazione oggetto StandardUser
                        StandardUser standardUser = new StandardUser("Luca6", "Utente standard Con credenziali(L3)", "1234567890");
                        Console.WriteLine("\nCreazione StandardUser\n" +"--------------------------------\n");

                        Console.WriteLine(standardUser);
                        Console.WriteLine($"\nCreazione Password {standardUser.Username}\n" +"--------------------------------\n");

                        standardUser.createPassword();
                        Console.WriteLine(standardUser);

                        Console.WriteLine($"\nModifica Password {standardUser.Username}\n" + "--------------------------------\n");

                        standardUser.changePassword();
                        Console.WriteLine(standardUser);

                        // Creazione oggetto SuperUser
                        SuperUser superUser = new SuperUser("Mario8", "Utente Admin Con credenziali(L1)", "2d569y78poaz3hkl980p");
                        Console.WriteLine("\nCreazione SuperUser\n" +"--------------------------------\n");

                        
                        Console.WriteLine(superUser);
                        Console.WriteLine($"\nCreazione Password {superUser.Username}\n" + "--------------------------------\n");

                        superUser.createPassword();
                        Console.WriteLine(superUser);

                        Console.WriteLine($"\nModifica Password {superUser.Username}\n" + "--------------------------------\n");

                        superUser.changePassword();
                        Console.WriteLine(superUser);
                      
                        break;
                    case 4:
                        Console.WriteLine("ESERCIZIO 4\n");

                        // Creazione oggetti
                        Technician tecnico = new Technician("Mario", "Rossi", 1800, 325, 40);
                        Laborer operaio = new Laborer("Luigi", "Verdi", 1100, 120, 200, 15, 2);
                        Engineer ingegnere = new Engineer("Anna", "Bianchi", 3000, 1000);

                        // Stampa a video
                        Console.WriteLine("Tecnico: " + tecnico);
                        Console.WriteLine("Operaio: " + operaio);
                        Console.WriteLine("Ingegnere: " + ingegnere);

                        break;
                   
                }

            }
        }
    }

    /*
         1. Creare una classe astratta che rappresenterà una figura geometrica generica con due metodi astratti: calcolaArea(); e calcolaPerimetro();

         2. Creare almeno tre classi, che rappresentano delle figure geometriche piane, come ad esempio il  triangolo ed il cerchio, che estenderanno la classe di base. 
            Dotare le tre classi delle variabili appropriate, dei costruttori e fare l’override dei due metodi in modo tale da riuscire a calcolare
            perimetro ed area. Istanziare almeno due oggetti per classe e stampare perimetro ed area delle figure. 
     
    */

    public abstract class FiguraGeometrica
    {
        public abstract void calcolaArea();

        public abstract void calcolaPerimetro();
    }

    public class Rombo : FiguraGeometrica
    {
        //attributi
        private double diagonaleMinore;
        private double diagonaleMaggiore;
        private double lato;

        //Get e Set
        public double DiagonaleMinore { get; set; }
        public double DiagonaleMaggiore { get; set; }
        public double Lato { get; set; }

        //Costruttore vuoto
        public Rombo()
        {
        }
        //Costruttore parametrizzato
        public Rombo(double diagonaleMinore, double diagonaleMaggiore, double lato)
        {
            DiagonaleMinore = diagonaleMinore;
            DiagonaleMaggiore = diagonaleMaggiore;
            Lato = lato;
        }
        //Metodo per calcolare l'area del rombo 
        public override void calcolaArea()
        {
            //formula per calcolare l'area del rombo
            double area = (DiagonaleMinore * DiagonaleMaggiore) / 2;

            //stampa a video risultato
            Console.WriteLine($"L'area del rombo è => [DiagonaleMaggiore({DiagonaleMaggiore})*DiagonaleMinore({DiagonaleMinore})/2] : {area}");
        }
        public override void calcolaPerimetro()
        {
            //formula per calcolare il perimetro del rombo
            double perimetro = 4 * Lato;

            //stampa a video risultato
            Console.WriteLine($"Il perimetro del rombo è => [4*lato({Lato})] : {perimetro}");
        }

        //Override del metodo ToString
        public override string ToString()
        {
            return $"Diagonale minore: {DiagonaleMinore}, Diagonale maggiore: {DiagonaleMaggiore}, Lato: {Lato}";
        }
    }

    public class Cerchio : FiguraGeometrica
    {
        //attributi
        private double raggio;
        //Get e Set
        public double Raggio { get; set; }
        //Costruttore vuoto
        public Cerchio()
        {
        }
        //Costruttore parametrizzato
        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }
        //Metodo per calcolare l'area del cerchio
        public override void calcolaArea()
        {
            //formula per calcolare l'area del cerchio 
            double area = Math.PI * Math.Pow(Raggio, 2);
            //stampa a video risultato
            Console.WriteLine($"L'area del cerchio è => [π({Math.PI})*raggio^2({Math.Pow(Raggio, 2)})] : {area}");
        }
        public override void calcolaPerimetro()
        {
            //formula per calcolare il perimetro del cerchio
            double perimetro = 2 * Math.PI * Raggio;
            //stampa a video risultato
            Console.WriteLine($"Il perimetro del cerchio è => [2*π({Math.PI})*raggio({Raggio})] : {perimetro}");
        }
        //Override del metodo ToString
        public override string ToString()
        {
            return $"Raggio: {Raggio}";
        }
    }

    public class Trapezio : FiguraGeometrica
    {
        //attributi
        private double baseMinore;
        private double baseMaggiore;
        private double altezza;
        private double lato1;
        private double lato2;
        //Get e Set
        public double BaseMinore { get; set; }
        public double BaseMaggiore { get; set; }
        public double Altezza { get; set; }
        public double Lato1 { get; set; }
        public double Lato2 { get; set; }

        //Costruttore vuoto
        public Trapezio()
        {
        }

        //Costruttore parametrizzato
        public Trapezio(double baseMinore, double baseMaggiore, double altezza, double lato1, double lato2)
        {
            BaseMinore = baseMinore;
            BaseMaggiore = baseMaggiore;
            Altezza = altezza;
            Lato1 = lato1;
            Lato2 = lato2;
        }

        //Metodo per calcolare l'area del trapezio
        public override void calcolaArea()
        {
            //formula per calcolare l'area del trapezio
            double area = ((BaseMinore + BaseMaggiore) * Altezza) / 2;
            //stampa a video risultato
            Console.WriteLine($"L'area del trapezio è => [((BaseMinore({BaseMinore}) + BaseMaggiore({BaseMaggiore}))*altezza{Altezza})/2] : {area}");
        }
        public override void calcolaPerimetro()
        {
            //formula per calcolare il perimetro del trapezio
            double perimetro = BaseMinore + BaseMaggiore + Lato1 + Lato2;
            //stampa a video risultato
            Console.WriteLine($"Il perimetro del trapezio è => [BaseMinore({BaseMinore}) + BaseMaggiore({BaseMaggiore}) + Lato1({Lato1}) + Lato2({Lato2})] : {perimetro}");
        }

        //Override del metodo ToString
        public override string ToString()
        {
            return $"Base minore: {BaseMinore}, Base maggiore: {BaseMaggiore}, Altezza: {Altezza}, Lato 1: {Lato1}, Lato 2: {Lato2}";
        }
    }

    /*
        3. Sviluppare le seguenti classi:

        − Rectangle
        − Square

        Sviluppare, inoltre, la classe Point2D che tiene traccia della posizione nello spazio delle due figure geometriche.
        Scrivere un caso di test per testare il corretto funzionamento dei metodi sviluppati.

        4. Si modifichi l’esercizio 3, in modo da implementare anche le interfacce Shape e TwoDShape che contengono il metodo draw() l’una e i metodi area() e perimetro() l’altra.
 

    */
    public interface Shape
    {
        void draw();
    }

    public interface TwoDShape
    {
        double area();
        double perimetro();
    }

    public class Rettangolo : FiguraGeometrica, Shape, TwoDShape
    {
        // Attributi
        private double lunghezza;
        private double larghezza;

        // Get e Set
        public double Lunghezza { get; set; }
        public double Larghezza { get; set; }

        // Costruttore vuoto
        public Rettangolo()
        {
        }

        // Costruttore parametrizzato
        public Rettangolo(double lunghezza, double larghezza)
        {
            Lunghezza = lunghezza;
            Larghezza = larghezza;
        }

        // Metodo per calcolare l'area del rettangolo che implementa il metodo astratto calcolaArea() della classe FiguraGeometrica e richiama il metodo area() dell'interfaccia TwoDShape
        public override void calcolaArea()
        {
            double areaValue = area();
            Console.WriteLine($"L'area del rettangolo è => [Lunghezza({Lunghezza}) * Larghezza({Larghezza})] : {areaValue}");
        }

        // Metodo per calcolare il perimetro del rettangolo che implementa il metodo astratto calcolaPerimetro() della classe FiguraGeometrica e richiama il metodo perimetro() dell'interfaccia TwoDShape
        public override void calcolaPerimetro()
        {
            double perimetroValue = perimetro();
            Console.WriteLine($"Il perimetro del rettangolo è => [2 * (Lunghezza({Lunghezza}) + Larghezza({Larghezza}))] : {perimetroValue}");
        }

        // Implementazione del metodo area() dell'interfaccia TwoDShape
        public double area()
        {
            return Lunghezza * Larghezza;
        }

        // Implementazione del metodo perimetro() dell'interfaccia TwoDShape
        public double perimetro()
        {
            return 2 * (Lunghezza + Larghezza);
        }

        // Implementazione del metodo draw() dell'interfaccia Shape
        public void draw()
        {
            Console.WriteLine("Disegna un rettangolo");
            Console.WriteLine("*******************");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*******************");
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"Lunghezza: {Lunghezza}, Larghezza: {Larghezza}";
        }
    }

    public class Quadrato : FiguraGeometrica, Shape, TwoDShape
    {
        // Attributi
        private double lato;
        private Point2D posizione;

        // Get e Set
        public double Lato { get; set; }
        public Point2D Posizione { get; set; }

        // Costruttore vuoto
        public Quadrato()
        {
        }

        // Costruttore parametrizzato
        public Quadrato(double lato, Point2D posizione)
        {
            Lato = lato;
            Posizione = posizione;
        }

        // Metodo per calcolare l'area del quadrato che implementa il metodo astratto calcolaArea() della classe FiguraGeometrica e richiama il metodo area() dell'interfaccia TwoDShape
        public override void calcolaArea()
        {
            double areaValue = area();
            Console.WriteLine($"L'area del quadrato è => [Lato^2({Math.Pow(Lato, 2)})] : {areaValue}");
        }

        // Metodo per calcolare il perimetro del quadrato che implementa il metodo astratto calcolaPerimetro() della classe FiguraGeometrica e richiama il metodo perimetro() dell'interfaccia TwoDShape
        public override void calcolaPerimetro()
        {
            double perimetroValue = perimetro();
            Console.WriteLine($"Il perimetro del quadrato è => [4 * Lato({Lato})] : {perimetroValue}");
        }

        // Implementazione del metodo area() dell'interfaccia TwoDShape
        public double area()
        {
            return Math.Pow(Lato, 2);
        }

        // Implementazione del metodo perimetro() dell'interfaccia TwoDShape
        public double perimetro()
        {
            return 4 * Lato;
        }

        // Implementazione del metodo draw() dell'interfaccia Shape
        public void draw()
        {
            Console.WriteLine($"\nDisegna un quadrato alle coordinate ({Posizione.X}, {Posizione.Y})\n");
            Console.WriteLine("*******************");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*                 *");
            Console.WriteLine("*******************");
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"Lato: {Lato}, Posizione: ({Posizione.X}, {Posizione.Y})";
        }
    }

    public class Point2D : Shape
    {
        // Attributi
        private double x;
        private double y;

        // Get e Set
        public double X { get; set; }
        public double Y { get; set; }

        // Costruttore vuoto
        public Point2D()
        {
        }

        // Costruttore parametrizzato
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Implementazione del metodo draw() dell'interfaccia Shape
        public void draw()
        {
            Console.WriteLine($"Disegna un punto alle coordinate ({X}, {Y})");
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }
    }

    /*
        5. Sviluppare un programma console che permetta la gestione di StandardUser e SuperUser per un sistema di sicurezza.
           StandardUser e Superuser sono sottoclassi di classe astratta User.
           StandardUser e Superuser necessitano di uno username, una descrizione del profilo e una password.
           Implementare un sistema che permetta la creazione di una password e la modifica della stessa.
            • Le password per standardUser devono rispettare 10 caratteri di lunghezza
            • Le password per superUser devono rispettare 20 caratteri di lunghezza
            • Le password non potranno contenere caratteri vuoti

            Utilizzare un'interfaccia chiamata IControl per i metodi di controllo 
     
    */

    public interface IControl
    {
        void createPassword();
        void changePassword();
    }

    public abstract class User: IControl
    {
        // Attributi
        private string username;
        private string profileDescription;
        private string password;
        // Get e Set
        public string Username { get; set; }
        public string ProfileDescription { get; set; }
        public string Password { get; set; }
        // Costruttore vuoto
        public User()
        {
        }
        // Costruttore parametrizzato
        public User(string username, string profileDescription, string password)
        {
            Username = username;
            ProfileDescription = profileDescription;
            Password = password;
        }

        public void createPassword() { Console.WriteLine("Questo è il metodo della classe astratta User per la creazione della pw"); }
        public void changePassword() { Console.WriteLine("Questo è il metodo della classe astratta User per la modifica della pw"); }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"Username: {Username}, Profile Description: {ProfileDescription}, Password: {Password}";
        }
    }

    public class SuperUser : User, IControl
    {
        // Costruttore vuoto
        public SuperUser() { }

        // Costruttore parametrizzato
        public SuperUser(string username, string profileDescription, string password)
            : base(username, profileDescription, password) { }

        // Metodo per creare una password 
        public void createPassword()
        {
            // Inserimento password
            Console.WriteLine("Inserisci la password per il SuperUser ( >= 20 caratteri):");
            string password = Console.ReadLine();

            // Controllo lunghezza password che non sia nulla, vuota o composta solo da spazi bianchi
            if (password.Length >= 20 && !string.IsNullOrWhiteSpace(password))
            {
                // Assegnazione password
                Password = password;
                Console.WriteLine($"Password creata con successo: nuova pw => {password}\n");
            }
            else
            {
                Console.WriteLine("La password deve contenere 20 caratteri!\n");
            }
        }

        // Metodo per modificare la password
        public void changePassword()
        {
            // Inserimento nuova password
            Console.WriteLine("Inserisci la nuova password per il SuperUser ( >= 20 caratteri):");
            string newPassword = Console.ReadLine();

            // Controllo lunghezza password che non sia nulla, vuota o composta solo da spazi bianchi
            if (newPassword.Length >= 20 && !string.IsNullOrWhiteSpace(newPassword))
            {
                // Assegnazione nuova password
                Password = newPassword;
                Console.WriteLine($"Password modificata con successo! nuova pw => {newPassword}\n");
            }
            else
            {
                Console.WriteLine("La password deve contenere 20 caratteri!\n");
            }
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"SuperUsername: {Username}, Descrizione: {ProfileDescription}, Password: {Password}";
        }
    }

    public class StandardUser : User, IControl
    {
        public StandardUser() { }

        public StandardUser(string username, string profileDescription, string password)
            : base(username, profileDescription, password) { }

        // Metodo per creare una password
        public void createPassword()
        {
            // Inserimento password
            Console.WriteLine("Inserisci la password per lo StandardUser ( >= 10 caratteri):");
            Console.WriteLine("La password non può contenere caratteri vuoti!");
            string password = Console.ReadLine();

            // Controllo lunghezza password
            if (password.Length >= 10 && !string.IsNullOrWhiteSpace(password))
            {
                // Assegnazione password
                Password = password;
                Console.WriteLine($"Password creata con successo! nuova pw => {password}\n");
            }
            else
            {
                Console.WriteLine("La password deve contenere 10 caratteri e non può essere vuota!\n");
            }

        }

        // Metodo per modificare la password
        public void changePassword()
        {
            // Inserimento nuova password
            Console.WriteLine("Inserisci la nuova password per lo StandardUser ( >= 10 caratteri):");
            Console.WriteLine("La password non può contenere caratteri vuoti!");
            string newPassword = Console.ReadLine();

            // Controllo lunghezza password che non sia nulla, vuota o composta solo da spazi bianchi
            if (newPassword.Length >= 10 && !string.IsNullOrWhiteSpace(newPassword))
            {
                // Assegnazione nuova password
                Password = newPassword;
                Console.WriteLine($"Password modificata con successo!nuova pw => {newPassword}\n");
            }
            else
            {
                Console.WriteLine($"La password deve contenere 10 caratteri e non può essere vuota!\n");
            }
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return $"StandardUser: {Username}, Descrizione: {ProfileDescription}, Password: {Password}";
        }
    }


    /*
          6. Si scriva un programma che tenga conto del guadagno degli impiegati di una fabbrica.
             Si implementino le seguenti 4 classi:
                − Employee
                − Technician
                − Laborer
                − Engineer

             In particolare un Laborer baserà il suo guadagno anche sul totale di ore e sul numero di pezzi lavorati.

             Testarne la corretta implementazione. 
     
     */


    public abstract class Employee
    {
        // Attributi
        private string nome;
        private string cognome;
        private double stipendioBase;

        // Get e Set
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public double StipendioBase { get; set; }

        // Costruttore vuoto
        public Employee()
        {
        }

        // Costruttore parametrizzato
        public Employee(string nome, string cognome, double stipendioBase)
        {
            Nome = nome;
            Cognome = cognome;
            StipendioBase = stipendioBase;
        }

        // Metodo astratto per calcolare il guadagno
        public abstract double calcolaGuadagno();

        // Override del metodo ToString
        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Stipendio Base: {StipendioBase}";
        }
    }

    public class Technician : Employee
    {
        // Attributi
        private double oreLavorate;
        private double guadagnoOrario;
        // Get e Set
        public double OreLavorate { get; set; }
        public double GuadagnoOrario { get; set; }
        // Costruttore vuoto
        public Technician()
        {
        }
        // Costruttore parametrizzato
        public Technician(string nome, string cognome, double stipendioBase, double oreLavorate, double guadagnoOrario)
            : base(nome, cognome, stipendioBase)
        {
            OreLavorate = oreLavorate;
            GuadagnoOrario = guadagnoOrario;
        }
        // Metodo per calcolare il guadagno del tecnico
        public override double calcolaGuadagno()
        {
            // Calcolo del guadagno del tecnico in base alle ore lavorate e al guadagno orario
            return StipendioBase + (OreLavorate * GuadagnoOrario);
        }
        // Override del metodo ToString
        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Stipendio Base: {StipendioBase}, Ore Lavorate: {OreLavorate}, Guadagno Orario: {GuadagnoOrario}";
        }
    }

    public class Laborer : Employee
    {
        // Attributi
        private double oreLavorate;
        private double numeroPezzi;
        private double pagaOraria;
        private double pagaPerPezzo;

        // Get e Set
        public double OreLavorate { get; set; }
        public double NumeroPezzi { get; set; }
        public double PagaOraria { get; set; }
        public double PagaPerPezzo { get; set; }

        // Costruttore vuoto
        public Laborer()
        {
        }

        // Costruttore parametrizzato
        public Laborer(string nome, string cognome, double stipendioBase, double oreLavorate, double numeroPezzi, double pagaOraria, double pagaPerPezzo)
            : base(nome, cognome, stipendioBase)
        {
            OreLavorate = oreLavorate;
            NumeroPezzi = numeroPezzi;
            PagaOraria = pagaOraria;
            PagaPerPezzo = pagaPerPezzo;
        }

        // Override del metodo calcolaGuadagno
        public override double calcolaGuadagno()
        {
            // Calcolo del guadagno del lavoratore in base alle ore lavorate, al numero di pezzi lavorati, alla paga oraria e alla paga
            return StipendioBase + (OreLavorate * PagaOraria) + (NumeroPezzi * PagaPerPezzo);
        }

        // Override del metodo ToString
        public override string ToString()
        {
            return base.ToString() + $", Ore Lavorate: {OreLavorate}, Numero Pezzi: {NumeroPezzi}, Paga Oraria: {PagaOraria}, Paga per Pezzo: {PagaPerPezzo}, Guadagno Totale: {calcolaGuadagno()}";
        }

    }

    public class Engineer : Employee
    {
        // Attributi
        private double bonus;
        // Get e Set
        public double Bonus { get; set; }
        // Costruttore vuoto
        public Engineer()
        {
        }
        // Costruttore parametrizzato
        public Engineer(string nome, string cognome, double stipendioBase, double bonus)
            : base(nome, cognome, stipendioBase)
        {
            Bonus = bonus;
        }
        // Metodo per calcolare il guadagno dell'ingegnere
        public override double calcolaGuadagno()
        {
            // Calcolo del guadagno dell'ingegnere in base allo stipendio base e al bonus
            return StipendioBase + Bonus;
        }
        // Override del metodo ToString
        public override string ToString()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Stipendio Base: {StipendioBase}, Bonus: {Bonus}";
        }
    }

}
