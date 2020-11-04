using System;
namespace PolymorphismTest
{
    public abstract class Packages
    {
        public string ClientSenderAddress { get; set; }
        public string TheReceipientAddress { get; set; }

        public Packages(string senderAddress, string receipientAddress)
        {
            ClientSenderAddress = senderAddress;
            TheReceipientAddress = receipientAddress;
        }
        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"Client Sender Address : {ClientSenderAddress}\nThe Receipient Address: {TheReceipientAddress}";
        }



    }
}
