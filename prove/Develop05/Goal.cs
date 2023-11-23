// Define an abstract class named Goal
public abstract class Goal
{
    // Declare protected variables for the goal
    protected bool _isCompleted;
    protected string _name;
    protected string _description;
    protected int _points;
    protected int _type;

    // Constructor for the Goal class
    public Goal (string name, string description, int points, bool isCompleted)
    {
        // Initialize the goal with the provided name, description, points, and completion status
        _name = name;
        _description = description;
        _points = points;
        _isCompleted = isCompleted;
    }

    // Declare abstract methods that must be implemented in any class that inherits from Goal
    public abstract void SetIsCompleted();
    public abstract void DisplayGoal(int option); // user.RecordEvent will use the option to show a list of the goals without the checkbox and description
    public abstract string GetStringRep();

    // Getter methods to access the private variables

    // Returns whether the goal is completed
    public bool GetIsCompleted()
    {
        return _isCompleted;
    }

    // Returns the points associated with the goal
    public int GetPoints()
    {
        return _points;
    }
}