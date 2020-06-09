using System;
using Base.Data_Classes;

namespace Base.Master_Classes
{
    public static class MidsContext
    {
        public static int MathLevelBase = 49;
        public static int MathLevelExemp = -1;
        public const string AppName = "Mids' Reborn";
        private const int AppMajorVersion = 2;
        private const int AppMinorVersion = 7;
        private const int AppBuildVersion = 2;
        private const int AppRevisionVersion = 10;
        public const string AppAssemblyVersion = "2.7.2.10";
        public static readonly Version AppVersion = new Version(major: AppMajorVersion, minor: AppMinorVersion, build: AppBuildVersion, revision: AppRevisionVersion);
        
        public const string Title = "Mids' Reborn : Hero Designer";
        public const string AssemblyName = "Hero Designer.exe";

        public static Archetype Archetype;
        public static Character Character;
        public static void AssertVersioning()
        {
            if (AppAssemblyVersion != $"{AppMajorVersion}.{AppMinorVersion}.{AppBuildVersion}.{AppRevisionVersion}")
                throw new InvalidOperationException("Program assembly version is not internally consistent");
            if (AppVersion.CompareTo(new Version(AppAssemblyVersion)) != 0)
                throw new InvalidOperationException("Program app version is not internally consistent, failing startup");
        }

        public static ConfigData Config => ConfigData.Current;
    }
}
