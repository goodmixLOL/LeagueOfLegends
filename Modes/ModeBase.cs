using EloBuddy.SDK;

namespace DunkBuddy.Modes
{
    public abstract class ModeBase
    {
        protected Spell.Targeted R
        {
            get { return SpellManager.R; }
        }

        public abstract bool ShouldBeExecuted();

        public abstract void Execute();
    }
}
