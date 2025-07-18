import javafx.application.Application;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.*;
import javafx.scene.layout.GridPane;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.List;
import java.util.Scanner;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;

public class ApiGuiAppV5 extends Application {

    private TableView<AppRecord> tableView = new TableView<>();
    private TextArea outputArea = new TextArea();

    @Override
    public void start(Stage primaryStage) {
        primaryStage.setTitle("API Menu - JavaFX");

        Button fetchGappButton = new Button("Fetch /api/Gapp");
        Button fetchGvendorButton = new Button("Fetch /api/Gvendor");
        Button fetchGgridsButton = new Button("Fetch /api/Ggrids");
        Button addNewAppButton = new Button("Add New Application");
        Button updateAppButton = new Button("Update an Application");

        fetchGappButton.setOnAction(e -> fetchApiData("http://localhost:5033/api/Gapp"));
        fetchGvendorButton.setOnAction(e -> fetchApiData("http://localhost:5033/api/Gvendor"));
        fetchGgridsButton.setOnAction(e -> fetchApiData("http://localhost:5033/api/Ggrids"));
        addNewAppButton.setOnAction(e -> addNewApp());
        updateAppButton.setOnAction(e -> updateApplication());

        VBox vbox = new VBox(10, fetchGappButton, fetchGvendorButton, fetchGgridsButton, addNewAppButton, updateAppButton, tableView, outputArea);
        vbox.setPadding(new Insets(20));

        Scene scene = new Scene(vbox, 800, 600);
        primaryStage.setScene(scene);
        primaryStage.show();
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
                
                displayDataInTable(response);
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

        ObservableList<AppRecord> data = FXCollections.observableArrayList(records);
        tableView.setItems(data);

        TableColumn<AppRecord, String> appIdCol = new TableColumn<>("App ID");
        appIdCol.setCellValueFactory(cellData -> cellData.getValue().appidProperty());

        TableColumn<AppRecord, String> descriptionCol = new TableColumn<>("Description");
        descriptionCol.setCellValueFactory(cellData -> cellData.getValue().appdescriptionProperty());

        TableColumn<AppRecord, String> typeCol = new TableColumn<>("Type");
        typeCol.setCellValueFactory(cellData -> cellData.getValue().apptypeProperty());

        TableColumn<AppRecord, String> regionCol = new TableColumn<>("Region");
        regionCol.setCellValueFactory(cellData -> cellData.getValue().appregionProperty());

        tableView.getColumns().setAll(appIdCol, descriptionCol, typeCol, regionCol);
    }

    private void addNewApp() {
        Stage stage = new Stage();
        stage.setTitle("Add New Application");

        GridPane grid = new GridPane();
        grid.setPadding(new Insets(10));
        grid.setVgap(8);
        grid.setHgap(10);

        TextField appDescriptionField = new TextField();
        TextField appTypeField = new TextField();
        TextField appRegionField = new TextField();
        TextField dbmsTypeField = new TextField();
        TextField dbmsVendorField = new TextField();
        TextField dbmsTopologyField = new TextField();

        String[] gridOptions = {"1 - North America", "2 - Campus", "3 - HiLine", "4 - EurAmerica"};
        ComboBox<String> gridIdComboBox = new ComboBox<>(FXCollections.observableArrayList(gridOptions));

        Button submitButton = new Button("Submit");
        submitButton.setOnAction(e -> {
            try {
                int gridId = gridIdComboBox.getSelectionModel().getSelectedIndex() + 1;

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

                outputArea.setText(connection.getResponseCode() == 201 ? "Application added successfully!" : "Failed to add application.");
                connection.disconnect();
                stage.close();
            } catch (Exception ex) {
                outputArea.setText("Error adding application: " + ex.getMessage());
            }
        });

        grid.add(new Label("App Description:"), 0, 0);
        grid.add(appDescriptionField, 1, 0);
        grid.add(new Label("App Type:"), 0, 1);
        grid.add(appTypeField, 1, 1);
        grid.add(new Label("App Region:"), 0, 2);
        grid.add(appRegionField, 1, 2);
        grid.add(new Label("Grid ID:"), 0, 3);
        grid.add(gridIdComboBox, 1, 3);
        grid.add(submitButton, 1, 4);

        Scene scene = new Scene(grid, 400, 300);
        stage.setScene(scene);
        stage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}

// Class to store API records
class AppRecord {
    private final StringProperty appid = new SimpleStringProperty();
    private final StringProperty appdescription = new SimpleStringProperty();
    private final StringProperty apptype = new SimpleStringProperty();
    private final StringProperty appregion = new SimpleStringProperty();

    public StringProperty appidProperty() { return appid; }
    public StringProperty appdescriptionProperty() { return appdescription; }
    public StringProperty apptypeProperty() { return apptype; }
    public StringProperty appregionProperty() { return appregion; }
}

