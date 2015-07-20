using System;
using System.IO;
using System.Xml;
using VersionOne.ServiceHost.Core;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public class FitReaderService : FileProcessorService {
        protected override Type EventSinkType {
            get { return typeof(IntervalSync); }
        }

        protected override void InternalProcess(string file) {
            var doc = new XmlDocument();
            doc.Load(file);

            var xr = XmlParserFactory.CreateParser(doc, File.GetLastWriteTime(file));

            if(xr == null) {
                throw new FitnesseException("Cannot resolve FitNesse version");
            }

            foreach(var sr in xr.GetSuiteRuns()) {
                EventManager.Publish(sr);
            }

            foreach(var tr in xr.GetTestRuns()) {
                EventManager.Publish(tr);
            }
        }

        public class IntervalSync { }
    }
}