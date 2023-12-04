namespace Tree
{
    public class Node<D>(D Value, Node<D>? Left = null, Node<D>? Right = null) : IComparable<Node<D>> where D : IComparable
    {
        public D Value { get; } = Value;
		public Node<D>? Left { get; set;} = Left;
		public Node<D>? Right { get; set; } = Right;
		public int CompareTo(Node<D>? other) => Value.CompareTo(other!.Value);
		public static bool operator < (Node<D> node_1, Node<D> node_2) => node_1.Value.CompareTo(node_2.Value) < 0;
		public static bool operator > (Node<D> node_1, Node<D> node_2) => node_1.Value.CompareTo(node_2.Value) > 0;
	}
}