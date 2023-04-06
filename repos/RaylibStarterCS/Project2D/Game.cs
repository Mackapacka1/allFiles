using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;

namespace Project2D
{
    class Game
    {
        Stopwatch stopwatch = new Stopwatch();

        private long currentTime = 0;
        private long lastTime = 0;
        private float timer = 0;
        private int fps = 1;
        private int frames;

        private float deltaTime = 0.005f;
        Vector position = new Vector();
        Vector enemyPosition = new Vector();
        public bool isAlive;
        


       public Image logo;
       public Image image;
       public Texture2D texture;
       public Texture2D death;

        public Game()
        {
        }

        public void Init()
        {

            isAlive = true;
            position.x = GetScreenWidth()/2;
            position.y = GetScreenHeight()/2;
            texture.width = 5;
            texture.height = 5;
            enemyPosition.x = 10;
            enemyPosition.y = GetScreenWidth()/2;


            stopwatch.Start();
            lastTime = stopwatch.ElapsedMilliseconds;

            if (Stopwatch.IsHighResolution)
            {
                Console.WriteLine("Stopwatch high-resolution frequency: {0} ticks per second", Stopwatch.Frequency);
            }

            //logo = LoadImage("..\\Images\\aie-logo-dark.jpg");
            //logo = LoadImage(@"..\Images\aie-logo-dark.jpg");
            logo = LoadImage("../Images/aie-logo-dark.jpg");
            texture = LoadTextureFromImage(logo);
            image = LoadImage("../Images/download.png");
            death = LoadTextureFromImage(image);
        }


        public void Shutdown()
        {
        }

        public void Update()
        {
            lastTime = currentTime;
            currentTime = stopwatch.ElapsedMilliseconds;
            deltaTime = (currentTime - lastTime) / 1000.0f;
            timer += deltaTime;
            if (timer >= 1)
            {
                fps = frames;
                frames = 0;
                timer -= 1;
            }
            frames++;

            // insert game logic here
            // 
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                position.x += 20 * deltaTime;
            }
            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                position.y -= 20 * deltaTime;
            }
            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                position.x -= 20 * deltaTime;
            }
            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                position.y += 20 * deltaTime;
            }

            

            if (enemyPosition.x <= position.x + texture.width && 
                enemyPosition.y <= position.y + texture.height && 
                enemyPosition.x >= position.x - texture.width && 
                enemyPosition.y >= position.y - texture.height)
            {
                isAlive = false;
            }


            

        }

        private void CheckCollisionBoxes(Vector position, Vector enemyPosition)
        {
            throw new NotImplementedException();
        }

        public void Draw()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);

            DrawText(fps.ToString(), 10, 10, 14, Color.RED);
            DrawTexture(texture,
            (int)enemyPosition.x, (int)enemyPosition.y, Color.RED);

            DrawTexture(texture, 
               (int) position.x, (int) position.y, Color.WHITE);
            if (!isAlive)
            {
                DrawText("is ded", 10, 10, 14, Color.RED);
            }

            EndDrawing();
        }
        public void DrawDeath()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);

            image = LoadImage("../Images/download.png");
            death = LoadTextureFromImage(image);
           
            DrawTexture(death,
              (int)position.x, (int)position.y, Color.WHITE);

            EndDrawing();
        }

    }
}
