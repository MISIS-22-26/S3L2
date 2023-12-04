namespace Tree{
	public class Program {
		static void Main(){
			
			int[] testing_list = {226, 53, 226, 333, 335, 333};
			var tree = new BinaryTree<int>(new(226));
			tree.Append(testing_list);
			tree.Print();
			var target = 53;
			Console.WriteLine(target + " Node Existance = " + tree.Contains(target) +".");
			target = 20;
			Console.WriteLine(target + " Node Existance = " + tree.Contains(target) +".");
		}
	}
}