using Confluent.Kafka.Admin;
using Confluent.Kafka;

public class KafkaTopicCreator
{
    public static async Task CreateTopic(string bootstrapServers)
    {
        var config = new AdminClientConfig
        {
            BootstrapServers = bootstrapServers
        };

        using var adminClient = new AdminClientBuilder(config).Build();

        try
        {
            await adminClient.CreateTopicsAsync(new[]
            {
                new TopicSpecification
                {
                    Name = "patient",
                    NumPartitions = 1,
                    ReplicationFactor = 1
                }
            });

            Console.WriteLine("Topic created successfully.");
        }
        catch (CreateTopicsException e)
        {
            if (e.Results[0].Error.Code == ErrorCode.TopicAlreadyExists)
            {
                Console.WriteLine("Topic already exists. Continuing...");
            }
            else
            {
                throw;
            }
        }
    }
}