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

### Operations
* Add
* Remove
* Find
* Enumerate

## Add to the Front
