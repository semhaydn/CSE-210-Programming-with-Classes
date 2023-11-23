public class EternalGoal : Goal
{
    // Declare private variable for the times the goal has been accomplished
    private int _timesAccomplished;

    // Constructor for the EternalGoal class, which inherits from the Goal class
    public EternalGoal(string name, string description,int timesAccomplished, int points) : base (name, description, points, false)
    {
        _type = 2; // Set the type of the goal
        _timesAccomplished = timesAccomplished; // Initialize the times the goal has been accomplished
    }

    // Method to mark the goal as completed
    public override void SetIsCompleted()
    {   
        _timesAccomplished += 1; // Increment the times the goal has been accomplished
        _isCompleted = false; // Reset the completion status of the goal
        Console.WriteLine($"Congratulations! You earned {_points} points"); // Display the earned points
    }

    // Method to display the goal
    public override void DisplayGoal(int option)
    {
        if (option == 0) 
        {
            // Display the name, description, and times the goal has been accomplished
            Console.WriteLine($"    {_name} ({_description}) -- Times accomplished: {_timesAccomplished}");
        }
        else 
        {
            // Display the name of the goal
            Console.WriteLine($"{_name}");         
        }
    }

    // Method to get the string representation of the goal
    public override string GetStringRep()
    {
        // Return the string representation of the goal
        return $"{_type}|{_name}|{_description}|{_timesAccomplished}|{_points}";
    }
}