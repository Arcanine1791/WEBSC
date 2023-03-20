using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebXR;

namespace BNG {
    public class WebXRInputProvider : MonoBehaviour {

        public WebXRController LeftController;
        public WebXRController RightController;

        void OnEnable() {
            // Subscribe to input events
            InputBridge.OnInputsUpdated += UpdateInputs;
        }

        void OnDisable() {
            // Unsubscribe from input events
            InputBridge.OnInputsUpdated -= UpdateInputs;
        }

        public virtual void UpdateInputs() {
            // Override InputBridge inputs using WebXR API here
            InputBridge.Instance.HMDActive = LeftController != null && (LeftController.isControllerActive || LeftController.isHandActive);

            InputBridge.Instance.LeftTrigger = GetLeftTrigger();
            InputBridge.Instance.RightTrigger = GetRightTrigger();

            InputBridge.Instance.LeftGrip = GetLeftGrip();
            InputBridge.Instance.RightGrip = GetRightGrip();

            InputBridge.Instance.LeftThumbstickAxis = GetLeftThumbstickAxis();
            InputBridge.Instance.RightThumbstickAxis = GetRightThumbstickAxis();

            InputBridge.Instance.AButton = GetAButton();
            InputBridge.Instance.BButton = GetBButton();
            InputBridge.Instance.XButton = GetXButton();
            InputBridge.Instance.YButton = GetYButton();

            InputBridge.Instance.SupportsIndexTouch = false;
            InputBridge.Instance.SupportsThumbTouch = false;
        }

        public Vector3 GetLeftThumbstickAxis() {
            if (LeftController != null && LeftController.isControllerActive) {
                return LeftController.GetAxis2D(WebXRController.Axis2DTypes.Thumbstick);
            }

            return Vector3.zero;
        }

        public Vector2 GetRightThumbstickAxis() {
            if (RightController != null && RightController.isControllerActive) {
                return RightController.GetAxis2D(WebXRController.Axis2DTypes.Thumbstick);
            }

            return Vector2.zero;
        }

        public float GetRightTrigger() {
            if (RightController != null && RightController.isControllerActive) {
                return RightController.GetAxis(WebXRController.AxisTypes.Trigger);
            }

            return 0;
        }

        public float GetLeftTrigger() {
            if (LeftController != null && LeftController.isControllerActive) {
                return LeftController.GetAxis(WebXRController.AxisTypes.Trigger);
            }

            return 0;
        }

        public float GetLeftGrip() {
            if (LeftController != null && LeftController.isControllerActive) {
                return LeftController.GetAxis(WebXRController.AxisTypes.Grip);
            }

            return 0;
        }

        public float GetRightGrip() {
            if (RightController != null && RightController.isControllerActive) {
                return RightController.GetAxis(WebXRController.AxisTypes.Grip);
            }

            return 0;
        }

        public bool GetAButton() {
            if (RightController != null && RightController.isControllerActive) {
                return RightController.GetButton(WebXRController.ButtonTypes.ButtonA);
            }

            return false;
        }

        public bool GetBButton() {
            if (RightController != null && RightController.isControllerActive) {
                return RightController.GetButton(WebXRController.ButtonTypes.ButtonB);
            }

            return false;
        }

        public bool GetXButton() {
            if (LeftController != null && LeftController.isControllerActive) {
                return LeftController.GetButton(WebXRController.ButtonTypes.ButtonA);
            }

            return false;
        }

        public bool GetYButton() {
            if (LeftController != null && LeftController.isControllerActive) {
                return LeftController.GetButton(WebXRController.ButtonTypes.ButtonB);
            }

            return false;
        }
    }
}