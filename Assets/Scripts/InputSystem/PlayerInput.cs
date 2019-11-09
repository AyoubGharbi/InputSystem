using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GhAyoub.InputSystem
{
    public class PlayerInput : Singleton<PlayerInput>
    {
        public InputData Data { get; private set; } = new InputData ();

        private KeyboardLayout _keyboard = new KeyboardLayout ();
        private MouseLayout _mouse = new MouseLayout ();

        void Update ()
        {
            Data.ClearData();

            _mouse.Execute(Data);
            _keyboard.Execute(Data);
        }
    }
}