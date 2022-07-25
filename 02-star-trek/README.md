## Star Trek Crew Details utility

[Star Trek](https://en.wikipedia.org/wiki/Star_Trek) is a long-lived science-fiction television program that largely follows the adventures and explorations of the crews of different starships as they explore the galaxy.

With so many series, and so many ships, it can sometimes be hard to keep track of who appeared on which series! Luckily we are going to create a simple command-line utility to help keep this data at hand.

For this exercise, we'd like you to

1. Discover and add the System.CommandLine package, version 2.0.0-beta4.22272.1 to this project
2. Use the library to make an command-line application that includes the two given functions, `ListAllCrew` and `GetCrewMember` as commands that can be invoked from the command line. They should be separate commands, and the parameters of each function should be able to be provided by the user.
3. There are a lot of duplicated strings in this application, and users may not know what strings are allowed. Use System.CommandLine to parse or validate the user input so that only valid series and roles are allowed.