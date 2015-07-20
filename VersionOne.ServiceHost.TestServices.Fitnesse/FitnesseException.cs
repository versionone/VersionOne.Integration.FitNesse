using System;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public class FitnesseException : Exception {
        public FitnesseException(string message) : base(message) {}
    }
}