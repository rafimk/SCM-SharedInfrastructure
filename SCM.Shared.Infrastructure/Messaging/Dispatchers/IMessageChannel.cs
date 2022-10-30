using System.Threading.Channels;

namespace SCM.Shared.Infrastructure.Messaging.Dispatchers;

internal interface IMessageChannel
{
    ChannelReader<MessageEnvelope> Reader { get; }
    ChannelWriter<MessageEnvelope> Writer { get; }
}