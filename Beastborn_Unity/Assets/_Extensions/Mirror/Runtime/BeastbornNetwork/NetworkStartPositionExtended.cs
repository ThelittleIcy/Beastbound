using UnityEngine;

namespace BeastbornNetwork
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Network/NetworkStartPositionExtended")]
    class NetworkStartPositionExtended : MonoBehaviour
    {
        public void Awake()
        {
            //Debug.Log($"Register {this.transform.name}");
            NetworkManagerExtended.RegisterStartPosition(transform);
        }

        public void OnDestroy()
        {
            NetworkManagerExtended.UnRegisterStartPosition(transform);
        }
    }
}
