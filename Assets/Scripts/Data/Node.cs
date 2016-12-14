using System.Collections.Generic;

public class Node <T> {
	public T data;
	public Node<T> parent;
	public List<Node<T>> children;
}

