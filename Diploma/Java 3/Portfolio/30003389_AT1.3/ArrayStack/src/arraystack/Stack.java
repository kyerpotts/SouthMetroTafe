/*
 * Kyer Potts
 * 30003389
 */
package arraystack;

public class Stack<T> {
    
    private int maxsize;
    private int top;
    private T[] items;

    public Stack(int maxsize) {
        if (maxsize <= 0) {
            throw new ArrayStackException(
                    "Stack size must be positive");
        }
        items = (T[]) new Object[maxsize];
        this.maxsize = maxsize;
        top = 0;
    }

    public void push(T item) {
        if (top == items.length) {
            throw new ArrayStackException("Overflow Error");
        }
        items[top] = item;
        top++;
    }

    public T pop() {
        if (isEmpty()) {
            throw new ArrayStackException("Underflow Error");
        }
        return items[--top];
    }

    public boolean isEmpty() {
        return (top == 0);
    }

    public static class ArrayStackException extends RuntimeException {

        public ArrayStackException(String message) {
            super(message);
        }

    }
}
