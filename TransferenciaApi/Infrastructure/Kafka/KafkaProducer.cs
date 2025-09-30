using Confluent.Kafka;

namespace TransferenciaApi.Infrastructure.Kafka;

public class KafkaProducer
{
    private readonly IConsumer<Null, string> _consumer;

    public KafkaProducer(string bootstrapServers)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = bootstrapServers,
            GroupId = "conta-corrente-group",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };
        _consumer = new ConsumerBuilder<Null, string>(config).Build();
    }

}