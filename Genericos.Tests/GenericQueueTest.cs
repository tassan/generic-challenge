namespace Genericos.Tests;

public class GenericQueueTest
{
    [Fact]
    public void Enqueue_DequeueSingleElement_ShouldReturnElement()
    {
        // Arrange
        GenericQueue<int> queue = new GenericQueue<int>();

        // Act
        queue.Enqueue(42);
        int dequeuedElement = queue.Dequeue();

        // Assert
        Assert.Equal(42, dequeuedElement);
    }

    [Fact]
    public void Enqueue_DequeueMultipleElements_ShouldReturnInFIFOOrder()
    {
        // Arrange
        GenericQueue<string> queue = new GenericQueue<string>();

        // Act
        queue.Enqueue("first");
        queue.Enqueue("second");
        queue.Enqueue("third");

        // Assert
        Assert.Equal("first", queue.Dequeue());
        Assert.Equal("second", queue.Dequeue());
        Assert.Equal("third", queue.Dequeue());
    }

    [Fact]
    public void Dequeue_EmptyQueue_ShouldThrowInvalidOperationException()
    {
        // Arrange
        GenericQueue<char> queue = new GenericQueue<char>();

        // Act + Assert
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }
}