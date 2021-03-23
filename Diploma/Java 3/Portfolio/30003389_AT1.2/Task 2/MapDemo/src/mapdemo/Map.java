/*
 * Kyer Potts
 * 30003389
 */
package mapdemo;

public class Map<K, V> {
    private final K k;
    private final V v;
    
    public Map(K k, V v){
        this.k = k;
        this.v = v;
    }
    
    public String toString(){
        return String.format("KEY: " + k + " VALUE: " + v + "\n");
    }
}
