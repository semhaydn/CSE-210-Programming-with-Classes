public class ChecklistGoal : Goal
{
    // Declare private variables for the bonus points, times to accomplish, and times accomplished
    private int _bonusPoints;
    private int _timesToAccomplish;
    private int _timesAccomplished;

    // Constructor for the ChecklistGoal class, which inherits from the Goal class
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int timesToAccomplish, int timesAccomplished, bool isCompleted) 
        : base (name, description, points, isCompleted)
    {
        _type = 3; // Set the type of the goal
        _timesAccomplished = timesAccomplished; // Initialize the times the goal has been accomplished
        _bonusPoints = bonusPoints; // Initialize the bonus points
        _timesToAccomplish = timesToAccomplish; // Initialize the times to accomplish the goal
    }

    // Method to mark the goal as completed
    public override void SetIsCompleted()
    {
        _timesAccomplished += 1; // Increment the times the goal has been accomplished
        if (_timesToAccomplish == _timesAccomplished) // If the goal has been accomplished the required number of times
        {
            _isCompleted = true; // Mark the goal as completed
            _points += _bonusPoints; // Add the bonus points to the total points
        }
        // Display a message indicating the points earned
        Console.WriteLine($"Congratulations! You have earned {_points} points");
    }

    // Method to display the goal
    public override void DisplayGoal(int option)
    {
        if(option == 0)
        {
            if(GetIsCompleted()) // If the goal is completed
            {
                Console.Write("[X]"); // Display [X]
            }
            else
            {
                Console.Write("[ ]"); // Display [ ]
            }
            // Display the goal name, description, and times accomplished
            Console.WriteLine($" {_name} ({_description}) -- Times accomplished: {_timesAccomplished}/{_timesToAccomplish}");
        }
        else
        {
            // Display only the goal name
            Console.WriteLine($"{_name}");         
        }
    }

    // Method to get the string representation of the goal
    public override string GetStringRep()
    {
        // Return the string representation of the goal
        return $"{_type}|{_name}|{_description}|{_points}|{_bonusPoints}|{_timesToAccomplish}|{_timesAccomplished}|{_isCompleted}";
    }
}