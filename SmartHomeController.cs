using System;
using System.Collections.Generic;
using System.Globalization;

namespace SmartHomeSystem {
    public class SmartHomeController {
        private List<ISwitchable> allDevices = new List<ISwitchable>();
        private List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device) {
            allDevices.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device) {
            energyDevices.Add(device);
        }

        public void TurnAllOn() {
            foreach (var d in allDevices)
                d.TurnOn();
        }

        public void TurnAllOff() {
            foreach (var d in allDevices)
                d.TurnOff();
        }

        public void ShowEnergyReport(int hours) {
            var culture = new CultureInfo("uk-UA");

            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double total = 0;

            foreach (var d in energyDevices) {
                double used = d.GetEnergyUsage(hours);
                total += used;
                string usedStr = string.Format(culture, "{0:F2}", used);
                string powerStr = d.PowerConsumption.ToString(culture);
                Console.WriteLine($"{d.DeviceName}: {usedStr} кВт·год (потужність: {powerStr} Вт)");
            }

            string totalStr = string.Format(culture, "{0:F2}", total);
            string costStr = string.Format(culture, "{0:F2}", total * 4);
            Console.WriteLine($"Загальне споживання: {totalStr} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {costStr} грн");
        }
    }
}
