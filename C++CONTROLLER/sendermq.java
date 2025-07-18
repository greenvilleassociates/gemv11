import javax.jms.Connection;
import javax.jms.Destination;
import javax.jms.JMSException;
import javax.jms.MessageProducer;
import javax.jms.Session;
import javax.jms.TextMessage;
import org.apache.activemq.ActiveMQConnectionFactory;

public class MessageSender {

    private static String url = "tcp://localhost:61616";
    private static String queueName = "TEST_QUEUE";

    public void sendMessage(String messageText) {
        ActiveMQConnectionFactory connectionFactory = new ActiveMQConnectionFactory(url);

        try (Connection connection = connectionFactory.createConnection()) {
            connection.start();

            Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
            Destination destination = session.createQueue(queueName);

            MessageProducer producer = session.createProducer(destination);
            TextMessage message = session.createTextMessage(messageText);
            producer.send(message);

            System.out.println("Sent message: " + messageText);
        } catch (JMSException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        MessageSender sender = new MessageSender();
        sender.sendMessage("Hello, this is a test message!");
    }
}
