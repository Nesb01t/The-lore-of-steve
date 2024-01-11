using Puerts;

namespace TsCenter
{
    public static class EnvSingleton
    {
        private static JsEnv _env = new JsEnv();

        public static void Eval(string s)
        {
            _env.Eval(s);
        }

        public static void Use(string s)
        {
            _env.ExecuteModule(s + ".mjs");
        }
    }
}