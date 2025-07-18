import java.io.*;
import java.net.*;

public class Sender {
    public static void main(String[] args) {
        String hostname = "localhost";
        int port = 5000;
        try (Socket socket = new Socket(hostname, port)) {
            OutputStream output = socket.getOutputStream();
            PrintWriter writer = new PrintWriter(output, true);
            writer.println("Hello from the sender!");
            System.out.println("Message sent");
        } catch (UnknownHostException ex) {
            System.out.println("Server not found: " + ex.getMessage());
        } catch (IOException ex) {
            System.out.println("I/O error: " + ex.getMessage());
        }
    }
}

