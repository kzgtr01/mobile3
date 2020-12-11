using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallControlScript : MonoBehaviour
{
    //Reference to rigidbody2d component of the ball game object
    Rigidbody2D rb;

    //range value so moveSpeedModifier can be mod in inspector
    [Range(.2f,2f)]
    public float moveSpeedModifier = .5f;

    //direction var that read acceleration input to be add
    //as velocity to Rigidbody2d component
    float dirX, dirY;

    //ref to ball animator component to control animation transition
    Animator anim;

    //setting bool var that ball is alive at the beningging
   static bool isDead;

   //var to allow or disallow movement when ball is alive or dead
   static bool moveAllowed;

   //var to be set to true if you win
   static bool youWin;

   //ref to WinText game object to control its appearance
   // text game object can be added on inspector because of [serializefield] line
   [SerializeField]
   GameObject winText;

   //use this for initialization
   void Start (){

       //turn wintext off at the start
       winText.gameObject.SetActive(false);

       //you dont win at the start
       youWin=false;

       //movement is allowed at the start
       moveAllowed = true;

       //ball is alive at the start
       isDead = false;

       //Getting rigidbody2d component of the ball game object
       rb=GetComponent<Rigidbody2D> ();

       //getting animator component of the ball game object
       anim = GetComponent<Animator> ();

       //set BallAlive animation
       anim.SetBool ("BallDead", isDead);
   }

   // Update is called once per frame
   void Update () {

       //getting devices accelerometer data in X and Y direction
       //multiplied by move speed modifier
       dirX = Input.acceleration.x * moveSpeedModifier;
       dirY = Input.acceleration.y * moveSpeedModifier;

       // if isDead is true
       if (isDead) {

           //then ball movement is stopped
           rb.velocity = new Vector2 (0, 0);

           //ball movement is not allowed anymore
           moveAllowed = false;

           //switch to Ball Dead Animation so ball falls into exit hole
           anim.SetBool("BallDead", true);

           //Restart scene to play again in 2 secs
           Invoke ("RestartScene", 2f);
       }
   }

   void FixedUpdate()
   {
       //setting a velocity to rigidbody2d component according to accelerometer data
       if (moveAllowed)
       rb.velocity = new Vector2 (rb.velocity.x + dirX, rb.velocity.y + dirY);
   }
   
   //method is invoke by deathholescript when ball touches deathHole collider
   public static void setIsDeadTrue(){
       //setting isDead to true
       isDead = true;
   }

   //method invoked by exithole game object when ball touches its collider
   public static void setYouWinToTrue(){
       youWin = true;
   }

   //method to restart scene
   void RestartScene(){
       SceneManager.LoadScene("RB1");
   }
}


