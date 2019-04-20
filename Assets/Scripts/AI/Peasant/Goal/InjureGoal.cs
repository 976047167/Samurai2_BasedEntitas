﻿using BlueGOAP;
using UnityEngine;

namespace Game.UI
{
    public class InjureGoal : GoalBase<ActionEnum, GoalEnum>
    {
        public override GoalEnum Label { get {return GoalEnum.INJJURE;} }

        public InjureGoal(IAgent<ActionEnum, GoalEnum> agent) : base(agent)
        {
        }

      
        public override float GetPriority()
        {
            return 60;
        }

        protected override IState InitEffects()
        {
            State<StateKeyEnum> state = new State<StateKeyEnum>();
            state.Set(StateKeyEnum.INJURE, false);
            return state;
        }

        protected override bool ActiveCondition()
        {
            return GetAgentState(StateKeyEnum.INJURE) == true;
        }
    }
}
