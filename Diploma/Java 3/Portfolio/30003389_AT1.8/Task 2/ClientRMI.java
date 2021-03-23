/*  
    Kyer Potts
    30003389
*/
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class ClientRMI {
    public static void main(String[] args) throws Exception {
        String host = (args.length < 1) ? null : args[0];

        try {
            Registry registry = LocateRegistry.getRegistry(host);
            HelloRMI stub = (HelloRMI) registry.lookup("Hello");
            String response = stub.sayHello();
            System.out.println("Response: " + response);
        } catch (RemoteException | NotBoundException e) {
            System.err.println("Client Exception: " + e.toString());
        }
    }
}