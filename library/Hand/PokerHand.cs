using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public abstract class PokerHand : Hand
    {
        public void CollectMoney()
        {
            throw new NotImplementedException();
        }

        public Action Next()
        {
            return Actions().FirstOrDefault(x => !x.Finished());
        }

        public void Run()
        {
            var action = Next();

            while (action != null)
            {
                action.Act();
                action = Next();
            }
        }

        protected abstract List<Action> Actions();
    }
}