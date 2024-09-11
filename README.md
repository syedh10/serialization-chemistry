# Atom Serialization Project

This code explores object serialization and deserialization using JSON in C#. It involves creating a simple class representation of atoms and manipulating a collection of these atoms using JSON serialization and deserialization techniques.

## Features
- Atom Class: Represents an atom with properties like Name, Symbol, Proton, Neutron, and Weight.
- Serialization: Save a single atom or a collection of atoms into JSON format.
- Deserialization: Read and recreate atoms from a JSON file.
- Exception Handling: Ensures that parsing errors are caught and handled properly.
- JSON Manipulation: Utilize System.Text.Json to serialize and deserialize objects to and from JSON format.

## Technologies
- C# (.NET)
- System.Text.Json: For JSON serialization and deserialization
- Exception Handling: Custom exceptions for parsing issues

## Atom Class Overview
The Atom class represents an element from the periodic table with the following properties:
- Name: UIPAC name of the atom.
- Symbol: Chemical symbol of the atom (e.g., "H" for Hydrogen).
- Proton: Atomic number (number of protons).
- Neutron: Number of neutrons in the atom.
- Weight: Atomic weight of the atom.

## Methods
- 'Atom()': Default constructor, required for serialization.
- 'Atom(string name, int proton, int neutron, double weight, string symbol)': Parameterized constructor to create an atom.
- 'static Atom Parse(string line)': Parses a string representation of an atom and creates an Atom object. Throws an exception if parsing fails.
- 'override string ToString()': Returns a string representation of the atom object.

## Prerequisites
- .NET 6 or higher
- Install System.Text.Json NuGet package by running the following command in the project directory:
  `dotnet add package System.Text.Json`

  ## Running the Application
1. Clone the repository: `git clone https://github.com/your-username/atom-serialization.git`
2. Navigate to the project directory: `cd atom-serialization`
3. Build and run the project: `dotnet run`
4. The program will:
    - Display a list of atoms.
    - Serialize the first atom into first_atom.json.
    - Deserialize first_atom.json and display the atom.
    - Serialize the entire collection of atoms into all_atoms.json.
    - Deserialize all_atoms.json and display all atoms.

## Exception Handling
The program handles exceptions in the following cases:
 - Parsing errors when the input string does not contain exactly 5 parts.
 - I/O exceptions when reading/writing JSON files.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
 
