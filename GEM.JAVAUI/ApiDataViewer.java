import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.io.IOException;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.Scanner;
import org.json.JSONObject;

public class ApiDataViewer {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(ApiDataViewer::createAndShowGUI);
    }

    private static void createAndShowGUI() {
        JFrame frame = new JFrame("API Data Viewer");
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(600, 300);

        String[] columnNames = {"Key", "Value"};
        DefaultTableModel tableModel = new DefaultTableModel(columnNames, 0);
        JTable table = new JTable(tableModel);
        JScrollPane scrollPane = new JScrollPane(table);
        frame.add(scrollPane, BorderLayout.CENTER);

        JButton fetchButton = new JButton("Fetch API Data");
        fetchButton.addActionListener(e -> fetchData(tableModel));
        frame.add(fetchButton, BorderLayout.SOUTH);

        frame.setVisible(true);
    }

    private static void fetchData(DefaultTableModel tableModel) {
        String apiUrl = "http://localhost:5033/api/Gvendor";

        try {
            URL url = new URL(apiUrl);
            HttpURLConnection conn = (HttpURLConnection) url.openConnection();
            conn.setRequestMethod("GET");
            conn.setRequestProperty("Accept", "application/json");

            if (conn.getResponseCode() == 200) {
                Scanner scanner = new Scanner(url.openStream());
                StringBuilder jsonStr = new StringBuilder();
                while (scanner.hasNext()) {
                    jsonStr.append(scanner.nextLine());
                }
                scanner.close();

                // Parse JSON and display it in the table
                JSONObject jsonObject = new JSONObject(jsonStr.toString());
                tableModel.setRowCount(0); // Clear previous data
                for (String key : jsonObject.keySet()) {
                    tableModel.addRow(new Object[]{key, jsonObject.get(key).toString()});
                }
            } else {
                JOptionPane.showMessageDialog(null, "Failed to fetch data: HTTP " + conn.getResponseCode());
            }
        } catch (IOException e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
        }
    }
}
