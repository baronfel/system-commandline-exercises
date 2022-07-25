namespace StarTrek;
class Program
{
    static void Main(string[] args)
    {
    }

    /// <summary>
    /// Prints out the crew roster for a given series of Star Trek
    /// <summary>
    void ListAllCrew(string series) {
        if (series == "originalSeries") {
            PrintCrew(originalSeries);
        } else if (series == "nextGeneration") {
            PrintCrew(nextGeneration);
        };
    }

    /// <summary>
    /// Given a particular series and crew role, prints out the crew member matching that role.
    /// </summary>
    void GetCrewMember(string series, string role) {
        Func<Crew, string> crewGetter = role switch {
            "captain" => (c => c.captain),
            "firstOfficer" => (c => c.firstOfficer),
            "securityOfficer" => (c => c.securityOfficer),
            "chiefEngineer" => (c => c.chiefEngineer)
        };

        var crewMember = series switch {
            "originalSeries" => crewGetter(originalSeries),
            "nextGeneration" => crewGetter(nextGeneration)
        };

        DescribeCrewMember(series, role, crewMember);
    }

    #region Raw Data and Helper Methods

    void PrintCrew(Crew c) {
        Console.WriteLine($"Captain:\t{c.captain}");
        Console.WriteLine($"First Officer:\t{c.firstOfficer}");
        Console.WriteLine($"Security Officer:\t{c.securityOfficer}");
        Console.WriteLine($"Chief Engineer:\t{c.chiefEngineer}");
    }

    void DescribeCrewMember(string series, string role, string crewMember) => 
        Console.WriteLine($"The {role} during {series} was {crewMember}");

    record Crew(string captain, string firstOfficer, string securityOfficer, string chiefEngineer);
    Crew originalSeries = new ("James T. Kirk", "Spock", "Pavel Chekov", "Montgomery Scott");
    Crew nextGeneration = new ("Jean-Luc Picard", "William T. Riker", "Worf", "Geordi La Forge");

    #endregion
}


