using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhAyoub.InputSystem
{
    public class KeyboardLayout : ILayout
    {
        public KeyCode _kcSprint = KeyCode.LeftShift;
        public void Execute (InputData data)
        {
            var xMove = Input.GetAxis ("Horizontal");
            var yMove = Input.GetAxis ("Vertical");

            data.VectMove += new Vector2 (xMove, yMove);

            data.Sprint |= Input.GetKey (_kcSprint);
        }
    }
}