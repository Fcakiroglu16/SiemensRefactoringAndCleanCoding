// See https://aka.ms/new-console-template for more information


using SiemensRefactoringAndCleanCoding.ObjectOrientedRefactoringGood;

Console.Title = "Siemens Refactoring And Clean Coding";


var superCar = new SuperCar(new SuperCarBackwardBehavior(), new SuperCarRightOrLeftBehavior());

superCar.Forward();
superCar.Left();
superCar.Right();

var isChecked = false;

if (isChecked)
{
    superCar.Backward();
}
else
{
    superCar.ChangeBackwardBehavior(new SuperCar1BackwardBehavior());
    superCar.Backward();
}


Console.WriteLine("-------------");
var superCar1 = new Super1Car(new SuperCar1BackwardBehavior(), new SuperCarRightOrLeftBehavior());


superCar1.Forward();
superCar1.Left();
superCar1.Right();