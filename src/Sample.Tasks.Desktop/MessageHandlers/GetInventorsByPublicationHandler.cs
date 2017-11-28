using Sample.Tasks.Desktop.Infrastructure;
using Sample.Tasks.Desktop.Messages;
using Sample.Tasks.Domain.Services;

namespace Sample.Tasks.Desktop.MessageHandlers
{
    public sealed class GetInventorsByPublicationHandler : IMessageHandler<GetInventorsByPublication>
    {
        private readonly IInventorProvider inventorProvider;

        public GetInventorsByPublicationHandler(IInventorProvider inventorProvider)
        {
            this.inventorProvider = inventorProvider;
        }

        public void Handle(GetInventorsByPublication message)
        {
            
        }
    }
}