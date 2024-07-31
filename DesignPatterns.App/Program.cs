// See https://aka.ms/new-console-template for more information


using DesignPatterns.App.BuilderDesignPatternFluent;

Console.WriteLine("Hello, World!");


var hatchBackCar = new HatchbackCarBuilder().SetColor("xxx").SetGear().SetSeat().SetWindShield().Build();


//var carDirector = new CarDirector(new CoupeCarBuilder());

//var car = carDirector.CreateCar("xxx", "red");


//var newCar = car with { Gear = Gear.Manuel };

//var shipment = new Shipment()
//{
//    Barcode = BarcodeService.GenerateBarcode(), Created = DateTime.Now, DeliveryType = DeliveryType.Door,
//    ReceiverAddress = "", SenderAddress = "", TrackingNumber = "aadfdf"
//};

//var shipmentFactory = new ShipmentFactory();

//shipmentFactory.CreateDoorShipment(senderAddress: "sender address", receiverAddress: "receiver address", doorNo: 10);


//var lowLevel = new LowLevelComputerComponentFactory();

//var computer = lowLevel.CreateComputer();

//var higLevel = new HighLevelComputerComponentFactory();

//computer.Ram = higLevel.CreateRam();