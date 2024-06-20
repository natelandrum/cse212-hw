public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();

        // Test Cases

        // Test 1
        // Scenario: Create an empty queue.
        // Run 1 time.
        // Expected Result: The queue is empty.
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and priorities: Bob (1), Tim (5), Jane (3), Sue (5)
        // Run 4 times.
        // Expected Result: Tim, Sue, Jane, Bob
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Jane", 3);
        priorityQueue.Enqueue("Sue", 5);
        
        for (int i = 0; i < 4; i++)
            Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: Person with the highest priority is not being dequeued.
        //                  Person with the highest priority is not being removed from the queue.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and priorities: Bob (1), Tim (2), Jane (5)
        // After running 2 times, add Sue (1).
        // Run 4 times.
        // Expected Result: Jane, Tim, Bob, Sue
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Jane", 5);
        for (int i = 0; i < 2; i++)
            Console.WriteLine(priorityQueue.Dequeue());
        
        priorityQueue.Enqueue("Sue", 1);
        for (int i = 0; i < 2; i++)
            Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: Person with the highest priority is not being dequeued until after adding another person. (Problem with the index of the person with the highest priority.)
        //                  Person with the highest priority is not being removed from the queue.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Create a queue with the following people and priorities: Bob (7), Tim (2), Jane (3)
        // Run 3 times.
        // Expected Result: Bob, Jane, Tim
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 7);
        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Jane", 3);
        for (int i = 0; i < 3; i++)
            Console.WriteLine(priorityQueue.Dequeue());
        
        // Defect(s) Found: Person with the highest priority is not being dequeued.

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Create a queue with the following people and priorities: Bob (1), Tim (2), Jane (3)
        // Run 4 times.
        // Expected Result: Tim, Jane, Bob, The queue is empty.
        Console.WriteLine("Test 5");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 6);
        priorityQueue.Enqueue("Jane", 5);
        for (int i = 0; i < 4; i++)
            Console.WriteLine(priorityQueue.Dequeue());
        
        // Defect(s) Found: Person with the highest priority is not being dequeued.

        Console.WriteLine("---------");
    }
}