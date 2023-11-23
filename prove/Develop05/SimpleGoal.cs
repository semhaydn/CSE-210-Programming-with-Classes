public class SimpleGoal : Goal
{
    // Constructor for SimpleGoal, which inherits from the Goal class
    public SimpleGoal(string name, string description, int points, bool isCompleted) : base (name, description, points, isCompleted)
    {
        _type = 1; // Set the type of the goal
    }

    // Method to mark the goal as completed
    public override void SetIsCompleted()
    {
        _isCompleted = true; // Mark the goal as completed
        Console.WriteLine($"Congratulations! You earned {_points} points"); // Display the earned points
    }

    // Method to display the goal
    public override void DisplayGoal(int option)
    {
        if(option == 0) // If the option is 0
        {
            if(GetIsCompleted()) // If the goal is completed
            {
                Console.Write("[X]"); // Display [X]
            }
            else
            {
                Console.Write("[ ]"); // Display [ ]
            }
            Console.WriteLine($" {_name} ({_description})"); // Display the name and description of the goal
        }
        else
        {
            Console.WriteLine($"{_name}"); // Display the name of the goal         
        }
    }

    // Method to get the string representation of the goal
    public override string GetStringRep()
    {
        return $"{_type}|{_name}|{_description}|{_points}|{_isCompleted}"; // Return the string representation of the goal
    }
}