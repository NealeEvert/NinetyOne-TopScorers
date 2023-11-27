# Implementation Notes
- Adding Inversion of Control and Dependency Injections for Data Reader, Processor and Logger
- Implementing files streaming for large data files so as not to log entire file into memory smaller files can be read in entirely
- Will use string.Split() to get each value. TODO: How to deal with quotes in csv file - not in test data
- Copy test file to build directory in the solution file
- Implement log4net file logging and console logging
- Implement unit tests using IoC container to stub out file reader values
