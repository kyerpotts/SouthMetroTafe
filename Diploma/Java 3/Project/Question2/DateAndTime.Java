/*  
    Kyer Potts
    30003389
*/
import java.rmi.Remote;
import java.rmi.RemoteException;
import java.time.LocalDateTime;

public interface DateAndTime extends Remote {
        String sayDateAndTime() throws RemoteException;
    }