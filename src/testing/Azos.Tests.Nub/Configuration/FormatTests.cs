/*<FILE_LICENSE>
 * Azos (A to Z Application Operating System) Framework
 * The A to Z Foundation (a.k.a. Azist) licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
</FILE_LICENSE>*/


using System;

using Azos.Conf;
using Azos.Data;
using Azos.Scripting;

namespace Azos.Tests.Nub.Configuration
{
  [Runnable]
  public class FormatTests
  {
    private const string LACONIC_SOURCE = @"root=-900{a=1 b=2 sub{z='my\nmessage!'}}";
    private const string JSON_SOURCE = @"{ ""root"":{ ""-section-value"":""-900"",""a"":""1"",""b"":""2"",""sub"":{ ""z"":""my\nmessage!""} } }";

    private void ensureInvariant(ConfigSectionNode cfg)
    {
      Aver.IsFalse(cfg.Modified);
      Aver.AreEqual("root", cfg.Name);
      Aver.AreEqual(-900, cfg.ValueAsInt());
      Aver.AreEqual(1, cfg.ChildCount);
      Aver.AreEqual(2, cfg.AttrCount);
      Aver.IsTrue(cfg.HasChildren);

      Aver.AreEqual("a", cfg.AttrByIndex(0).Name);
      Aver.AreEqual("1", cfg.AttrByIndex(0).Value);

      Aver.AreEqual("b", cfg.AttrByIndex(1).Name);
      Aver.AreEqual("2", cfg.AttrByIndex(1).Value);

      Aver.IsTrue(cfg[0].Exists);
      Aver.IsFalse(cfg[1900].Exists);
      Aver.AreEqual("sub", cfg[0].Name);
      Aver.AreEqual(null, cfg[0].Value);

      Aver.AreEqual("my\nmessage!", cfg[0].AttrByName("z").Value);
    }


    [Run]
    public void AsLaconicConfig()
    {
      var cfg = LACONIC_SOURCE.AsLaconicConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg);
    }

    [Run]
    public void AsJsonConfig()
    {
      var cfg = JSON_SOURCE.AsJSONConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg);
    }

    [Run]
    public void LaconicRoundTrip()
    {
      var cfg = LACONIC_SOURCE.AsLaconicConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg);

      var serializedLaconic = cfg.ToLaconicString(CodeAnalysis.Laconfig.LaconfigWritingOptions.Compact);
      Console.WriteLine("SERIALIZED COMPACT LACONIC: \n" + serializedLaconic);

      var cfg2 = serializedLaconic.AsLaconicConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg2);

      serializedLaconic = cfg.ToLaconicString(CodeAnalysis.Laconfig.LaconfigWritingOptions.PrettyPrint);
      Console.WriteLine("SERIALIZED PRETTY LACONIC: \n" + serializedLaconic);

      var cfg3 = serializedLaconic.AsLaconicConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg3);
    }

    [Run]
    public void JsonRoundTrip()
    {
      var cfg = JSON_SOURCE.AsJSONConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg);

      var serializedJSON = cfg.ToJSONString();
      Console.WriteLine("SERIALIZED JSON: \n" + serializedJSON);

      var cfg2 = serializedJSON.AsJSONConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg2);

      serializedJSON = cfg.ToJSONString(Serialization.JSON.JSONWritingOptions.PrettyPrintASCII);
      Console.WriteLine("SERIALIZED PRETTY JSON: \n" + serializedJSON);

      var cfg3 = serializedJSON.AsJSONConfig(handling: Data.ConvertErrorHandling.Throw);
      ensureInvariant(cfg3);
    }
  }
}