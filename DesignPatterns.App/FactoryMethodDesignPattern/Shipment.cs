using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.App.FactoryMethodDesignPattern
{
    public class BarcodeService()
    {
        public static string GenerateBarcode()
        {
            return Guid.NewGuid().ToString();
        }
    }

    public class Shipment
    {
        public int Id { get; set; }

        public DeliveryType DeliveryType { get; set; }

        public string TrackingNumber { get; set; } = default!;

        public string ReceiverAddress { get; set; } = default!;
        public string SenderAddress { get; set; } = default!;

        public string Barcode { get; set; } = default!;
        public DateTime Created { get; set; }

        public int DoorNo { get; set; }


        public int UpdatedByUser { get; set; }

        public static Shipment CreateDoorShipment(string senderAddress, string receiverAddress, int doorNo)
        {
            return new Shipment()
            {
                Barcode = BarcodeService.GenerateBarcode(),
                Created = DateTime.Now,
                DeliveryType = DeliveryType.Door,
                ReceiverAddress = receiverAddress,
                SenderAddress = senderAddress,
                TrackingNumber = "aadfdf",
                DoorNo = doorNo
            };
        }
    }

    public enum DeliveryType
    {
        Door,
        Mat,
        PostOffice,
    }
}