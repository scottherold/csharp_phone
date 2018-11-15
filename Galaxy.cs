using System;
using System.Collections.Generic;

namespace phone
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring()
        {
            // "$" before a string pulls a reference to variables of the parent class!
            return $"... {RingTone} ...";
        }
        public string Unlock()
        {
            return $"Galaxy {VersionNumber} unlocked with fingerprint scanner";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine(new string('#', 25));
            Console.WriteLine($"Galaxy {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine(new string('#', 25));
        }
    }
}