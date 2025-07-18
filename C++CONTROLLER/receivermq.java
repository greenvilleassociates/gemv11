import javax.jms.Connection;
import javax.jms.Destination;
import javax.jms.JMSException;
import javax.jms.Message;
import javax.jms.MessageConsumer;
import javax.jms.Session;
import javax.jms.TextMessage;
import org.apache.activemq.ActiveMQConnectionFactory;

public class MessageReceiver {

    private static String url = "tcp://localhost:61616";
    private static String queueName = "TEST_QUEUE";

    public void receiveMessage() {
        ActiveMQConnectionFactory connectionFactory = new ActiveMQConnectionFactory(url);

        try (Connection connection = connectionFactory.createConnection()) {
            connection.start();

            Session session = connection.createSession(false, Session.AUTO_ACKNOWLEDGE);
            Destination destination = session.createQueue(queueName);

            MessageConsumer consumer = session.createConsumer(destination);
            Message message = consumer.receive();

            if (message instanceof TextMessage) {
                TextMessage textMessage = (TextMessage) message;
                System.out.println("Received message: " + textMessage.getText());
            }
        } catch (JMSException e) {
            e.printStackTrace();
        }
    }

    public static void main(String[] args) {
        MessageReceiver receiver = new MessageReceiver();
        receiver.receiveMessage();
    }
}
