﻿using Gum.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluePlugin.Logic
{
    public class StandardElementsCustomizationLogic : Singleton<StandardElementsCustomizationLogic>
    {
        public void CustomizeStandardElements()
        {
            CustomizeRectangle();

            CustomizeCircle();

            CustomizeSprite();

            CustomizeContainer();
        }

        private void CustomizeRectangle()
        {
            var circleDefaultValues = StandardElementsManager.Self.DefaultStates["Rectangle"];

            foreach (var variable in circleDefaultValues.Variables)
            {
                variable.IsHiddenInPropertyGrid = true;
            }

            circleDefaultValues.GetVariableSave("X").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Y").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Width").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Height").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Visible").IsHiddenInPropertyGrid = false;
        }

        private void CustomizeSprite()
        {
            var circleDefaultValues = StandardElementsManager.Self.DefaultStates["Sprite"];

            foreach (var variable in circleDefaultValues.Variables)
            {
                variable.IsHiddenInPropertyGrid = true;
            }

            circleDefaultValues.GetVariableSave("X").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Y").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Width").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Height").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Visible").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("SourceFile").IsHiddenInPropertyGrid = false;
        }

        private static void CustomizeCircle()
        {
            var circleDefaultValues = StandardElementsManager.Self.DefaultStates["Circle"];

            foreach(var variable in circleDefaultValues.Variables)
            {
                variable.IsHiddenInPropertyGrid = true;
            }

            circleDefaultValues.GetVariableSave("X").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Y").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Radius").IsHiddenInPropertyGrid = false;
            circleDefaultValues.GetVariableSave("Visible").IsHiddenInPropertyGrid = false;
        }

        private void CustomizeContainer()
        {
            var containerDefaultValues = StandardElementsManager.Self.DefaultStates["Container"];

            foreach (var variable in containerDefaultValues.Variables)
            {
                variable.IsHiddenInPropertyGrid = true;
            }

            containerDefaultValues.GetVariableSave("X").IsHiddenInPropertyGrid = false;
            containerDefaultValues.GetVariableSave("Y").IsHiddenInPropertyGrid = false;
            containerDefaultValues.GetVariableSave("Visible").IsHiddenInPropertyGrid = false;
            // entities don't have width/height so don't let them edit it...
        }

    }
}