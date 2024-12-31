// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();
            
            Console.WriteLine("Welcome to the Goal Tackler Todo List!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a goal");
                Console.WriteLine("2. View goals");
                Console.WriteLine("3. Mark goal as complete");
                Console.WriteLine("4. Remove a goal");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the goal to add: ");
                        string newGoal = Console.ReadLine();
                        todoList.Add(newGoal);
                        Console.WriteLine("Goal added successfully!");
                        break;

                    case "2":
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("Your goal list is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nYour Goals:");
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
                            }
                        }
                        break;

                    case "3":
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("Your goal list is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nYour Goals:");
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
                            }

                            Console.Write("Enter the number of the goal to mark as complete: ");
                            if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= todoList.Count)
                            {
                                Console.WriteLine($"Goal '{todoList[goalNumber - 1]}' marked as complete!");
                                todoList.RemoveAt(goalNumber - 1);
                            }
                            else
                            {
                                Console.WriteLine("Invalid number. Please try again.");
                            }
                        }
                        break;

                    case "4":
                        if (todoList.Count == 0)
                        {
                            Console.WriteLine("Your goal list is empty.");
                        }
                        else
                        {
                            Console.WriteLine("\nYour Goals:");
                            for (int i = 0; i < todoList.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {todoList[i]}");
                            }

                            Console.Write("Enter the number of the goal to remove: ");
                            if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber > 0 && goalNumber <= todoList.Count)
                            {
                                Console.WriteLine($"Goal '{todoList[goalNumber - 1]}' removed successfully!");
                                todoList.RemoveAt(goalNumber - 1);
                            }
                            else
                            {
                                Console.WriteLine("Invalid number. Please try again.");
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("Thank you for using the Goal Tackler Todo List. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}

