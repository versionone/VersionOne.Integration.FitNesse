using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Xml;

namespace VersionOne.ServiceHost.TestServices.Fitnesse {
    public abstract class XmlFileParser {
        protected abstract string ResultXpath { get; }
        protected abstract string TopSuiteNameXpath { get; }

        private const string RightXpath = "counts/right/text()";
        private const string WrongXpath = "counts/wrong/text()";
        private const string ExceptionsXpath = "counts/exceptions/text()";
        private const string SuiteRunDesc = "Fit Test Suite";
        
        protected readonly DateTime TestTime;
        private XmlDocument document;
        private ICollection<SuiteRun> suiteRuns;
        private IList<TestRun> testRuns;

        protected XmlFileParser(XmlDocument document, DateTime testTime) {
            this.document = document;
            TestTime = testTime;
        }

        public IList<TestRun> GetTestRuns() {
            if(testRuns == null) {
                testRuns = new List<TestRun>();
                var topSuiteName = document.SelectSingleNode(TopSuiteNameXpath).Value;
                var testRunNodes = document.SelectNodes(ResultXpath);

                foreach(XmlNode testRunNode in testRunNodes) {
                    var testRun = CreateTestRun(topSuiteName, testRunNode);

                    if(testRun != null) {
                        testRuns.Add(testRun);
                    }
                }
            }

            return testRuns;
        }

        protected abstract TestRun CreateTestRun(string topSuiteName, XmlNode testRunNode);

        public ICollection<SuiteRun> GetSuiteRuns() {
            if(suiteRuns == null) {
                IDictionary<string, SuiteRun> suiteHash = new Dictionary<string, SuiteRun>();
                var testRuns = GetTestRuns();

                foreach(var testRun in testRuns) {
                    var suiteNames = GetSuiteNames(testRun);
                    AddOrUpdateSuite(suiteHash, testRun, suiteNames);
                }

                suiteRuns = suiteHash.Values;
                document = null; //don't need xml anymore, runs and suites now cached
            }

            return suiteRuns;
        }

        private static StringCollection GetSuiteNames(TestRun testRun) {
            var suiteNames = new StringCollection();
            var fullName = testRun.TestRef;

            while(fullName.Length > 0) {
                var length = (fullName.Contains(".")) ? fullName.LastIndexOf('.') : 0;
                fullName = fullName.Substring(0, length);

                if(fullName.Length > 0) {
                    suiteNames.Add(fullName);
                }
            }

            return suiteNames;
        }

        private void AddOrUpdateSuite(IDictionary<string, SuiteRun> suiteHash, TestRun testRun, StringCollection suiteNames) {
            foreach(var suiteName in suiteNames) {
                if(!suiteHash.ContainsKey(suiteName)) {
                    var newSuite = new SuiteRun(suiteName, SuiteRunDesc, TestTime, suiteName);
                    suiteHash.Add(suiteName, newSuite);
                }

                var suiteRun = suiteHash[suiteName];

                if(testRun.State == TestRun.TestRunState.Passed) {
                    suiteRun.Passed++;
                }

                if(testRun.State == TestRun.TestRunState.Failed) {
                    suiteRun.Failed++;
                }

                if(testRun.State == TestRun.TestRunState.NotRun) {
                    suiteRun.NotRun++;
                }
            }
        }

        protected TestRun.TestRunState GetTestRunState(XmlNode node) {
            var right = Convert.ToInt32(node.SelectSingleNode(RightXpath).Value);
            var wrong = Convert.ToInt32(node.SelectSingleNode(WrongXpath).Value);
            var exceptions = Convert.ToInt32(node.SelectSingleNode(ExceptionsXpath).Value);

            if(wrong + exceptions > 0) {
                return TestRun.TestRunState.Failed;
            }

            return right > 0 ? TestRun.TestRunState.Passed : TestRun.TestRunState.NotRun;
        }
    }
}