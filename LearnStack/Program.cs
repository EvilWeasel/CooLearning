using LearnStack.Models;
// Do not touch any of this code, to verify you did the exercise correctly
LearnStack<string> browserHistory = new LearnStack<string>(5);

// Simulate browsing history
browserHistory.Push("Home");
browserHistory.Push("Blog");
browserHistory.Push("Tutorial");
browserHistory.Push("Projects");

// Print the current page
Console.WriteLine($"Current Page: {browserHistory.Peek()}");

// User clicks the back button
string previousPage = browserHistory.Pop();
Console.WriteLine($"Back Button Clicked! Returned from {previousPage} to {browserHistory.Peek()}");

// Print the updated current page
Console.WriteLine($"Current Page: {browserHistory.Peek()}");

// User navigates to a new page
browserHistory.Push("Contact");

// Print the updated browser history
browserHistory.PrintStack();

// Create a new stack with a size of 3 for overflow testing
LearnStack<string> overflowStack = new LearnStack<string>(3);

Console.WriteLine("Testing Over- and Underflows...");

// Simulate pushing onto a full stack
overflowStack.Push("Item1");
overflowStack.Push("Item2");
overflowStack.Push("Item3");
overflowStack.Push("Item4"); // This should display an overflow message, but not throw

overflowStack.Pop();
overflowStack.Pop();
overflowStack.Pop();
overflowStack.Pop(); // This should display an underflow message, but not throw

Console.WriteLine("You did it!");
