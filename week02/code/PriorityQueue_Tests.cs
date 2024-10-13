using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
  [TestMethod]
  // Scenario: 
  // Expected Result: 
  // Defect(s) Found: 
  public void TestPriorityQueue_1()
  {
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("low", 1);
    priorityQueue.Enqueue("medium", 5);
    priorityQueue.Enqueue("high", 10);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("high", result);
  }

  [TestMethod]
  // Scenario: 
  // Expected Result: 
  // Defect(s) Found: 
  public void TestPriorityQueue_2()
  {
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("first", 10);
    priorityQueue.Enqueue("second", 10);

    var result = priorityQueue.Dequeue();

    Assert.AreEqual("first", result);
  }

  [TestMethod]
  // Scenario: 
  // Expected Result: 
  // Defect(s) Found: 
  public void TestPriorityQueue_3()
  {
    var priorityQueue = new PriorityQueue();

    Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
  }

}