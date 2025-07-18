import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;

public class ApiGuiApp extends JFrame {
    private JTextArea outputArea;

    public ApiGuiApp() {
        setTitle("API Menu");
        setSize(500, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());

        outputArea = new JTextArea(10, 40);
        outputArea.setEditable(false);
        add(new JScrollPane(outputArea));

        JButton fetchGappButton = new JButton("Fetch /api/Gapp");
        JButton fetchGvendorButton = new JButton("Fetch /api/Gvendor");
        JButton fetchGgridsButton = new JButton("Fetch /api/Ggrids");
        JButton addNewAppButton = new JButton("Add New App");

        add(fetchGappButton);
        add(fetchGvendorButton);
        add(fetchGgridsButton);
        add(addNewAppButton);

        // Button actions
        fetchGappButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Gapp"));
        fetchGvendorButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Gvendor"));
        fetchGgridsButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Ggrid"));
        addNewAppButton.addActionListener(e -> addNewApp());

        setVisible(true);
    }

    private void fetchApiData(String apiUrl) {
        try {
            URL url = new URL(apiUrl);
            HttpURLConnection connection = (HttpURLConnection) url.openConnection();
            connection.setRequestMethod("GET");
            connection.setRequestProperty("Accept", "application/json");

            int responseCode = connection.getResponseCode();
            if (responseCode == 200) {
                Scanner reader = new Scanner(connection.getInputStream()).useDelimiter("\\A");
                String response = reader.hasNext() ? reader.next() : "";
                reader.close();
                outputArea.setText("Response:\n" + response);
            } else {
                outputArea.setText("Failed to fetch API data. Response Code: " + responseCode);
            }

            connection.disconnect();
        } catch (Exception e) {
            outputArea.setText("Error fetching API data: " + e.getMessage());
        }
    }

    private void addNewApp() {
        JTextField appDescriptionField = new JTextField();
        JTextField appTypeField = new JTextField();
        JTextField appRegionField = new JTextField();
        JTextField dbmsTypeField = new JTextField();
        JTextField dbmsVendorField = new JTextField();
        JTextField dbmsTopologyField = new JTextField();
        JTextField gridIdField = new JTextField();

        Object[] message = {
                "App Description:", appDescriptionField,
                "App Type:", appTypeField,
                "App Region:", appRegionField,
                "DBMS Type:", dbmsTypeField,
                "DBMS Vendor:", dbmsVendorField,
                "DBMS Topology:", dbmsTopologyField,
                "Grid ID:", gridIdField
        };

        int option = JOptionPane.showConfirmDialog(null, message, "Add New App", JOptionPane.OK_CANCEL_OPTION);
        if (option == JOptionPane.OK_OPTION) {
            try {
                String jsonPayload = String.format(
                    "{\"appid\":null, \"appdescription\":\"%s\", \"apptype\":\"%s\", \"appregion\":\"%s\", \"dbmstype\":\"%s\", \"dbmsvendor\":\"%s\", \"dbmstopology\":\"%s\", \"gridid\":%d}",
                    appDescriptionField.getText(), appTypeField.getText(), appRegionField.getText(),
                    dbmsTypeField.getText(), dbmsVendorField.getText(), dbmsTopologyField.getText(),
                    Integer.parseInt(gridIdField.getText()));

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
                    outputArea.setText("Successfully added app to the grid!");
                } else {
                    outputArea.setText("Failed to add app. Response Code: " + responseCode);
                }

                connection.disconnect();
            } catch (Exception e) {
                outputArea.setText("Error adding app: " + e.getMessage());
            }
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(ApiGuiApp::new);
    }
}

