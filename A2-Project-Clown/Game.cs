// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Color color = Random.Color();

        Color NoseColor = new Color(250,0,0);
        Color HairColor = new Color(0, 250, 250);

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Meet Mr Chuckles!");
            Window.SetSize(600,600);
            Draw.SetLineSize(5);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(240);
            Draw.SetLineSize(0);

            //Hair
            Draw.SetFillColor(HairColor);
            Draw.Circle(300, 210, 255);


            //Head
            Draw.SetFillColor(255,255,255);
            Draw.Circle(300,300,200);

            //Bangs
            Draw.SetFillColor(HairColor);
            Draw.Circle(300,140,70);
            Draw.Circle(80, 360,35);
            Draw.Circle(580, 260, 45);
            Draw.Circle(450, 160, 30);
            Draw.Circle(100, 178, 90);
            Draw.Circle(520, 70, 50);

            //Eyes
            Draw.SetFillColor(0,0,0);
            Draw.Circle(230,250,35);
            Draw.Circle(365,250,35);

            //Keyboard Input???? For Expression change




            //Nose
            Draw.SetFillColor(NoseColor);
            Draw.Circle(300, 340, 50);



            //Mouse Input for Nose Interraction

            if (Input.IsMouseButtonPressed(MouseButton.Left) == true)
            {
                NoseColor = Random.Color();
            }


            //Mouse Input for Hair Color

            if (Input.IsMouseButtonPressed(MouseButton.Left) == true)
            {
                HairColor = Random.Color();
            }
        }



    }

}
