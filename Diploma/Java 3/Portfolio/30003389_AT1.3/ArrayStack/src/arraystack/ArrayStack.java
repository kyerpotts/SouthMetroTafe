/*
 * Kyer Potts
 * 30003389
 */
package arraystack;

public class ArrayStack {

    public static void main(String[] args) {
        System.out.println("Stack 1");
        Stack stack1 = new Stack(3);
        stack1.push(1);
        stack1.push(2);
        stack1.push(3);
        //stack.push(4); //overflow error
        System.out.println(stack1.pop());
        System.out.println(stack1.pop());
        System.out.println(stack1.pop());
    }
    
}
