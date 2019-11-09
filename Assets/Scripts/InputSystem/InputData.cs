using UnityEngine;

namespace GhAyoub.InputSystem
{
    public class InputData
    {
        public bool Fire { get; internal set; }
        public bool Sprint { get; internal set; }
        public Vector2 VectMove { get; internal set; }

        internal void ClearData ()
        {
            this.Fire = false;
            this.Sprint = false;
            this.VectMove = Vector2.zero;
        }
    }
}