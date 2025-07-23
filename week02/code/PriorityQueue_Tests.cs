using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario:Create a queue with the following people and priorities: Nephi (2), Alma (3), Jacob (1), Enos (6)
    // Expected Result: Enos
    // Defect(s) Found: 
    //Assert.AreEqual failed. Expected Enos. Actual Alma
    //The loop was excluding the last item(index < _queue.Count - 1), so in this case Enos was ignored when checking for the highest priority.
    //solution: Remove -1 from the condition index < _queue.Count - 1 on Dequeue function
    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Nefi", 2);
        priorityQueue.Enqueue("Alma", 3);
        priorityQueue.Enqueue("Jacob", 1);
        priorityQueue.Enqueue("Enos", 6);
        var Result = priorityQueue.Dequeue();
        Assert.AreEqual("Enos", Result);
    }

    [TestMethod]
    // Scenario:Create a queue with the following people and priorities:
    //  Nephi (2), Alma (3),Mosiah (3) Jacob (3), Enos (1)
    // Expected Result: Alma
    // Defect(s) Found: 
    //Assert.AreEqual failed. Expected: Alma. Actual:Jacob
    //Soluction: Replaced '>=' with '>' to ensure the first person with the highest priority is selected,
    //rather than the last one as the error  show.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Nephi", 2);
        priorityQueue.Enqueue("Alma", 3);
        priorityQueue.Enqueue("Mosiah", 3);
        priorityQueue.Enqueue("Enos", 1);
        priorityQueue.Enqueue("Jacob", 3);

        var Result = priorityQueue.Dequeue();
        Assert.AreEqual("Alma", Result);
    }

    // Add more test cases as needed below.
    //test methot that fails according to the grader
    // Failed TestPriorityQueue_DequeueHighestPriorityAtFront [3 ms]
    //Failed TestPriorityQueue_DequeueHighestPriorityAtMiddle
    // Failed TestPriorityQueue_DequeueHighestPriorityAtBack 
    // TestPriorityQueue_DequeueEqualPriority 
}