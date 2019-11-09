using System.Collections;
using System.Collections.Generic;
using GhAyoub.InputSystem;
using UnityEngine;
public class TestInputs : MonoBehaviour
{
    private InputData _pInputData = null;

    // GUI
    private float _guiOffset = 10f;
    private float _styleWidth = 600f;
    private float _styleHeight = 100f;
    private bool _isGUIInitialized = false;
    private Font _styleFont = null;
    private GUIStyle _style = null;

    void Start ()
    {
        _pInputData = PlayerInput.Instance.Data;

        _styleFont = Resources.Load<Font> (@"Fonts/CASCADIA");
    }

    void OnGUI ()
    {
        // execute once
        if (!_isGUIInitialized)
        {
            _isGUIInitialized = true;

            //style 
            _style = new GUIStyle ("label");
            _style.font = _styleFont;
            _style.fontSize = 28;
            _style.normal.textColor = Color.black;
        }

        // Move
        var moveRect = new Rect (Screen.width / 2 - _styleWidth / 2,
            Screen.height / 4 - _styleHeight / 2, _styleWidth, _styleHeight);

        GUI.Label (moveRect, string.Format ("Move : {0}",
            new Vector3 (_pInputData.VectMove.x, 0, _pInputData.VectMove.y)), _style);

        // Fire
        var fireRect = new Rect (moveRect.x,
            moveRect.y + moveRect.height + _guiOffset, _styleWidth, _styleHeight);

        GUI.Label (fireRect, string.Format ("Fire : {0}", _pInputData.Fire), _style);

        // Sprint
        var sprintRect = new Rect (fireRect.x,
            fireRect.y + fireRect.height + _guiOffset, _styleWidth, _styleHeight);

        GUI.Label (sprintRect, string.Format ("Sprint : {0}", _pInputData.Sprint), _style);
    }
}