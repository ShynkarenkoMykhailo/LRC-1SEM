using SmartHomeSystem;
using System;

class Program {
    static void Main() {
        SmartHomeController controller = new SmartHomeController();

        Light l = new Light { Name = "Лампа у вітальні" };
        AirConditioner ac = new AirConditioner { Name = "Кондиціонер у спальні" };
        CoffeeMachine cm = new CoffeeMachine { Name = "Кавомашина на кухні" };
        MotionSensor ms = new MotionSensor { Name = "Датчик руху у коридорі" };

        controller.AddDevice(l);
        controller.AddDevice(ac);
        controller.AddDevice(cm);
        controller.AddDevice(ms);

        controller.AddEnergyDevice(l);
        controller.AddEnergyDevice(ac);
        controller.AddEnergyDevice(cm);

        controller.TurnAllOn();

        l.PrintStatus();
        ac.PrintStatus();
        cm.PrintStatus();
        ms.PrintStatus();

        controller.ShowEnergyReport(5);

        controller.TurnAllOff();
    }
}
