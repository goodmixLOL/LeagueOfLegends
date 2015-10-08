
using EloBuddy;
using EloBuddy.SDK;

using Settings = DunkBuddy.Config.Modes.Killsteal;

namespace DunkBuddy.Modes
{
    public sealed class PermaActive : ModeBase
    {
        public override bool ShouldBeExecuted()
        {
         return true;
        }
        public override void Execute()
        {
            if (Settings.UseR && R.IsReady())
            {
                var target = TargetSelector.GetTarget(R.Range, DamageType.Physical);

                if (target.IsValidTarget(R.Range) && !target.IsZombie)
                {
                    int PassiveCounter = target.GetBuffCount("dariushemo") <= 0 ? 0 : target.GetBuffCount("dariushemo");
                    if (!target.HasBuffOfType(BuffType.Invulnerability) && !target.HasBuffOfType(BuffType.SpellShield))
                    {
                        if (SpellManager.RDmg(target, PassiveCounter) >= target.Health + SpellManager.PassiveDmg(target, 1))
                        {
                            if (!target.HasBuffOfType(BuffType.Invulnerability)
                                && !target.HasBuffOfType(BuffType.SpellShield))
                            {
                                R.Cast(target);
                            }
                        }
                    }
                }
            }
        }
    }
}