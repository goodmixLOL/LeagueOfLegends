using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK;
using SharpDX;
using System.Drawing;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;

namespace DunkBuddy
{
    class SpellManager
    {
        public static Spell.Targeted R { get; private set; }
        static SpellManager()
        {
            
            R = new Spell.Targeted (SpellSlot.R, 460);
        }
        public static void Initialize()
        { }
        public static float RDmg(Obj_AI_Base unit, int stackcount)
        {
            var bonus =
                stackcount *
                    (new[] { 20, 40, 60 }[R.Level] + (0.20 * ObjectManager.Player.FlatPhysicalDamageMod));

            return
                (float)(bonus + (ObjectManager.Player.CalculateDamageOnUnit(unit, DamageType.True,
                        new[] {100, 200, 300 }[R.Level] + (float)(0.75 * ObjectManager.Player.FlatPhysicalDamageMod))));
        }
        public static float PassiveDmg(Obj_AI_Base unit, int stackcount)
        {
            if (stackcount <= 0)
                stackcount = 1;

            return
                (float)
                    ObjectManager.Player.CalculateDamageOnUnit(unit, DamageType.Physical,
                        (9 + ObjectManager.Player.Level) + (float)(0.3 * ObjectManager.Player.FlatPhysicalDamageMod)) * stackcount;
        }

    }
}
