/// <summary>
/// Prints out the crew roster for a given series of Star Trek
/// <summary>
void ListAllCrew(string series) {
    return series switch {
        "originalSeries" => PrintCrew(originalSeries),
        "nextGeneration" => PrintCrew(nextGeneration),
    };
}

/// <summary>
/// Given a particular series and crew role, prints out the crew member matching that role.
/// </summary>
void GetCrewMember(string series, string role) {
    var crewGetter = role switch {
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

var originalSeries = new Crew("James T. Kirk", "Spock", "Pavel Chekov", "Montgomery Scott");
var nextGeneration = new Crew("Jean-Luc Picard", "William T. Riker", "Worf", "Geordi La Forge");

void PrintCrew(Crew c) {
    Console.WriteLine($"Captain:\t{c.captain}");
    Console.WriteLine($"First Officer:\t{c.firstOfficer}");
    Console.WriteLine($"Security Officer:\t{c.securityOfficer}");
    Console.WriteLine($"Chief Engineer:\t{c.chiefEngineer}");
}

void DescribeCrewMember(string series, string role, string crewMember) => 
    Console.WriteLine($"The {role} during {series} was {crewMember}");

record Crew(string captain, string firstOfficer, string securityOfficer, string chiefEngineer);

#endregion