using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StructuralPatterns.Decorator;
using StructuralPatterns.Proxy;
using StructuralPatterns.Bridge;
using StructuralPatterns.Composite;
using StructuralPatterns.Flyweight;
using StructuralPatterns.Adapter;
using StructuralPatterns.Facade;
using CreationalPatterns.Prototype;
using CreationalPatterns.Factory;
using CreationalPatterns.Singleton;
using CreationalPatterns.AbstractFactory;
using CreationalPatterns.Builder;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.State;
using BehavioralPatterns.Template;
using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.Command;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Mediator;
using BehavioralPattrerns.Observer;
using BehavioralPatterns.Visitor;
using BehavioralPatterns.Memento;

namespace ConsApp.DesignPattern
{
    class Program
    {
        private static void PrintPatternChoice_Structural()
        {
            StringBuilder text = new StringBuilder();
            text.Append("-------------------------------------------------------").Append(Environment.NewLine.ToString());
            text.Append(" Structural Patterns:").Append(Environment.NewLine.ToString());
            text.Append(" [A]\tDecorator\t\t[B]\tProxy").Append(Environment.NewLine.ToString());
            text.Append(" [C]\tBridge\t\t\t[D]\tComposite").Append(Environment.NewLine.ToString());
            text.Append(" [E]\tFlyweight\t\t[F]\tAdapter").Append(Environment.NewLine.ToString());
            text.Append(" [G]\tFacade").Append(Environment.NewLine.ToString());
            Console.WriteLine(text.ToString());
        }

        private static void PrintPatternChoice_Creational()
        {
            StringBuilder text = new StringBuilder();
            text.Append("\n-------------------------------------------------------").Append(Environment.NewLine.ToString());
            text.Append(" Creational Patterns:").Append(Environment.NewLine.ToString());
            text.Append(" [H]\tPrototype\t\t[I]\tFactory").Append(Environment.NewLine.ToString());
            text.Append(" [J]\tSingleton\t\t[K]\tAbstract Factory").Append(Environment.NewLine.ToString());
            text.Append(" [L]\tBuilder").Append(Environment.NewLine.ToString());
            Console.WriteLine(text.ToString());
        }

        private static void PrintPatternChoice_Behavioral()
        {
            StringBuilder text = new StringBuilder();
            text.Append("\n-------------------------------------------------------").Append(Environment.NewLine.ToString());
            text.Append(" Behavioral Patterns:").Append(Environment.NewLine.ToString());
            text.Append(" [M]\tStrategy\t\t[N]\tState").Append(Environment.NewLine.ToString());
            text.Append(" [O]\tTemplate\t\t[P]\tChain of Responsibility").Append(Environment.NewLine.ToString());
            text.Append(" [Q]\tCommand\t\t\t[R]\tIterator").Append(Environment.NewLine.ToString());
            text.Append(" [S]\tIterator\t\t[T]\tObserver").Append(Environment.NewLine.ToString());
            text.Append(" \t\t\t\t\t[V]\tInterpreter").Append(Environment.NewLine.ToString());
            text.Append(" [Z]\tMemento").Append(Environment.NewLine.ToString());
            Console.WriteLine(text.ToString());
        }

