// You are building a task management system.
//  Each task can be:
// A SimpleTask (basic task with a name)

// A CompositeTask (a task made up of multiple sub-tasks)

// ✅ You must use the Composite Design Pattern to represent tasks and sub-tasks uniformly.
// ✅ Both Simple and Composite tasks must have a common interface.

// 🛠 Your Tasks:
// Define a TaskItem interface (or abstract class) that declares:

// getName(): string

// display(indent: string): void

// Implement SimpleTask class:

// Stores a name.

// Implements display() to print its name.

// Implement CompositeTask class:

// Stores a name.

// Contains a list of TaskItem children.

// Can add() sub-tasks.

// Implements display() to print itself and recursively print its sub-tasks.



using System.Runtime.CompilerServices;

// interface ITaskItem {
    
//     string GetName();
//     void Display();

// }

// class SimpleTask : ITaskItem {

//     private string _name;

//     public SimpleTask(string name) {
    
//         this._name = name;
    
//     }

//     public void Display() {
        
//         Console.WriteLine($"-{GetName()}");

//     }

//     public string GetName() {
//         return _name;
//     }

// }

// class CompositeTask : ITaskItem{

//     private static int _count = 0;
//     List<ITaskItem> taskItems = new();

//     private string _name;

//     public CompositeTask(string name) {

//         this._name = name;

//     }

//     public void Display () {
        
//         Console.WriteLine($"{GetName()}");
//         foreach (var taskItem in taskItems) {
           
//            taskItem.Display();
//         }

//     }

//     public int GetTotalTasksCount () {
        
//         Sum();
//         return _count;

//     }

//     private void Sum() {

//         foreach (ITaskItem item in taskItems) 
//         {
//             if (item is CompositeTask s) {
//                 s.Sum();
//             }

//             else{
//                 ++_count;
//             }
//         }
//     }

//     public string GetName() {
//         return $"+{_name}";
//     }
    
//     public void add(ITaskItem taskItem) {
//         taskItems.Add(taskItem);
//     }

// }