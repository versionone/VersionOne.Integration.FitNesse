using System.Reflection;

[assembly: AssemblyTitle("VersionOne Fitnesse Integration Hosted Services")]

#if !DEBUG
[assembly: AssemblyDelaySign(false)]
[assembly: AssemblyKeyFile("..\\..\\..\\Common\\SigningKey\\VersionOne.snk")]
[assembly: AssemblyKeyName("")]
#endif