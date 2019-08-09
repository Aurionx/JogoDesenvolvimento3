using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{

   public AudioSource[] audio = new AudioSource[2];


   // Use this for initialization
   void Start()
   {

   }



   private void Update()
   {
   }

   private void FixedUpdate()
   {
      

   }


   public void iniciarJogo()
   {
      SceneManager.LoadScene("Jogo");
   }

   public void fecharJogo()
   {
      Application.Quit();
   }

}
