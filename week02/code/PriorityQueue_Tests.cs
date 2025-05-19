using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test if FIFO behaviour works with, enqueue and dequeueing the highest priority item 
    // Expected Result: Item1
    // Defect(s) Found:  Assert.Fail failed. Implement the test case and then remove this.
    public void TestPriorityQueue_ReturnsHighestPriority()
    {

        var item1 = new PriorityItem("item1", 2);
        var item2 = new PriorityItem("item2", 9);
        var item3 = new PriorityItem("item3", 5);

        PriorityItem expectedResult = item1;

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);

        if (priorityQueue == null)
        {
            Assert.Fail("Priority queue is empty");
        }

        var item = priorityQueue.Dequeue();

        Assert.AreEqual(item2.Value, item);
    }

    [TestMethod]
    // Scenario: If their are multiple items with the same priority, get the closest 
    //           item to the queue.
    // Expected Result: item 3
    // Defect(s) Found: 
    public void TestPriorityQueue_MultipleSamePriorityItems()
    {
        var item1 = new PriorityItem("item1", 1);
        var item2 = new PriorityItem("item2", 2);
        var item3 = new PriorityItem("item3", 4);
        var item4 = new PriorityItem("item4", 3);
        var item5 = new PriorityItem("item5", 4);
        var item6 = new PriorityItem("item6", 4);

        PriorityItem expectedResult = item3;

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(item1.Value, item1.Priority);
        priorityQueue.Enqueue(item2.Value, item2.Priority);
        priorityQueue.Enqueue(item3.Value, item3.Priority);
        priorityQueue.Enqueue(item4.Value, item4.Priority);
        priorityQueue.Enqueue(item5.Value, item5.Priority);
        priorityQueue.Enqueue(item6.Value, item6.Priority);


        if (priorityQueue == null)
        {
            Assert.Fail("Priority queue is empty");
        }

        var item = priorityQueue.Dequeue();

        Assert.AreEqual(expectedResult.Value, item);
    }


}