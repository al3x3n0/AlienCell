using ConsoleAppFramework;
using System.IO;

using AlienCell.ConsoleApp.Data;


namespace AlienCell.ConsoleApp.Apps
{
    public class GameDataApp : ConsoleAppBase
    {
        private readonly GameDataBuilder _gdBuilder;
        public GameDataApp(GameDataBuilder gdBuilder)
        {
            _gdBuilder = gdBuilder;
        }

        [Command("build", "Build")]
        public void Build(string outputPath, bool createDir = false)
        {
            _gdBuilder.InitGenerated();
            var data = _gdBuilder.Build();
            if (createDir)
            {
                var dirName = Path.GetDirectoryName(outputPath);
                Directory.CreateDirectory(dirName);
            }
            File.WriteAllBytes(outputPath, data);
        }
    }
}