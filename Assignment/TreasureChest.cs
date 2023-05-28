namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material; // The material of the treasure chest
        private readonly LockType _lockType; // The type of lock on the treasure chest
        private readonly LootQuality _lootQuality; // The quality of loot inside the treasure chest

        // Default Constructor
        public TreasureChest()
        {
            _material = Material.Aluminum; // treasurechest material
            _lockType = LockType.Light; // type
            _lootQuality = LootQuality.Silver; // quality
        }

        public TreasureChest(Material Alumenium, LockType Light, LootQuality Silver)
        {
            _material = Alumenium;
            _lockType = Light;
            _lootQuality = Silver;
        }


        public State GetState()
        {
            return _state;
        }

        public State Manipulate(Action action)
        {
            if (action == Action.Open)
            {
                Open();
            }
            return _state;
        }

        public void Unlock()
        {
            if (_state == State.Closed) //if it is closed, a message is prompted that it is closed.
            {
                _state = State.Locked; //If it is locked, it has to be unlocked
            }
            else if (_state == State.Open) //so if it is already open, a message is prompted.
            {
                Console.WriteLine("The chest is already open, so it cannot be unlocked!");
            }
            else if (_state == State.Locked)
            {
                Console.WriteLine("The chest cannot be unlocked as it is locked.");
            }
        }

        public void Lock()
        {
            if (_state == State.Locked)
            {
                _state = State.Closed; //if it is closed , it will be locked
            }
            else if (_state == State.Locked) //if it already locked, a message is prompted
            {
                System.Console.WriteLine("The chest is already Locked!");
            }
            else if (_state == State.Open) //if it is already opened, message is prompted
            {
                System.Console.WriteLine("The chest cannot be locked because it is open.");
            }
        }

        public void Open()
        {
            if (_state == State.Open) // if it already opened , a message is prompted
            {
                _state = State.Closed; // if it is closed , it will be opened
            }
            else if (_state == State.Open)
            {
                Console.WriteLine("The chest is already opened!");
            }
            else if (_state == State.Locked) //if it is locked, a message is prompted
            {
                Console.WriteLine("The chest cannot be opened because it is locked.");
            }
        }

        public void Close()
        {
            if (_state == State.Open) //if it is opened, it will be closed
            {
                _state = State.Closed; // ig it is already closed, a message is prompted
            }
            else if (_state == State.Closed)
            {
                Console.WriteLine("The chest is already closed!");
            }
            else if (_state == State.Locked) // if it is already locked, a message is prompted
            {
                Console.WriteLine("The chest cannot be closed because it is locked.");
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron, Aluminum };
        public enum LockType { Novice, Intermediate, Expert, Light }
        public enum LootQuality { Grey, Green, Purple, Silver }
    }

    public class Program
    {
        public static void Main()
        {
            TreasureChest chest = new TreasureChest(); // create a new instance

            Console.WriteLine(chest.ToString()); //print the initial state
            chest.Manipulate(TreasureChest.Action.Open); //manupulate it by opening it
            Console.WriteLine(chest.ToString()); //print the status of chest


        }
    }
}