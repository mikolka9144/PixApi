using PixBlocks.PythonIron.Tools;
using PixBlocks.PythonIron.Tools.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixApi
{
    public class Core
    {
        public Core()
        {
            if (GameScene.gameSceneStatic is null)
            {
                throw new Exception("Missing \"game.\" in code");
            }
            game = GameScene.gameSceneStatic;
            pythonCodeRunner = game.PythonCodeRunner;
        }

        public GameScene game { get; }

        private PythonCodeRunner pythonCodeRunner;
        public string input
        {
            get
            {
                return pythonCodeRunner.InputText;
            }
        }

        public string message(string text)
        {
            return pythonCodeRunner.show(text);
        }

    }
}
