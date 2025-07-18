import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;

public class ApiMenuWorking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("\nSelect an option:");
            System.out.println("1. Fetch /api/Gapp");
            System.out.println("2. Fetch /api/Gvendor");
            System.out.println("3. Fetch /api/Ggrids");
            System.out.println("4. Add a new app to the grid");
            System.out.println("5. Exit");
            System.out.print("Enter your choice: ");

            int choice = scanner.nextInt();
            scanner.nextLine(); // Consume newline

            if (choice == 5) {
                System.out.println("Exiting program...");
                break;
            }

            if (choice == 4) {
                addNewApp(scanner);
            } else {
                String apiUrl = getApiUrl(choice);
                if (apiUrl != null) {
                    fetchApiData(apiUrl);
                } else {
                    System.out.println("Invalid choice, please try again.");
                }
            }
        }

        scanner.close();
    }

    private static String getApiUrl(int choice) {
        switch (choice) {
            case 1: return "http://localhost:5033/api/Gapp";
            case 2: return "http://localhost:5033/api/Gvendor";
            case 3: return "http://localhost:5033/api/Ggrids";
            default: return null;
        }
    }

    private static void fetchApiData(String apiUrl) {
        try {
            URL url = new URL(apiUrl);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("GET");
            connection.setRequestProperty("Accept", "application/json");

            int responseCode = connection.getResponseCode();
            if (responseCode == 200) { // Success
                Scanner reader = new Scanner(connection.getInputStream()).useDelimiter("\\A");
                String response = reader.hasNext() ? reader.next() : "";
                reader.close();

                System.out.println("\nResponse from API:");
                System.out.println(response);
            } else {
                System.out.println("Failed to fetch API data. Response Code: " + responseCode);
            }

            connection.disconnect();
        } catch (Exception e) {
            System.out.println("Error fetching API data: " + e.getMessage());
        }
    }

    private static void addNewApp(Scanner scanner) {
        try {
            System.out.print("\nEnter app name: ");
            String appName = scanner.nextLine();
            
            System.out.print("Enter grid number: ");
            int gridNumber = scanner.nextInt();
            
            System.out.print("Enter number of nodes: ");
            int numNodes = scanner.nextInt();
            scanner.nextLine(); // Consume newline

            String jsonPayload = String.format("{\"appName\":\"%s\", \"gridNumber\":%d, \"numNodes\":%d}",
                                               appName, gridNumber, numNodes);

            URL url = new URL("http://localhost:5033/api/Gapp");
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("POST");
            connection.setRequestProperty("Content-Type", "application/json");
            connection.setDoOutput(true);

            try (OutputStream os = connection.getOutputStream()) {
                byte[] input = jsonPayload.getBytes("utf-8");
                os.write(input, 0, input.length);
            }

            int responseCode = connection.getResponseCode();
            if (responseCode == 201 || responseCode == 200) {
                System.out.println("Successfully added app to the grid!");
            } else {
                System.out.println("Failed to add app. Response Code: " + responseCode);
            }

            connection.disconnect();
        } catch (Exception e) {
            System.out.println("Error adding app: " + e.getMessage());
        }
    }
}

