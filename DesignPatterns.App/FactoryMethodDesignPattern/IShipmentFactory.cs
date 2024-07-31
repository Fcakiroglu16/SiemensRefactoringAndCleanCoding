using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.App
{
    public class ShipmentFactory : IShipmentFactory
    {
        public Shipment CustomShipment(string senderAddress, string receiverAddress, int doorNo,
            DeliveryType deliveryType)
        {
            return new Shipment()
            {
                Barcode = BarcodeService.GenerateBarcode(), Created = DateTime.Now, DeliveryType = deliveryType,
                ReceiverAddress = receiverAddress, SenderAddress = senderAddress, TrackingNumber = "aadfdf",
                DoorNo = doorNo,
            };
        }

        public Shipment CreateDoorShipment(string senderAddress, string receiverAddress, int doorNo)
        {
            return new Shipment()
            {
                Barcode = BarcodeService.GenerateBarcode(), Created = DateTime.Now, DeliveryType = DeliveryType.Door,
                ReceiverAddress = receiverAddress, SenderAddress = senderAddress, TrackingNumber = "aadfdf",
                DoorNo = doorNo
            };
        }

        public Shipment CreateMatShipment(string senderAddress, string receiverAddress, int doorNo)
        {
            return new Shipment()
            {
                Barcode = BarcodeService.GenerateBarcode(), Created = DateTime.Now, DeliveryType = DeliveryType.Mat,
                ReceiverAddress = receiverAddress, SenderAddress = senderAddress, TrackingNumber = "aadfdf",
                DoorNo = doorNo
            };
        }

        public Shipment CreateOfficeShipment(string senderAddress, string receiverAddress, int doorNo)
        {
            return new Shipment()
            {
                Barcode = BarcodeService.GenerateBarcode(), Created = DateTime.Now,
                DeliveryType = DeliveryType.PostOffice,
                ReceiverAddress = receiverAddress, SenderAddress = senderAddress, TrackingNumber = "aadfdf",
                DoorNo = doorNo
            };
        }
    }


    public interface IShipmentFactory
    {
        Shipment CreateDoorShipment(string senderAddress, string receiverAddress, int doorNo);
        Shipment CreateMatShipment(string senderAddress, string receiverAddress, int doorNo);

        Shipment CreateOfficeShipment(string senderAddress, string receiverAddress, int doorNo);
    }
}