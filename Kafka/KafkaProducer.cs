using Confluent.Kafka;
using System.Text.Json;
using PatientEvent;

namespace Patient_Management_System.Kafka
{
    public class KafkaProducer
    {
        private readonly IProducer<string, string> _producer;
        private readonly string _topic;

        public KafkaProducer(IConfiguration configuration)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = configuration["Kafka:BootstrapServers"]
            };

            _producer = new ProducerBuilder<string, string>(config).Build();
            _topic = configuration["Kafka:PatientCreatedTopic"];
        }

        public async Task PublishPatientCreatedEvent(int patientId)
        {
            var patientEvent = new PatientEventRequest
            {
                PatientId = patientId,
                EventType = "PATIENT_CREATED"
            };

            var message = JsonSerializer.Serialize(patientEvent);

            await _producer.ProduceAsync(_topic, new Message<string, string>
            {
                Key = patientId.ToString(),
                Value = message
            });
        }
    }
}