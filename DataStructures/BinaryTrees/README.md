# Trees
A tree is a node-chain based data structure, represented in a hierarchical manner, as opposed to a linear manner (ex: `ArrayList`).


# Inserting data into the Tree
Trees lend themselves well to recursive algorithms. 

* http://btechsmartclass.com/DS/U5_T1.html

## Tree Traversals
So, how do we traverse through the tree? There are a few different ways to do this. We want to make sure we enumerate the nodes in a well defined order.

### Basic Algorithm
* Process the node..
* Visit Left
* Visit Right

The order in which we complete these 3 steps is what varies between the different ways to traverse the tree.

1. Pre-Order
2. In-Order
3. Post-Order

### Pre-Order Traversal
Some psuedo-code:

```
Visit(Node current){
    if (current == null){
        return;
    }
    Process(current.Value);
    Visit(current.Left);
    Visit(current.Right);
}
```

### In-Order Traversal
Commonly used when you want to look at the items in sort order.. 

```
Visit(Node current){
    if (current == null){
        return;
    }
    Visit(current.Left);
    Process(current.Value);
    Visit(current.Right);
}
```

### Post-Order Traversal

```
Visit(Node current){
    if (current == null){
        return;
    }
    Visit(current.Left);
    Visit(current.Right);
    Process(current.Value);
}
```
