using System;
using EasyRabbit.Options;

namespace EasyRabbit.Consuming
{
    public class ConsumeBuilder
    {
        public ServerOptions ServerOptions { get; private set; }

        public ConsumeOptions ConsumeOptions { get; private set; }

        public Type HandlerType { get; private set; }

        public ConsumeBuilder UseSysServerOptions()
        {
            ServerOptions = ServerOptions.Default;
            return this;
        }

        public ConsumeBuilder UseServerOptions(ServerOptions serverOptions)
        {
            ServerOptions = serverOptions;
            return this;
        }

        public ConsumeBuilder UseConsumeOptions(ConsumeOptions consumeOptions)
        {
            ConsumeOptions = consumeOptions;
            return this;
        }

        public ConsumeBuilder AddHandler<T>() where T : IConsumeMessagingHandler
        {
            HandlerType = typeof(T);
            return this;
        }
    }
}