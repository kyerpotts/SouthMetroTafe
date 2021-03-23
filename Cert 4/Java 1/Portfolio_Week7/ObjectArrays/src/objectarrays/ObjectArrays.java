package objectarrays;

/**
 * 30003389 Kyer Potts
 */
public class ObjectArrays {

    public static void main(String[] args) {
        DisplayText[] objects = new DisplayText[5];

        for (int i = 0; i < objects.length; i++) {
            objects[i] = new DisplayText();
            System.out.println(objects[i].getDisplayText());
        }
    }

}
