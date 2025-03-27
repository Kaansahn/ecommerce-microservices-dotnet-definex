using DefineX.MessageBus;
using DefineX.Services.ShoppingCartAPI.Messages;

namespace DefineX.Services.ShoppingCartAPI.RabbitMQSender;

public interface IRabbitMQCartMessageSender
{
    void SendMessage(BaseMessage baseMessage, String queueName);
}
