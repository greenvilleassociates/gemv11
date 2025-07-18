import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.net.HttpURLConnection;
import java.net.URL;

public class ApiCaller {
    public static void main(String[] args) {
        try {
            String apiUrl = "http://localhost:5033/api/Gvendor";
            URL url = new URL(apiUrl);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            
            connection.setRequestMethod("GET");
            connection.setRequestProperty("Accept", "application/json");
            
            int responseCode = connection.getResponseCode();
            if (responseCode == 200) { // Success
                BufferedReader reader = new BufferedReader(new InputStreamReader(connection.getInputStream()));
                StringBuilder response = new StringBuilder();
                String line;
                while ((line = reader.readLine()) != null) {
                    response.append(line);
                }
                reader.close();
                
                System.out.println("Response from API:");
                System.out.println(response.toString());
            } else {
                System.out.println("Failed to call API. Response Code: " + responseCode);
            }
            
            connection.disconnect();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}