        static void Main(string[] args)
        {
            try
            {
                StringBuilder text = new StringBuilder();
                text.Append("*************************************************").Append(Environment.NewLine.ToString());
                text.Append("\tAvailable Patterns").Append(Environment.NewLine.ToString());
                PrintPatternChoice_Structural();
                PrintPatternChoice_Creational();
                PrintPatternChoice_Behavioral();
                text.Append("*************************************************").Append(Environment.NewLine.ToString());
                Console.WriteLine(text.ToString());
                Console.Write(" Please select a Pattern:  ");
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    #region Structural Pattern
                    case "A":
                        ExecuteDecorator();
                        break;
                    case "B":
                        ExecuteProxy();
                        break;
                    case "C":
                        ExecuteBridge();
                        break;
                    case "D":
                        ExecuteComposite();
                        break;
                    case "E":
                        ExecuteFlyWeight();
                        break;
                    case "F":
                        ExecuteAdapter();
                        break;
                    case "G":
                        ExecuteFacade();
                        break;
                    #endregion

                    #region Creational Pattern
                    case "H":
                        ExecutePrototype();
                        break;
                    case "I":
                        ExecuteFactory();
                        break;
                    case "J":
                        ExecuteSingleton();
                        break;
                    case "K":
                        ExecuteAbstractFactory();
                        break;
                    case "L":
                        ExecuteBuilder();
                        break;
                    #endregion

                    #region Behavioral Pattern
                    case "M":
                        ExecuteStrategy();
                        break;
                    case "N":
                        ExecuteState();
                        break;
                    case "O":
                        ExecuteTemplate();
                        break;
                    case "P":
                        ExecuteChainOfResponsibility();
                        break;
                    case "Q":
                        ExecuteCommand();
                        break;
                    case "R":
                        ExecuteIterator();
                        break;
                    case "S":
                        ExecuteMediator();
                        break;
                    case "T":
                        ExecuteObserver();
                        break;
                    case "V":
                        ExecuteInterpreter();
                        break;
                    case "Z":
                        ExecuteMemento();
                        break;
                    #endregion
                    default:
                        break;
                }
                Console.WriteLine("*************************************************");
                Console.WriteLine("Bye Bye...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("*************************************************");
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private static void PrintPatternTitle(string title)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\t" + title);
            Console.WriteLine("------------------------------------------------");
        }

        #region Execute - Structural Pattern
        private static void ExecuteDecorator()
        {
            PrintPatternTitle("Decorator Pattern");
            IComponent baseComponent = new Component();
            IComponent decoratorA = new DecoratorA(baseComponent);
            IComponent decoratorB = new DecoratorB(baseComponent);
            IComponent decoratorBA = new DecoratorB(decoratorA);

            Console.WriteLine(" 1. Base Component: " + baseComponent.Operation());
            Console.WriteLine(" 2. Decorator A: " + decoratorA.Operation());
            Console.WriteLine(" 3. Decorator B: " + decoratorB.Operation());
            Console.WriteLine(" 4. Decorator B ==> A: " + decoratorBA.Operation());
            Console.WriteLine(" Explicit decorator");
            Console.WriteLine(" 5. Decorator B ==> A: " + decoratorBA.Operation() + "  " + ((DecoratorB)decoratorBA).AddedBehaviour());
        }

        private static void ExecuteProxy()
        {
            PrintPatternTitle("Proxy Pattern");

            ISubject subject = new Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());

            SecurityProxy sec = new SecurityProxy();
            Console.WriteLine(sec.Request());
            Console.WriteLine(" Try to authenticate:");
            Console.WriteLine(sec.Authenticate("prova"));
            Console.WriteLine(sec.Authenticate("abracadabra"));
            Console.WriteLine(sec.Request());


        }

        private static void ExecuteBridge()
        {
            PrintPatternTitle("Bridge Pattern");
            IBridge bridgeA = new ConcreteA();
            IBridge bridgeB = new ConcreteB();
            Abstraction absA = new Abstraction(bridgeA);
            Abstraction absB = new Abstraction(bridgeB);
            Console.WriteLine(" Bridge A: ");
            Console.WriteLine(absA.PerformOperation());
            Console.WriteLine(" Bridge B: ");
            Console.WriteLine(absB.PerformOperation());
        }

        private static void ExecuteComposite()
        {
            PrintPatternTitle("Composite Pattern");

            IComponent<string> album = new Composite<string>("Album");
            IComponent<string> point = album;
            string[] s;
            string command, parameter;
            // Create and manipulate a structure
            StreamReader instream = new StreamReader("Data\\Composite.dat");
            do
            {
                string t = instream.ReadLine();
                Console.WriteLine("\t > " + t);
                s = t.Split();
                command = s[0];
                if (s.Length > 1) parameter = s[1];
                else parameter = null;
                switch (command)
                {
                    case "AddSet":
                        IComponent<string> c = new Composite<string>(parameter);
                        point.Add(c);
                        point = c;
                        break;
                    case "AddPhoto":
                        point.Add(new Component<string>(parameter));
                        break;
                    case "Remove":
                        point = point.Remove(parameter);
                        break;
                    case "Find":
                        point = album.Find(parameter);
                        break;
                    case "Display":
                        Console.WriteLine(album.Display(0));
                        break;
                    case "Quit":
                        //command = "Quit";
                        break;
                }
            } while (!command.Equals("Quit"));
        }

