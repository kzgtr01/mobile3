  using UnityEngine;
  using System.Collections;
  using UnityEngine.SceneManagement;
  
  public class gm : MonoBehaviour 
  {
      public void AH()
      {
          SceneManager.LoadScene("AH1");
      }

      public void RB()
      {
          SceneManager.LoadScene("RB1");
      }

      public void CM()
      {
          SceneManager.LoadScene("CM1");
      }
  
  }