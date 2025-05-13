// class Program {
//     public static void Main(string[] args) {
       
//         // string csvLine = "Chair,129.99";
//         // IProductProvider csvadapter = new CsvProductAdapter(csvLine);
//         // IProductProvider adapter = new Adapter(csvadapter);
//         // Product product = adapter.GetProduct();
//         // Console.WriteLine($"Name: {product.Name}: Price: {product.Price}");

//         // StripeProcessor stripeProcessor = new StripeProcessor();
//         // PayPalProcessor payPalProcessor = new PayPalProcessor();
//         // CryptoProcessor cryptoProcessor = new CryptoProcessor();

//         // BasicPayment basicPayment = new BasicPayment(stripeProcessor);
//         // basicPayment.payment(49.99m);

//         // SubscriptionPayment subscriptionPayment = new SubscriptionPayment(payPalProcessor);
//         // subscriptionPayment.payment(99.99m);


//         // SimpleTask task1 = new SimpleTask("Buy groceries");
//         // SimpleTask task2 = new SimpleTask("Call mom");
//         // SimpleTask task3 = new SimpleTask("Pay bills");

//         // CompositeTask personalTasks = new CompositeTask("Personal Tasks");
//         // personalTasks.add(task1);
//         // personalTasks.add(task2);
//         // personalTasks.add(task3);

//         // SimpleTask task4 = new SimpleTask("Fix login bug");
//         // SimpleTask task5 = new SimpleTask("Deploy new release");

//         // CompositeTask workTasks = new CompositeTask("Work Tasks");
//         // workTasks.add(task4);
//         // workTasks.add(task5);

//         // CompositeTask allTasks = new CompositeTask("All Tasks");
//         // allTasks.add(personalTasks);
//         // allTasks.add(workTasks);

//         // allTasks.Display();

//         // Console.WriteLine($"All files coint is " + allTasks.GetTotalTasksCount());

//         // IDocument textdocument = new PlainTextDocument("Hello World");
//         // textdocument = new BoldDecorator(textdocument);
//         // textdocument = new ItalicDecorator(textdocument);
//         // textdocument = new HighlightDecorator(textdocument);

//         // Console.WriteLine(textdocument.GetContent());

//         CPU cpu = new CPU();
//         Memory memory = new Memory();
//         HardDrive hardDrive = new HardDrive();
//         GPU gpu = new GPU();
//         ComputerFacade computer = new ComputerFacade(cpu, memory, hardDrive, gpu);
//         computer.startComputer();
//         Console.WriteLine();
//         computer.shutingdownComputer();

//     }
// }