using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using SharpDX;
//using System.Drawing;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
                                
namespace DunkBuddy
{
    public static class Program
    {
        public const string dariusName = "Darius";
        public const float version = 1.0f;
        static void Main(string[] args)
        {
            Loading.OnLoadingComplete += OnLoadingComplete;
        }
        private static void OnLoadingComplete(EventArgs args)
        {
            if (Player.Instance.ChampionName != dariusName)
            {
                return;
                
            }
             Chat.Print("DunkBuddy " + version + " loaded!");
            Config.Initialize();
            SpellManager.Initialize();
            Drawing.OnDraw += OnDraw;

            
        }
        
            private static void OnDraw(EventArgs args)
        {
            Circle.Draw(Color.Red, SpellManager.R.Range, Player.Instance.Position);
        }
        
        

    }
}
