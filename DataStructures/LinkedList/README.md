# Linked List
A linked list is a data structure used to store 

## Components
The linked list data structure is composed of nodes and node chains.

### The Node
The node itself is one of the most common data structures in CS. It provides a container for a piece of data and one (or many) object reference pointers to the next node.

We can visualize it as such:

`[[ 2 ] [ Next ]]`

In C#, we could represent this as such:

```
public class Node
{
	public int Value { get; set; }
	public Node Next { get; set; }
}
```

#### Node Chains
Currently, this node has no reference to any other nodes. What if we wanted to chain this node to another node?

`[[ 2 ] [ Next ]] --> [[ 5 ] [ Next ]]`

```
Node first = new Node { Value = 3 };
Node middle = new Node { Value = 5 };
first.Next = middle;
```

This process of linking nodes is called `chaining`.

## Progressing to Linked List
A linked list is a data structure that represents a single chain of nodes.

* The linked list has a well defined starting point, the `Head` which provides a pointer to the first Node in the list.
* The last node is represented by the `Tail` pointer

### Pros
* Inserting and deleting: O(1)
* Sequential Access: O(N)

>Inserting and deleting operations refers to the operation itself, as you might need to sequentially access all the nodes until the node you’are looking for.
> Inserting and deleting is much easier with doubly linked list.

### Cons
* No Direct Access; Only Sequential Access
* Searching: O(N)
* Sorting: O(NLogN)


A simple implementation would look contain a `LinkedList` class, which would be comprised of `LinkedListNodes`.

```
public class LinkedList<T>
{
	public LinkedListNode Head { get; private set; }
	public LinkedListNode Tail { get; private set; }
	// Add methods
	// Remove
	...
}

public class LinkedListNode<T>
{
	public T Value { get; set; }
	// Pointer to the next node in the chain
	public LinkedListNode<T> Next { get; set; }
}
```

### Operations
* Add
* Remove
* Find
* Enumerate

## Add to the Front
The most basic operation is adding an item to the LinkedList.

Let's assume we are creating a new LinkedList.

`var myList = new LinkedList<int>();`

This created a new LinkedList whose `Head` and `Tail` pointers are null. Let's add a new node storing the value `3`.

`myList.AddValue(3)`

Now `myList` has 1 item, so both the `Head` and `Tail` pointers refer to that one item. We have started the chain!

`myList.AddValue(5)`

LinkedList.Head = 5 `[5 | TAIL = 3]`
LinkedList.Tail = 3 `[3 | TAIL = NULL]`

## Add to the End
This is much easier given we keep track of the Tail pointer. We can set the current Tail's `Next` pointer to the new node being added, then we set the `Tail = newNode`

## Removing from the End
To remove the last node in the chain, we need to do the following

```
// if (Count == 1) then set Head and Tail to null
// otherwise, grab the Head and iterate over the chain (while current.Next != Tail)
// when we reach the last node before the Tail, we just set that nodes Next value to null, effectively removing the last Node
// Set the Tail to this node and decrement the total Count

```
The problem here is iterating over the entire list.

## Removing from the Front
To remove the first node in the LinkedList, we can simple set the `Head` node to the `Head.Next`. If the LinkedList only contains 1 node then we simply set the `Head` and `Tail` node to null.