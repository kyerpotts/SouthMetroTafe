/*
 * Kyer Potts
 * 30003389
 */
package linkedlist;

public class LinkedList {
    Node head; //hed of list
    
    /* Node Class */
    class Node {
        int data;
        Node next;
        //Constructor to create a new node
        Node(int d) {data = d; next = null;}
    }
    
    public void push(int new_data){
        //Allocate the node and place data
        Node new_node = new Node(new_data);
        //Define the new node as head
        new_node.next = head;
        //Move the head to point to new Node
        head = new_node;
    }
    
    public void append(int new_data){
        //Allocate the node and place data, then set next as null
        Node new_node = new Node(new_data);
        //Determine if the LinkedList is empty, if true then set the new node as head
        if(head == null){
            head = new Node(new_data);
            return;
        }
        //Set the new node next as null as it will be inserted as the final spot in the LinkedList
        new_node.next = null;
        //Traverse the structure until the last node
        Node last = head;
        while (last.next !=null){
            last = last.next;
        }
        //Change the next of the last node
        last.next = new_node;
        return;
    }
}
