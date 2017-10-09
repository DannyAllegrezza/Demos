# Hash Table Overview
A hash table is a data structure which allows for unique association of data by means of key/value pairs through associative arrays. Associative arrays provide the storage of key/value pairs in an array or array-like collection.

* Generally, keys are unique
* When we add an item, we need to find the index of where to place the item into the array.


```csharp
// Store Person based on their Name property
var Person = new Person("Danny");
int index = GetIndex(Person.Name);
_array[index] = Person;
```

Behind the scenes, most associative arrays use hash tables. To understand this, we need to make sure we understanding hashing.

## Hashing Overview
Hashing derives a fixed size results from an input.
The hashing algorithm should consider:

### Stability
The same input generates the same output every time

### Uniform
The hash value should be uniformly distributed through available space

### Efficient
The cost of generating a hash must be balanced with the app needs

### Secure
The hash should be one-way (not invertible). You shouldn't be able to take a hash function and reverse it.

## Hashing Functions
* Pick the right hash for the job at hand, consider the above items. 
* MD5 is a good choice if security isn't a concern. 
* SHA-2 is a good choice if you need security and aren't too worried about efficiency. 

## Adding Values
```
// Get the array size
int arrayLength = 10;
// hashcode for the string "Danny"
int hashCode = GetHashCode(Person.Name);
// get index of where we should insert value into the array
int index = hashCode % arrayLength;
_array[index] = Person;
```

When adding items, we know that collisions can occur. There are many ways to deal with this but two common ways are 

Let's assume we are trying to add an item to index 3, which already has a value in it...

1. Open Addressing
	* Moving to the next index in the table. 
	* [_, _, _, 3, _] try to add the value "5"
	* [_, _, _, 3, 5]
2. Chaining
	* Store items in a LinkedList
	* [_, _, _, 3, _] try to add the value "5"
	* [_, _, _, 3 -> 5, _]

# Growing the Collection
Load factor: the ratio of filled hash table array slots to empty slots. This is also known as the fill factor.

We can set an arbitrary load factor, and once we hit it, we can grow the collection.

```csharp
if(fillFactor >= maxFillFactor){
	// grow the array!

	var newArray = newArray[_array.Length * 2];
	foreach (item in _array){
		AddItemToHashTable(newArray, item);
	}
	_array = newArray;
}

AddItemToHashTable(_array, item);
```

## Removing Items
We can remove items by key. Using `Chaining`, we get the index of the key, then search the linked list for the item, and remove it when found.

## Finding Items
Similar to removing items:

`Person p = HashTable.Find("Danny");`

Chaining: 
1. Get the index of the key
2. Iterate over the LinkedList and look for `"Danny"`.

## Enumerating Keys and Values
For Open Addressing:
```
foreach(item in _array){
	if(item !=null){
		return item;
	}
}
```
Chaining:
```
foreach(list in _array){
	if(list !=null){
		foreach (item in list){
			return item;
		}
	}
}
```
