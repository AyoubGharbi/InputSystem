using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhAyoub.InputSystem
{
    public class MouseLayout : ILayout
    {
        private KeyCode _kcFire = KeyCode.Mouse0;

        public void Execute (InputData data)
        {
            data.Fire |= Input.GetKeyDown(_kcFire);
        }
    }
}