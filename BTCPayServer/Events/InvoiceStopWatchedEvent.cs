namespace BTCPayServer.Events
{
    public class InvoiceStopWatchedEvent
    {
        public InvoiceStopWatchedEvent(string invoiceId)
        {
            this.InvoiceId = invoiceId;
        }
        public string InvoiceId { get; set; }
        public override string ToString()
        {
            return $"Invoice {InvoiceId} is not monitored anymore.";
        }
    }
}
