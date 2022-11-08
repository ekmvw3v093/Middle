using UnityEngine;

namespace KID
{

    public class DamgeSystem : MonoBehaviour
    {
        [SerializeField, Header("爆炸欲置物")]
        private GameObject prefabExplosion;
        [SerializeField, Header("胖到會爆炸的名稱")]
        private string nameTarget;


      void OnTriggerEnter2D()
        {

        }




    }
}
