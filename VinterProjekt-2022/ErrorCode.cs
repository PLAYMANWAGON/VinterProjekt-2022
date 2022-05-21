public class ErrorCode
{
    private Dictionary<string, string> errors = new Dictionary<string, string>();

    // Här får programmeraren en enkelt sätt att enklare debugga om något illa
    // skulle hända. För tillfället finns det ett fåtal errorcodes, men om jag
    // vore skapa ett mycket större spel hade det troligtvis funnits mer här. 

    public ErrorCode()
    {
        errors.Add("001", "User input invalid value. (Answer with Y/N)");
        errors.Add("002", "User input is null. (Input cannot be empty)");
        errors.Add("003", "Unknown error occured. Program will shut down within three seconds.");
        errors.Add("004", "Please enter the specified commands.");
        // ERROR CODE FÖR MAIN MENY OM MAN SKRIVER NÅGOT DUMT
    }

    public string GetError(string n)
    {
        return errors[n];
    }

}