        private static void ExecuteFlyWeight()
        {
            PrintPatternTitle("Flyweight Pattern");
            Application.Run(new Window());
        }

        private static void ExecuteAdapter()
        {
            PrintPatternTitle("Adapter Pattern");
            // select tyzpe
            Console.WriteLine(" Select implementation: [S]=Standard\t\t[P]=Pluggable");
            string select = Console.ReadLine().ToUpper();
            if (select == "S")
            {
                Console.WriteLine(" Standard Implementation");
                // Showing the Adapteee in standalone mode
                Adaptee first = new Adaptee();
                Console.Write("Before the new standard\nPrecise reading: ");
                Console.WriteLine(first.SpecificRequest(5, 3));

                // What the client really wants
                ITarget second = new Adapter();
                Console.WriteLine("\nMoving to the new standard");
                Console.WriteLine(second.Request(5));
            }
            else
            {
                Console.WriteLine(" Pluggable Implementation");
                PluggableAdapter adapter1 = new PluggableAdapter(new Adaptee());
                Console.WriteLine(adapter1.Request(5));

                PluggableAdapter adapter2 = new PluggableAdapter(new Target());
                Console.WriteLine(adapter2.Request(5));
            }
        }

        private static void ExecuteFacade()
        {
            PrintPatternTitle("Facade Pattern");
            Facade.Operation1();
            Facade.Operation2();
        }
        #endregion

        #region Execute - Creational Pattern
        private static void ExecutePrototype()
        {
            PrintPatternTitle("Prototype Pattern");
            PrototypeManager manager = new PrototypeManager();
            Prototype c2, c3;

            // Make a copy of Australia's data
            Console.WriteLine("\n> 1. Make a copy of Australia");
            c2 = manager.prototypes["Australia"].Clone();
            PrototypeClient.Report("Shallow cloning Australia\n===============", manager.prototypes["Australia"], c2);

            // Change the capital of Australia to Sydney
            Console.WriteLine("\n> 2. Change the capital of Australia to Sydney");
            c2.Capital = "Sydney";
            PrototypeClient.Report("Altered Clone's shallow state, prototype unaffected", manager.prototypes["Australia"], c2);

            // Change the language of Australia (deep data)
            Console.WriteLine("\n> 3. Change the language of Australia (deep data)");
            c2.SetLanguage("Chinese");
            PrototypeClient.Report("Altering Clone deep state: prototype affected *****", manager.prototypes["Australia"], c2);

            // Make a copy of Germany's data
            Console.WriteLine("\n> 4. Make a copy of Germany's data");
            c3 = manager.prototypes["Germany"].DeepCopy();
            PrototypeClient.Report("Deep cloning Germany\n============", manager.prototypes["Germany"], c3);

            // Change the capital of Germany
            Console.WriteLine("\n> 5. Change the capital of Germany");
            c3.Capital = "Munich";
            PrototypeClient.Report("Altering Clone shallow state, prototype unaffected", manager.prototypes["Germany"], c3);

            // Change the language of Germany (deep data)
            Console.WriteLine("\n> 6. Change the language of Germany (deep data)");
            c3.SetLanguage("Turkish");
            PrototypeClient.Report("Altering Clone deep state, prototype unaffected", manager.prototypes["Germany"], c3);
        }

        private static void ExecuteFactory()
        {
            PrintPatternTitle("Factory Pattern");
            Creator c = new Creator();
            for (int i = 1; i <= 12; i++)
            {
                IProduct product = c.FactoryMethod(i);
                Console.WriteLine("Month: " + i.ToString() + "\t\tAvocados " + product.ShipFrom());
            }
        }

        private static void ExecuteSingleton()
        {
            PrintPatternTitle("Singleton Pattern");

            Test1 t1a = Singleton<Test1>.UniqueInstance;
            Test1 t1b = Singleton<Test1>.UniqueInstance;

            if (t1a == t1b)
            {
                Console.WriteLine("Objects are the same instance");
            }
        }

