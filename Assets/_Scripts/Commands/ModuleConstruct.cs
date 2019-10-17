﻿using System.Linq;
using GameLogic.Architecture;

namespace GameLogic.Commands
{
    public class ModuleConstruct : Command
    {
        public readonly Building Building;
        public readonly Module Module;
        public readonly int Position;

        public ModuleConstruct(Building building, Module module, int position)
        {
            Building = building;
            Module = module;
            Position = position;
        }

        protected override bool Run()
        {
            if (Building.Type == BuildingType.Empty)
            {
                return false;
            }

            if (Position < 0 || Position >= Building.ModulesLimit)
            {
                return false;
            }

            if (Building.GetModule(Position) != null)
            {
                return false;
            }

            if (!Building.Config.AvailableModules.Contains(Module.Type))
            {
                return false;
            }

            if (!Building.Constructible.IsReady)
            {
                return false;
            }

            if (!new Pay(Module.Config.ConstructionCost).Execute(Core).IsValid)
            {
                return false;
            }

            Building.SetModule(Position, Module);
            return true;
        }
    }

}
