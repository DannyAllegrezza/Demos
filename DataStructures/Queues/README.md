# Queues
A queue is a first in, first out (`FIFO`) collection, in contrast to the `LIFO` nature of a Stack. The queue is great in situations where we need to keep track of items based on the order which they enter the queue. With a few tweaks, we can create a priority queue, which keeps items in order based on an arbitrary value that represents their priority.

### Abstract
An easy abstract example is to imagine a line to checkout at a grocery store. Customers are checked out in the order in which they arrive. This is the key concept behind a queue, items are stored or operated on based in arrival. Back to our grocery store example, the first person in line is the first person to check out.

### `Enqueue(T item)`: Adding items to the Queue 
Items are added to the queue through a method which is generally known as `Enqueue`. 

### `Dequeue()`: Removing items from the Queue
Items are removed from the queue based on when they arrived. So, if you have 3 items in the queue, which arrived in the following order:

```
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);

myQueue's Order:

HEAD [1, 2, 3] TAIL
```

They would dequeue in the following order: `1, 2, 3`

### Peeking
We can peek at the first item in the queue, which will give us the value of the item at the front of the queue without actually removing it from the queue.

## Implementations
Commonly, queues are backed by either a LinkedList or an Array. The array allows for better performance but also has a bit more complex implementation code, as we have to handle re-allocations of memory and the array wrapping as it runs out.
