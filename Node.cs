using System.Runtime.ExceptionServices;

namespace prove_09;

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
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if(Data == value){
            return true;
        }else if(value < Data){
            if(Left is not null){return Left.Contains(value);} else {return false;}
        }else if(value > Data){
            if(Right is not null){return Right.Contains(value);} else {return false;}
        }else{
            return false;
        }
    }

    public int GetHeight() {
        var height = 1;
        var sumRight = 0;
        var sumLeft = 0;
        if(Right is not null)
            sumRight =+ Right.GetHeight();//recusivly counts down each path
        if(Left is not null)
            sumLeft += Left.GetHeight(); //recusivly counts down each path
        height = sumRight > sumLeft ? sumRight : sumLeft; //picks which path was longer
        height +=1; //adds 1 for the current node
        return height; //sends the higher heigt back up the recursion
    }
}