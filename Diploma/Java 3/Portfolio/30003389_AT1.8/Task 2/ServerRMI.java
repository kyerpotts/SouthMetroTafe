/*  
    Kyer Potts
    30003389
*/
import java.rmi.AlreadyBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.Registry;
import java.rmi.registry.LocateRegistry;
import java.rmi.server.UnicastRemoteObject;

public class ServerRMI implements HelloRMI {
    public ServerRMI() {}

    @Override
    public String sayHello() {
        return "Hello from the server!";
    }

    public static void main(String[] args) throws Exception {
        try {
            ServerRMI obj = new ServerRMI();
            HelloRMI stub = (HelloRMI) UnicastRemoteObject.exportObject(obj, 0);

            Registry registry = LocateRegistry.getRegistry();
            registry.bind("Hello", stub);
            System.err.println("Server ready");
        } catch (RemoteException | AlreadyBoundException ex) {
            System.err.println("Server Exception: " + ex.toString());
        }
    }
}