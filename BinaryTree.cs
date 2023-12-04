using System.Collections;

namespace Tree
{
    public class BinaryTree<D>(Node<D> Master) : IEnumerable<Node<D>> where D : IComparable
    {
        Node<D> Root {get;} = Master;
		public void Append(D Value){
			var current = Root;
			var target = new Node<D>(Value);
			var parrent = current;
			while(current != null){
				parrent = current;
				current = target < current ? current.Left : current.Right;
			}
			if(target < parrent) parrent.Left = target;
			else if(target > parrent) parrent.Right = target;
		}
		public void Append(D[] Values){
			foreach(var value in Values.Distinct()) Append(value);
		}
		public void Print(){
			foreach(var node in this) Console.Write(node.Value + " ");
			Console.WriteLine(".");
		}
		public IEnumerator<Node<D>> GetEnumerator()
		{
			// Go through algorythm; (Broadth First Search)
			var visited = new List<D>();
			var queue = new Queue<Node<D>>();
			queue.Enqueue(Root);


			while(queue.Count != 0){
				var current = queue.Dequeue();
				if(current == null) yield break;
				if(!visited.Contains(current.Value)){
					visited.Add(current.Value);
					yield return current;
					if (current.Left != null) queue.Enqueue(current.Left);
					if (current.Right != null) queue.Enqueue(current.Right);
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}