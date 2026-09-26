using UnityEngine;

public class XRBridge : MonoBehaviour
{
    public Transform arCamera;

    [System.Serializable]
    public class PoseData
    {
        public float px;
        public float py;
        public float pz;

        public float qx;
        public float qy;
        public float qz;
        public float qw;

        public string status;
    }

    public void SetCameraPose(string json)
    {
        PoseData pose = JsonUtility.FromJson<PoseData>(json);

        arCamera.localPosition = new Vector3(
            pose.px,
            pose.py,
            pose.pz
        );

        arCamera.localRotation = new Quaternion(
            pose.qx,
            pose.qy,
            pose.qz,
            pose.qw
        );
    }
}