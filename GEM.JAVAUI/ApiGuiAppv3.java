import javax.swing.*;
import java.awt.*;
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
        JButton updateAppButton = new JButton("Update an Application");

        add(fetchGappButton);
        add(fetchGvendorButton);
        add(fetchGgridsButton);
        add(addNewAppButton);
        add(updateAppButton);

        // Button actions
        fetchGappButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Gapp"));
        fetchGvendorButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Gvendor"));
        fetchGgridsButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Ggrids"));
        addNewAppButton.addActionListener(e -> addNewApp());
        updateAppButton.addActionListener(e -> updateApplication());

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

        // Dropdown for GridID selection
        String[] gridOptions = {"1 - North America", "2 - Campus", "3 - HiLine", "4 - EurAmerica"};
        JComboBox<String> gridIdComboBox = new JComboBox<>(gridOptions);

        Object[] message = {
                "App Description:", appDescriptionField,
                "App Type:", appTypeField,
                "App Region:", appRegionField,
                "DBMS Type:", dbmsTypeField,
                "DBMS Vendor:", dbmsVendorField,
                "DBMS Topology:", dbmsTopologyField,
                "Grid ID:", gridIdComboBox // Drop-down instead of text field
        };

        int option = JOptionPane.showConfirmDialog(null, message, "Add New App", JOptionPane.OK_CANCEL_OPTION);
        if (option == JOptionPane.OK_OPTION) {
            try {
                int gridId = gridIdComboBox.getSelectedIndex() + 1; // Dropdown index starts at 0

                String jsonPayload = String.format(
                        "{\"appid\":null, \"appdescription\":\"%s\", \"apptype\":\"%s\", \"appregion\":\"%s\", \"dbmstype\":\"%s\", \"dbmsvendor\":\"%s\", \"dbmstopology\":\"%s\", \"gridid\":%d}",
                        appDescriptionField.getText(), appTypeField.getText(), appRegionField.getText(),
                        dbmsTypeField.getText(), dbmsVendorField.getText(), dbmsTopologyField.getText(), gridId
                );

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
                outputArea.setText(responseCode == 201 || responseCode == 200
                        ? "Successfully added application to the grid!"
                        : "Failed to add application. Response Code: " + responseCode);

                connection.disconnect();
            } catch (Exception e) {
                outputArea.setText("Error adding application: " + e.getMessage());
            }
        }
    }

    private void updateApplication() {
        JTextField appIdField = new JTextField();
        JTextField appDescriptionField = new JTextField();
        JTextField appTypeField = new JTextField();
        JTextField appRegionField = new JTextField();
        JTextField dbmsTypeField = new JTextField();
        JTextField dbmsVendorField = new JTextField();
        JTextField dbmsTopologyField = new JTextField();

        String[] gridOptions = {"1 - North America", "2 - Campus", "3 - HiLine", "4 - EurAmerica"};
        JComboBox<String> gridIdComboBox = new JComboBox<>(gridOptions);

        Object[] message = {
                "Application ID:", appIdField,
                "App Description:", appDescriptionField,
                "App Type:", appTypeField,
                "App Region:", appRegionField,
                "DBMS Type:", dbmsTypeField,
                "DBMS Vendor:", dbmsVendorField,
                "DBMS Topology:", dbmsTopologyField,
                "Grid ID:", gridIdComboBox
        };

        int option = JOptionPane.showConfirmDialog(null, message, "Update Application", JOptionPane.OK_CANCEL_OPTION);
        if (option == JOptionPane.OK_OPTION) {
            try {
                int appId = Integer.parseInt(appIdField.getText());
                int gridId = gridIdComboBox.getSelectedIndex() + 1;

                String apiUrl = "http://localhost:5033/api/Gapp/" + appId;

                String jsonPayload = String.format(
                        "{\"appid\":%d, \"appdescription\":\"%s\", \"apptype\":\"%s\", \"appregion\":\"%s\", \"dbmstype\":\"%s\", \"dbmsvendor\":\"%s\", \"dbmstopology\":\"%s\", \"gridid\":%d}",
                        appId, appDescriptionField.getText(), appTypeField.getText(), appRegionField.getText(),
                        dbmsTypeField.getText(), dbmsVendorField.getText(), dbmsTopologyField.getText(), gridId
                );

                URL updateUrl = new URL(apiUrl);
                HttpURLConnection updateConnection = (HttpURLConnection) updateUrl.openConnection();
                updateConnection.setRequestMethod("PUT");
                updateConnection.setRequestProperty("Content-Type", "application/json");
                updateConnection.setDoOutput(true);

                try (OutputStream os = updateConnection.getOutputStream()) {
                    byte[] input = jsonPayload.getBytes("utf-8");
                    os.write(input, 0, input.length);
                }

                int responseCode = updateConnection.getResponseCode();
                outputArea.setText(responseCode == 200
                        ? "Application successfully updated!"
                        : "Failed to update application. Response Code: " + responseCode);

                updateConnection.disconnect();
            } catch (Exception e) {
                outputArea.setText("Error updating application: " + e.getMessage());
            }
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(ApiGuiApp::new);
    }
}
