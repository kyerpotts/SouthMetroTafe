/*  
    Kyer Potts
    30003389
*/
import java.rmi.AlreadyBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.Registry;
import java.rmi.registry.LocateRegistry;
import java.rmi.server.UnicastRemoteObject;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class RmiServer implements DateAndTime {
    public RmiServer() {}

    @Override
    public String sayDateAndTime() {
        LocalDateTime date = LocalDateTime.now();
        
        DateTimeFormatter format = DateTimeFormatter.ofPattern("dd-MM-yyyy HH:mm:ss");

        String fDate = date.format(format);
        return fDate;
        
    }

    public static void main(String[] args) throws Exception {
        try {
            RmiServer obj = new RmiServer();
            DateAndTime stub = (DateAndTime) UnicastRemoteObject.exportObject(obj, 0);

            Registry registry = LocateRegistry.getRegistry();
            registry.bind("DateAndTime", stub);
            System.err.println("Server ready");
        } catch (RemoteException | AlreadyBoundException ex) {
            System.err.println("Server Exception: " + ex.toString());
        }
    }
}