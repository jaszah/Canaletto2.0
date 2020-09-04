using UnityEngine;
using System.Collections;

namespace Com.LuisPedroFonseca.ProCamera2D
{

    public class ZoomButtons : MonoBehaviour
    {
        [Range(0.1f, 179.9f)]
        public float TargetFOV = 30f;

        [Range(0f, 10f)]
        public float Duration = 2f;

        public EaseType EaseType;

        [Range(-1f, 1f)]
        public float ZoomAmount = -.2f;

        public GameObject ZoomInButton;
        public GameObject ZoomOutButton;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (ZoomInButton.GetComponent<joybutton>().Pressed == true)
            {
                ProCamera2D.Instance.DollyZoom(TargetFOV, Duration, EaseType);
                ProCamera2D.Instance.Zoom(ZoomAmount, Duration, EaseType);
            }
        }
    }
}