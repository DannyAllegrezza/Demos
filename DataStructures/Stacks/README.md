# Stacks
A Stack is a last in, first out (LIFO) collection. The restaurant plate stacker is a really easy way to conceptualize the concept.

### Pushing Onto the Stack
Adding items to the stack is referred to as `pushing` items onto the stack.

### Popping Off of the Stack
Taking items off of the stack is referred to as `popping` an item off of the stack. The last item put into the stack is the first item to be removed off of the stack. (LIFO)

### Peeking
We can peek at the top of the stack, which will give us the value of the item on the top of the stack without actually removing it from the stack.

## Implementations
I'm implementing a Stack backed by a `LinkedList` and a plain old `array`.