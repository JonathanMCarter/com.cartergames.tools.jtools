using UnityEngine;


namespace JTools
{
    /// <summary>
    /// Class | Rotate Script, rotates objects based on the inputted values.
    /// </summary>
    public class RotateScript : MonoBehaviour
    {
        /// <summary>
        /// Defines whether or not the X axis should be rotated.
        /// </summary>
        [Header("Which axis should be rotated?")]
        [Tooltip("Should the X axis be rotated?")]
        [SerializeField] private bool xAxis = false;

        /// <summary>
        /// Defines whether or not the Y axis should be rotated.
        /// </summary>
        [Tooltip("Should the Y axis be rotated?")]
        [SerializeField] private bool yAxis = false;

        /// <summary>
        /// Defines whether or not the Z axis should be rotated.
        /// </summary>
        [Tooltip("Should the Z axis be rotated?")]
        [SerializeField] private bool zAxis = false;

        /// <summary>
        /// Defines the speed that the object is rotated at.
        /// </summary>
        [Header("Rotation Speed.")]
        [Tooltip("The speed of which the object will rotated at.")]
        [SerializeField] private float speed = 1;

        /// <summary>
        /// Boolean that enables or disables the rotation of an object (also sets it to true as default)
        /// </summary>
        private bool shouldRotateObject = true;



        public bool IsRotating => shouldRotateObject;


        public float Speed
        {
            get => speed;
            set => speed = value;
        }
    


        private void FixedUpdate()
        {
            // Checks to see if the object should be rotated.
            if (shouldRotateObject)
            {
                // Rotates the object with whatever rotation selected at the desired speed (note there is not time.deltatime here so its small changes
                transform.Rotate(ConvertBool(xAxis) * speed, ConvertBool(yAxis) * speed, ConvertBool(zAxis) * speed);
            }
        }

        
        
        /// <summary>
        /// Converts boolean to int for use in the rotation.
        /// </summary>
        /// <param name="input">the inputted boolean value</param>
        /// <returns>an int value for the inputted boolean</returns>
        private int ConvertBool(bool input)
        {
            return input ? 1 : 0;;
        }

        
        /// <summary>
        /// Enables the rotation of the object this is attached to.
        /// </summary>
        public void EnableRotation()
        {
            shouldRotateObject = true;
        }

        
        /// <summary>
        /// Disables the rotation of the object this is attached to.
        /// </summary>
        public void DisableRotation()
        {
            shouldRotateObject = false;
        }


        /// <summary>
        /// Sets the rotation of the object to the inputted values.
        /// </summary>
        /// <param name="axis">Vector3 | axis to rotate on, 0 so no, 1 for yes, anything higher is ignored.</param>
        /// <param name="spd">Float | The speed that the rotation should be set to.</param>
        public void SetRotation(Vector3 axis, float spd)
        {
            if (axis.x >= 1)
                xAxis = true;
            else
                xAxis = false;

            if (axis.y >= 1)
                yAxis = true;
            else
                yAxis = false;

            if (axis.z >= 1)
                zAxis = true;
            else
                zAxis = false;

            speed = spd;
        }
    }
}