import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import java.awt.*;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;
import java.util.Scanner;

public class ApiGuiAppV4 extends JFrame {
    private JTextArea outputArea;

    public ApiGuiAppV4() {
        setTitle("API Menu");
        setSize(700, 500);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());

        outputArea = new JTextArea(15, 50);
        outputArea.setEditable(false);
        add(new JScrollPane(outputArea));

        JButton fetchGappButton = new JButton("Fetch /api/Gapp");
        JButton fetchGvendorButton = new JButton("Fetch /api/Gvendor");
        JButton fetchGgridButton = new JButton("Fetch /api/Ggrid");
        JButton addNewAppButton = new JButton("Add New Application");
        JButton updateAppButton = new JButton("Update an Application");

        add(fetchGappButton);
        add(fetchGvendorButton);
        add(fetchGgridButton);
        add(addNewAppButton);
        add(updateAppButton);

        // Button actions
        fetchGappButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Gapp"));
        fetchGvendorButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Gvendor"));
        fetchGgridButton.addActionListener(e -> fetchApiData("http://localhost:5033/api/Ggrid"));
        addNewAppButton.addActionListener(e -> addNewApp());
        updateAppButton.addActionListener(e -> updateApplication());

        setVisible(true);
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(ApiGuiAppV4::new);
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

                if (apiUrl.contains("Gvendor")) {
                    displayVendorDataInTable(response);
                } else if (apiUrl.contains("Ggrid")) {
                    displayGridDataInTable(response);
                } else {
                    displayDataInTable(response);
                }
            } else {
                outputArea.setText("Failed to fetch API data. Response Code: " + responseCode);
            }

            connection.disconnect();
        } catch (Exception e) {
            outputArea.setText("Error fetching API data: " + e.getMessage());
        }
    }

    private void displayDataInTable(String jsonResponse) {
        Gson gson = new Gson();
        List<AppRecord> records = gson.fromJson(jsonResponse, new TypeToken<List<AppRecord>>(){}.getType());

        String[] columnNames = {"ID", "App ID", "Description", "Type", "Region", "DBMS Type", "Vendor", "Topology", "Grid ID"};
        String[][] rowData = new String[records.size()][9];

        for (int i = 0; i < records.size(); i++) {
            AppRecord record = records.get(i);
            rowData[i][0] = String.valueOf(record.id);
            rowData[i][1] = record.appid;
            rowData[i][2] = record.appdescription;
            rowData[i][3] = record.apptype != null ? String.valueOf(record.apptype) : "N/A";
            rowData[i][4] = record.appregion != null ? String.valueOf(record.appregion) : "N/A";
            rowData[i][5] = record.dbmstype;
            rowData[i][6] = record.dbmsvendor;
            rowData[i][7] = record.dbmstopology;
            rowData[i][8] = record.gridid != null ? String.valueOf(record.gridid) : "N/A";
        }

        createTableView(rowData, columnNames, "Fetched Applications");
    }

    private void displayVendorDataInTable(String jsonResponse) {
        Gson gson = new Gson();
        List<VendorRecord> records = gson.fromJson(jsonResponse, new TypeToken<List<VendorRecord>>(){}.getType());

        String[] columnNames = {"ID", "Vendor ID", "Vendor Name", "Address 1", "Address 2", "City", "State", "Zip"};
        String[][] rowData = new String[records.size()][8];

        for (int i = 0; i < records.size(); i++) {
            VendorRecord record = records.get(i);
            rowData[i][0] = String.valueOf(record.id);
            rowData[i][1] = record.vendorid;
            rowData[i][2] = record.vendorname;
            rowData[i][3] = record.vendoraddress1 != null ? record.vendoraddress1 : "N/A";
            rowData[i][4] = record.vendoraddress2 != null ? record.vendoraddress2 : "N/A";
            rowData[i][5] = record.vendorcity != null ? record.vendorcity : "N/A";
            rowData[i][6] = record.vendorstate != null ? record.vendorstate : "N/A";
            rowData[i][7] = record.vendorzip != null ? record.vendorzip : "N/A";
        }

        createTableView(rowData, columnNames, "Fetched Vendors");
    }

    private void displayGridDataInTable(String jsonResponse) {
        Gson gson = new Gson();
        List<GridRecord> records = gson.fromJson(jsonResponse, new TypeToken<List<GridRecord>>(){}.getType());

        String[] columnNames = {"ID", "Geometry", "Vendor Grid Name", "Vendor ID", "Vendor"};
        String[][] rowData = new String[records.size()][5];

        for (int i = 0; i < records.size(); i++) {
            GridRecord record = records.get(i);
            rowData[i][0] = String.valueOf(record.id);
            rowData[i][1] = record.geometry != null ? record.geometry : "N/A";
            rowData[i][2] = record.vendorgridname != null ? record.vendorgridname : "N/A";
            rowData[i][3] = record.vendorid != null ? record.vendorid : "N/A";
            rowData[i][4] = record.vendor != null ? record.vendor : "N/A";
        }

        createTableView(rowData, columnNames, "Fetched Grid Records");
    }

    private void createTableView(String[][] rowData, String[] columnNames, String title) {
        DefaultTableModel model = new DefaultTableModel(rowData, columnNames);
        JTable table = new JTable(model);
        JScrollPane scrollPane = new JScrollPane(table);

        JFrame tableFrame = new JFrame(title);
        tableFrame.setSize(800, 400);
        tableFrame.add(scrollPane);
        tableFrame.setVisible(true);
    }
}

class AppRecord {
    Integer id;
    String appid;
    String appdescription;
    Integer apptype;
    Integer appregion;
    String dbmstype;
    String dbmsvendor;
    String dbmstopology;
    Integer gridid;
}

class VendorRecord {
    Integer id;
    String vendorid;
    String vendorname;
    String vendoraddress1;
    String vendoraddress2;
    String vendorcity;
    String vendorstate;
    String vendorzip;
}

class GridRecord {
    Integer id;
    String geometry;
    String vendorgridname;
    String vendorid;
    String vendor;
}
