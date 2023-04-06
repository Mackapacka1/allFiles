using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace tonk
{
    class Game
    {
        Stopwatch stopwatch = new Stopwatch();



        SceneObject tankObject = new SceneObject();
        SceneObject turretObject = new SceneObject();
        SceneObject bulletObject = new SceneObject();

        SpriteObject tankSprite = new SpriteObject();
        SpriteObject turretSprite = new SpriteObject();
        SpriteObject bulletSprite = new SpriteObject();

        public bool isAlive;



        private long currentTime = 0;
        private long lastTime = 0;
        private float timer = 0;
        private int fps = 1;
        private int frames;
        public Vector3 facing = new Vector3();
        private float deltaTime = 0.005f;
        Matrix3 rotate;
        public void Init()
        {
            stopwatch.Start();
            lastTime = stopwatch.ElapsedMilliseconds;
            
            isAlive = true;
            Vector3 whereTho = new Vector3();
            Console.WriteLine(whereTho.x + " " + whereTho.y);
            tankSprite.Load("../Images/tankBody_red_outline.png");
            bulletSprite.Load("../Images/bulletSand3.png");
            turretSprite.Load("../Images/specialBarrel1_outline.png");


            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));

            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height /2.0f);
            turretSprite.SetPosition(0, turretSprite.Width / 2.0f);
            tankObject.SetPosition(GetScreenWidth() / 2.0f, GetScreenHeight() / 2.0f);


            
            turretObject.AddChild(turretSprite);

            tankObject.AddChild(tankSprite);
            tankObject.AddChild(turretObject);







        }



        public void Shutdown()
        {
        }

        public void Update()
        {
            Console.WriteLine(bulletObject.LocalTransform.m20 + " " + bulletObject.LocalTransform.m21);
            Console.WriteLine(bulletObject.LocalTransform.m00 + " " + bulletObject.LocalTransform.m01);
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
            tankObject.Update(deltaTime);
            lastTime = currentTime;

            if (IsKeyDown(KeyboardKey.KEY_A))
            {
                tankObject.Rotate(-deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_D))
            {
                tankObject.Rotate(deltaTime);
            }
            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                

                Vector3 facing = new Vector3(
                tankObject.LocalTransform.m00,
                tankObject.LocalTransform.m01, 1) * deltaTime * 100;
                tankObject.Translate(facing.x, facing.y);

            }
            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                Vector3 facing = new Vector3(
                tankObject.LocalTransform.m00,
                tankObject.LocalTransform.m01, 1) * deltaTime * -100;
                tankObject.Translate(facing.x, facing.y);




            }
            tankObject.Update(deltaTime);
            if (IsKeyDown(KeyboardKey.KEY_Q))
            {
                turretObject.Rotate(-deltaTime);
                rotate = turretObject.LocalTransform;
            }
            if (IsKeyDown(KeyboardKey.KEY_E))
            {
                turretObject.Rotate(deltaTime);
                rotate = turretObject.LocalTransform;
            }
            tankObject.Update(deltaTime);
            lastTime = currentTime;

            if (IsKeyPressed(KeyboardKey.KEY_SPACE))
            {

                drawBullet();
            }
           

        }
        public void drawBullet()
        {


            bulletSprite.SetPosition(turretObject.GlobalTransform.m20, turretObject.GlobalTransform.m21);
            bulletObject.SetPosition(turretObject.GlobalTransform.m20, turretObject.GlobalTransform.m21);
            bulletObject.SetRotate(rotate);
            bulletSprite.Draw();
            bulletObject.Draw();



            while (
              bulletObject.GlobalTransform.m00 < GetScreenWidth() / 2 &&
              bulletObject.GlobalTransform.m00 > -GetScreenWidth() / 2 &&
              bulletObject.GlobalTransform.m01 < GetScreenHeight() / 2 &&
              bulletObject.GlobalTransform.m01 > GetScreenHeight() / 2)
            {
                //bulletObject.LocalTransform.m20 = 

                bulletObject.Translate(facing.x, facing.y);

            

            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; i < 50; i++)
                {
                    bulletSprite.Load("../Images/bulletSand3.png");
                    turretSprite.Load("../Images/specialBarrel1_outline.png");
                    b
                }
            }
        }


        public void Draw()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);
            DrawText(fps.ToString(), 10, 10, 12, Color.RED);

            tankObject.Draw();
                


            EndDrawing();
        }



    }
}
