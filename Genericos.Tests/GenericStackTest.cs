namespace Genericos.Tests;

using System;
using Xunit;

public class GenericStackTests
{
    [Fact]
    public void Push_PopSingleElement_ShouldReturnElement()
    {
        // Arrange
        GenericStack<int> stack = new GenericStack<int>();

        // Act
        stack.Push(42);
        int poppedElement = stack.Pop();

        // Assert
        Assert.Equal(42, poppedElement);
    }

    [Fact]
    public void Push_PopMultipleElements_ShouldReturnInLIFOOrder()
    {
        // Arrange
        GenericStack<string> stack = new GenericStack<string>();

        // Act
        stack.Push("first");
        stack.Push("second");
        stack.Push("third");

        // Assert
        Assert.Equal("third", stack.Pop());
        Assert.Equal("second", stack.Pop());
        Assert.Equal("first", stack.Pop());
    }

    [Fact]
    public void Peek_ShouldNotRemoveElementFromStack()
    {
        // Arrange
        GenericStack<double> stack = new GenericStack<double>();

        // Act
        stack.Push(3.14);
        stack.Push(2.71);
        double peekedElement = stack.Peek();

        // Assert
        Assert.Equal(2.71, peekedElement);
        Assert.Equal(2, stack.Count); // Count should not change after peek
    }

    [Fact]
    public void Pop_EmptyStack_ShouldThrowInvalidOperationException()
    {
        // Arrange
        GenericStack<char> stack = new GenericStack<char>();

        // Act + Assert
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Peek_EmptyStack_ShouldThrowInvalidOperationException()
    {
        // Arrange
        GenericStack<bool> stack = new GenericStack<bool>();

        // Act + Assert
        Assert.Throws<InvalidOperationException>(() => stack.Peek());
    }

    [Fact]
    public void Count_ShouldReturnNumberOfElementsInStack()
    {
        // Arrange
        GenericStack<int> stack = new GenericStack<int>();

        // Act
        stack.Push(5);
        stack.Push(10);

        // Assert
        Assert.Equal(2, stack.Count);
    }
}