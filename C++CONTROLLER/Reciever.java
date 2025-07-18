import java.io.*;
import java.net.*;

public class Receiver {
    public static void main(String[] args) {
        try (ServerSocket serverSocket = new ServerSocket(5000)) {
            System.out.println("Server is listening on port 5000");
            while (true) {
                Socket socket = serverSocket.accept();
                InputStream input = socket.getInputStream();
                BufferedReader reader = new BufferedReader(new InputStreamReader(input));
                String message = reader.readLine();
                System.out.println("Received: " + message);
                socket.close();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

