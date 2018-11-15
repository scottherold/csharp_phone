using System;
using System.Collections.Generic;

namespace phone
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring()
        {
            // "$" before a string pulls a reference to variables of the parent class!
            return $"... {RingTone} ...";
        }
        public string Unlock()
        {
            return $"Nokia {VersionNumber} unlocked with passcode";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine(new string('$', 25));
            Console.WriteLine($"Nokia {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine(new string('$', 25));
        }
    }
}