        private static void ExecuteAbstractFactory()
        {
            PrintPatternTitle("Abstract Factory");
            // Call Client twice
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            new Client<Groundcover>().ClientMain();
        }

        private static void ExecuteBuilder()
        {
            PrintPatternTitle("Builder Pattern");

            // Create one director and two builders
            Director director = new Director();
            IBuilder b1 = new Builder1();
            IBuilder b2 = new Builder2();

            // Construct two products
            Console.WriteLine("Construct product 1:");
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Display();

            Console.WriteLine("\nConstruct product 2:");
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Display();
        }
        #endregion

        private static void ExecuteStrategy()
        {
            PrintPatternTitle("Strategy Pattern");

            BehavioralPatterns.Strategy.Context context = new BehavioralPatterns.Strategy.Context();
            context.SwitchStrategy();
            Random r = new Random(37);
            for (int i = BehavioralPatterns.Strategy.Context.start; i <= BehavioralPatterns.Strategy.Context.start + 15; i++)
            {
                if (r.Next(3) == 2)
                {
                    Console.Write("|| ");
                    context.SwitchStrategy();
                }
                Console.Write(context.Algorithm() + " ");
            }
            Console.WriteLine();
        }

        private static void ExecuteState()
        {
            PrintPatternTitle("State Pattern");

            BehavioralPatterns.State.Context context = new BehavioralPatterns.State.Context();
            context.State = new NormalState();
            Random r = new Random(37);
            for (int i = 5; i <= 25; i++)
            {
                int command = r.Next(3);
                Console.Write(context.Request(command) + " ");
            }
            Console.WriteLine();
        }

        private static void ExecuteTemplate()
        {
            PrintPatternTitle("Template Pattern");

            Algorithm m = new Algorithm();
            Console.WriteLine(" > Algorithm 1");
            m.TemplateMethod(new ClassA());
            Console.WriteLine(" > Algorithm 2");
            m.TemplateMethod(new ClassB());
        }

        private static void ExecuteChainOfResponsibility()
        {
            PrintPatternTitle("Chain of Responsibility Pattern");

            Dictionary<Levels, Structure> structure = new Dictionary<Levels, Structure> 
            {
                {Levels.Manager, new Structure {Limit = 9000, Positions =1}},
                {Levels.Supervisor, new Structure {Limit = 4000, Positions =3}},
                {Levels.Clerk, new Structure {Limit = 1000, Positions =10}}
            };
            Dictionary<Levels, List<Handler>> handlersAtLevel = new Dictionary<Levels, List<Handler>> 
            {
                {Levels.Manager, new List <Handler>( )},
                {Levels.Supervisor, new List <Handler>( )},
                {Levels.Clerk, new List <Handler>( )}
            };

            Console.WriteLine("Trusty Bank opens with");
            foreach (Levels level in Enum.GetValues(typeof(Levels)))
            {
                for (int i = 0; i < structure[level].Positions; i++)
                {
                    handlersAtLevel[level].Add(new Handler(i, level, structure, handlersAtLevel));
                }
                Console.WriteLine(structure[level].Positions + " " + level +
                                    "(s) who deal up to a limit of " + structure[level].Limit);
            }
            Console.WriteLine();


            int[] amounts = { 50, 2000, 1500, 10000, 175, 4500, 2000 };
            Random choice = new Random(11);
            foreach (int amount in amounts)
            {
                try
                {
                    int which = choice.Next(structure[Levels.Clerk].Positions);
                    Console.Write("Approached Clerk " + which + ". ");
                    Console.WriteLine(handlersAtLevel[Levels.Clerk][which].
                    HandleRequest(amount));
                }
                catch (ChainException e)
                {
                    Console.WriteLine("\nNo facility to handle a request of " +
                    e.Data["Limit"] +
                    "\nTry breaking it down into smaller requests\n");
                }
            }


            //Console.WriteLine("Initalizing....");
            //Handler start = null;
            //for (int i = 5; i > 0; i--)
            //  {
            //    Console.WriteLine("Handler " + i + " deals up to a limit of " + i * 1000);
            //    start = new Handler(i, start);
            //}
            //Console.WriteLine("Initalizing completed");
            //Console.WriteLine("");
            //int[] a = { 50, 2000, 1500, 10000, 175, 4500 };
            //foreach (int i in a)
            //    Console.WriteLine(start.HandleRequest(i));
        }

