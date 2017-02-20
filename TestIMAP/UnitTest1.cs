using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IMAP;

using System.IO;

namespace TestIMAP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string sBenchmarkPath = "Boxes";
            string sDomain = "boxes5";
            string sBenchmark = "boxes5_Benchmark";
            BoxDomain bd = new BoxDomain("\\" + sBenchmarkPath + "\\" + sDomain + ".txt");

            string sPath = sBenchmarkPath + sBenchmark + "\\";

            bd.WriteDomain(sPath);
            bd.WriteProblem(sPath);

            Parser parser = new Parser();
            Domain domain = parser.ParseDomain(sPath + "d.pddl");
            Problem problem = parser.ParseProblem(sPath + "p.pddl", domain);

            SDRPlanner sdr = new SDRPlanner(sPath, domain, problem);

            //SDRPlanner.TagsCount = 2;
            //Domain.MAX_OPTIONS = 2;
            //BeliefState.AddAllKnownToGiven = true;
            //TestCLG(sBenchmarkPath + sBenchmark + "\\", 10);
            //SDRPlanner.SDR_OBS = false;
            //SDRPlanner.AddTagRefutationToGoal = true;
            //IMAP.Program.TestBenchmark(sBenchmarkPath, sBenchmark, 25, true, false);
            //TestBenchmark(sBenchmarkPath, sBenchmark, 25, true, false);
            //SDR_OBS = true;
            //TestBenchmark(sBenchmarkPath, sBenchmark, 25, true, false);
            sdr.Start();

        }
    }
}
