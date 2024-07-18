public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);

            else if (Left.Data != value)
                Left.Insert(value);
        }

        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);

            else if (Right.Data != value)
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value == Data) return true;

        else if (value < Data && Left != null) 
            return Left.Contains(value);

        else if (value > Data && Right != null) 
            return Right.Contains(value);

        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        return 1 + Math.Max(Left?.GetHeight() ?? 0, Right?.GetHeight() ?? 0);
    }
}