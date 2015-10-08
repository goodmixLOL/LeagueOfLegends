using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;


namespace DunkBuddy
{
 
    public static class Config
    {
        private const string MenuName = "DunkBuddy";

        private static readonly Menu Menu;

        static Config()
        {
            // Initialize the menu
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Welcome to CancerDarius Addon!");
            Menu.AddLabel("Im Cancerous and i dont got Cancer!");
            Menu.AddLabel("I Dont want to make fun of people who got Cancer,");
            Menu.AddLabel("i just wanted to say that this addon is badass just like the disease!");


            // Initialize the modes
            Modes.Initialize();
        }

        public static void Initialize()
        {
        }

        public static class Modes
        {
            private static readonly Menu Menu;

            static Modes()
            {
 
                Menu = Config.Menu.AddSubMenu("DunkBuddy");

                Killsteal.Initialize();
            }

            public static void Initialize()
            {
            }

            public static class Killsteal
            {
                private static readonly CheckBox _useR;

                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }

                static Killsteal()
                {
                    Menu.AddGroupLabel("Kill Secure");
                    _useR = Menu.Add("stealUseR", new CheckBox("Use R", true)); 
                }

                public static void Initialize()
                {
                }
            }

        }
    }
}