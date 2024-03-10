namespace LearnStack.Models;

// Generic implementation of the stack datastructure
// implement all methods given, so the program compiles
public class LearnStack<T>
{
  // Maximum size of the stack
  private int maxSize;
  // Index of the top element in the stack
  private int top;
  // Array to store elements of the stack
  private T[] stackArray;
  // Constructor to initialize the stack with a specified size
  public LearnStack(int size)
  {
    maxSize = size;
    // Create an array to store the elements
    stackArray = new T[maxSize];
    // Initialize top to -1 to indicate an empty stack
    top = -1;
  }
  // Method to push an item onto the stack
  //  if array is full, we overflowed the stack:
  //    write error and return
  public void Push(T item)
  {

  }
  // Method to pop an item from the stack
  //  if stack is empty, we underflowed the stack:
  //    write error and "return default"
  public T Pop()
  {

  }
  // Method to peek at the top item without removing it
  //  if stack is empty, print error and "return default"
  public T Peek()
  {

  }
  // Method to check if the stack is empty
  public bool IsEmpty()
  {

  }
  // Method to print the current elements of the stack
  //  if stack is not empty, print the stack (top->bottom)
  public void PrintStack()
  {

  }
}
