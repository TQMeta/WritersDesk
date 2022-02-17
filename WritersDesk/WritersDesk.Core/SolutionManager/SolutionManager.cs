namespace WritersDesk.Core.SolutionManager;

public class SolutionManager
{

    public string SolutionName { get; set; }
    public string SolutionPath { get; set; }

    public SolutionManager(string solutionName, string solutionPath)
    {
        this.SolutionName = solutionName;
        this.SolutionPath = solutionPath;
    }
}