﻿namespace licupd
{
  class Program
  {
    static void Main(string[] args)
    {
      new Azos.Platform.Abstraction.NetFramework.DotNetFrameworkRuntime();
      Azos.Tools.Licupd.ProgramBody.Main(args);
    }
  }
}