using System;
using System.Buffers;

namespace Confluent.Kafka.Serialization
{
    public class ByteMemoryOwner : IMemoryOwner<byte>
    {
        public Memory<byte> Memory { get; }

        public ByteMemoryOwner(Memory<byte> memory)
        {
            Memory = memory;
        }

        public void Dispose()
        {
        }
    }
}
