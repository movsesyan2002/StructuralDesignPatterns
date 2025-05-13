// You are simulating how a computer boots up.
//  Normally, starting a computer involves many steps at different levels:
// Starting the CPU


// Loading Memory


// Reading data from the HardDrive


// Activating the GPU for graphics


// ✅ Your goal is to hide the complexity behind a simple Facade:
//  Just call startComputer() and everything starts correctly.
// ✅ Apply Facade Design Pattern.

// 🛠 Tasks:
// Create 4 subsystem classes:


// CPU

// freeze()

    // execute()

// Memory

    // load(address: number, data: string)

// HardDrive

    // read(sector: number, size: number): string

// GPU

    // initialize()

// Create a ComputerFacade class that:

// Takes instances of CPU, Memory, HardDrive, GPU.

// Has a method startComputer() that:

// Freezes the CPU

// Loads the program into memory

// Reads data from hard drive

// Initializes the GPU

// Executes the CPU


class CPU {
    public void freeze() {

        Console.WriteLine("Cpu is freezing....");
    
    }

    public void execute() {

        Console.WriteLine("CPU executing program...");

    }

    public void shutingdown() {
        Console.WriteLine($"{GetType()} shutting down...");
    }

}

class Memory {

    public void load (int address, string data) {
        Console.WriteLine($"Memory loading program at address {address} data");
    }

    public void Clear() {
        Console.WriteLine($"{GetType()} cleaning...");
    }

}


class HardDrive {

    public string read (int sector, int size) {
        return $"HardDrive reading sector {sector} (size {size})";
    }

    public void ParkingHead() {
        Console.WriteLine($"{GetType()} parking head...");
    }

}


class GPU {

    public void initialize() {
        Console.WriteLine("GPU initializing...");
    }

    public void shutingdown() {
        Console.WriteLine($"{GetType()} shutting down...");
    }

}


class ComputerFacade {

    private CPU _cpu;
    private Memory _memory;
    private HardDrive _drive;
    private GPU _gpu;

    public ComputerFacade(CPU cpu, Memory memory, HardDrive drive, GPU gpu) {
        
        _cpu = cpu;
        _memory = memory;
        _drive = drive;
        _gpu = gpu;
    
    }

    public void startComputer() {
        
        _cpu.freeze();
        _memory.load(0, "data");
        Console.WriteLine(_drive.read(0,1024));
        _gpu.initialize();
        _cpu.execute();

    }

    public void shutingdownComputer () {
        _cpu.shutingdown();
        _gpu.shutingdown();
        _memory.Clear();
        _drive.ParkingHead();
    }

}