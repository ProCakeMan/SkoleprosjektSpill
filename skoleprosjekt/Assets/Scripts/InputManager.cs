using UnityEngine;

public class InputManager : MonoBehaviour{


    MyControl controls;
    MyControl.GroundMovementActions groundMovement;


    private void Awake() {
        controls = new MyControl();
        groundMovement = controls.GroundMovement;
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }
}
