using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using System;
using System.Xml;
using XMLData;

namespace GameV2
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MyPaths testData = new MyPaths();
           
            //  MyTest testData = new MyTest();

          //  testData.Path = "deer";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            MyPathArray testData2 = new MyPathArray();
           
           


            using (XmlWriter writer = XmlWriter.Create("test.xml", settings))
            {
                IntermediateSerializer.Serialize(writer, testData, null);
            }


            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
