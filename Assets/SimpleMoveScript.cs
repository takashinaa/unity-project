using UnityEngine;
using System.Collections;

public class SimpleMoveScript : MonoBehaviour {
  
   public    float speed=0.5f;
   
   // Use this for initialization
   void Start () {
   
   }
   
   // Update is called once per frame
   void Update () {
       transform.Translate(Input.GetAxis("Horizontal")*speed,0,Input.GetAxis("Vertical")*speed);
   }
}