        private static void ExecuteCommand()
        {
            PrintPatternTitle("Command Execute");
            Command cmd = new Command(new Receiver());
            cmd.Execute();
            cmd.Redo();
            cmd.Undo();
            cmd.Execute();
        }

        private static void ExecuteIterator()
        {
            PrintPatternTitle("Iterator Pattern");
            Console.WriteLine("Example of Month:");
            MonthCollection.PrintMonthWith31Days();
            Console.WriteLine();

            Tree<Person> family = new Tree<Person>(
                new Node<Person>(new Person("Tom", 1950),
                    new Node<Person>(new Person("Peter", 1976),
                        new Node<Person>(
                            new Person("Sarah", 2000), null,
                            new Node<Person>(new Person("James", 2002), null, null) // no more siblings James
                                        ),
                        new Node<Person>(
                            new Person("Robert", 1978), null,
                            new Node<Person>(
                                new Person("Mark", 1982),
                                new Node<Person>(new Person("Carrie", 2005), null, null),
                                null) // no more siblings Mark
                                       )), null) // no siblings Tom
                                       );

            Console.WriteLine("My Family:");
            FamilyTree<Person> mytree = new FamilyTree<Person>(family);
            foreach (Person p in mytree.Preorder)
                Console.WriteLine(String.Format("> {0} ({1})", p.Name, p.BirthYear.ToString()));
            Console.WriteLine("\n");

            Console.WriteLine("My Family - On Filter birthyear > 1980:");
            var selection = mytree.Where(p => p.BirthYear > 1980);
            foreach (Person p in selection)
                Console.WriteLine(String.Format("> {0} ({1})", p.Name, p.BirthYear.ToString()));
            Console.WriteLine("\n");


        }

        private static void ExecuteMediator()
        {
            PrintPatternTitle("Mediator Pattern");
            Mediator m = new Mediator();
            Colleague chat1 = new Colleague(m, "John");
            Colleague chat2 = new Colleague(m, "David");
            Colleague chat3 = new Colleague(m, "Lucy");
        }

        private static void ExecuteObserver()
        {
            PrintPatternTitle("Observer Pattern");
            BehavioralPattrerns.Observer.Subject subject = new BehavioralPattrerns.Observer.Subject();
            Observer Observer = new Observer(subject, "Center", "\t\t");
            Observer observer2 = new Observer(subject, "Right", "\t\t\t\t");
            subject.Go();
        }

        private static void ExecuteVisitor()
        {
            PrintPatternTitle("Visitor Pattern");

            string rules = "COS333 L2 L2 L2 L2 L2 M25 (L40 T60 ) L10 E55 (L28 T73 ) ";
            BehavioralPatterns.Visitor.Context context = new BehavioralPatterns.Visitor.Context(rules);
            Console.WriteLine(rules + "\n");
            Element course = new Course(context);
            course.Parse(context);

            PrintVisitor visitor = new PrintVisitor();
            Console.WriteLine("Visitor 1 - Course structure");
            visitor.Print(course);
            StructureVisitor visitor2 = new StructureVisitor();
            visitor2.Summarize(course);
            Console.WriteLine("\n\nVisitor 2 - Summing the weights\nLabs " + visitor2.Lab + "% and Tests " + visitor2.Test + "%");
        }

        private static void ExecuteInterpreter()
        {
            PrintPatternTitle("Interpreter Pattern");
        }

        private static void ExecuteMemento()
        {
            PrintPatternTitle("Memento Pattern");

            // References to the mementos and creates the chess board
            Caretaker[] c = new Caretaker[10];
            Originator originator = new Originator();

            int move = 0;
            // Iterator for the moves
            BehavioralPatterns.Memento.Simulator simulator = new BehavioralPatterns.Memento.Simulator();
            foreach (string command in simulator)
            {
                // Check for undo
                if (command[0] == '*' && move > 0)
                    originator.GetMemento(c[move - 1].Memento);
                else
                    originator.Operation(command);
                move++;
                c[move] = new Caretaker();
                c[move].Memento = originator.SetMemento();
            }
        }
    }
}
