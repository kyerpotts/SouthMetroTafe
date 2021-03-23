/*  
    Kyer Potts
    30003389
*/
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class RmiClient {
    public static void main(String[] args) throws Exception {
        String host = (args.length < 1) ? null : args[0];

        try {
            Registry registry = LocateRegistry.getRegistry(host);
            DateAndTime stub = (DateAndTime) registry.lookup("DateAndTime");
            String response = stub.sayDateAndTime();
            System.out.println("Current Date & Time: " + response);
        } catch (RemoteException | NotBoundException ex) {
            System.err.println("Client Exception: " + ex.toString());
        }
    }
}