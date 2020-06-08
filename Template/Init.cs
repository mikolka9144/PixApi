using PixApi;
using System;

namespace PixCode
{
    public static partial class Init
    {
        public static void Execute()
        {
            try
            {
                var code = new Code();
                code.YourCodeHere();
            }
            catch (Exception e)
            {
                new Core().message($"{e.Message}\n\n{e.StackTrace}");
            }
        }

    }
    
}
