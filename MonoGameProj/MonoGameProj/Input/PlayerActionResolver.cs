using Microsoft.Xna.Framework.Input;
using MonoGameProj.Constants;
using MonoGameProj.Entities.Players;
using System;
using System.Collections.Generic;

namespace MonoGameProj.Managers.PlayerMangers
{
    public class PlayerActionResolver : IPlayerActionResolver
    {
        private KeyboardState keyboardState;

        public PlayerActionResolver()
        {
            keyboardState = new KeyboardState();
        }

        public List<ActionConstants> ResolvePlayerActions(Player player)
        {
            List<ActionConstants> actions = new List<ActionConstants>();

            var keysCurrentlyPressed = this.GetCurrentlyPressedKeys();

            foreach (KeyValuePair<Keys, ActionConstants> entry in player.PlayerControlKeys)
            {
                if (KeyAssociatedWithPlayerIsPressed(keysCurrentlyPressed, entry.Key))
                {
                    actions.Add(entry.Value);
                }
            }

            return actions;
        }

        private bool KeyAssociatedWithPlayerIsPressed(Keys[] keys, Keys playerkey)
        {
            for (int index = 0; index < keys.Length; index++)
            {
                if (keys[index] == playerkey)
                {
                    return true;
                }
            }

            return false;
        }

        private Keys[] GetCurrentlyPressedKeys()
        {
            keyboardState = Keyboard.GetState();
            return keyboardState.GetPressedKeys();
        }
    }
}
