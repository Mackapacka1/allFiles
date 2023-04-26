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
        private float deltaTime = 0.005f;
        public void Init()
        {
            stopwatch.Start();
            lastTime = stopwatch.ElapsedMilliseconds;
            
            isAlive = true;

            tankSprite.Load("../Images/tankBody_red_outline.png");
            bulletSprite.Load("../Images/bulletSand3.png");
            turretSprite.Load("../Images/specialBarrel1_outline.png");


            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));

            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height /2.0f);
            turretSprite.SetPosition(0, turretSprite.Width / 2.0f);
            

            bulletSprite.SetPosition(bulletSprite.Width * 0.5f, bulletSprite.Height * 0.5f);
            //bulletObject.AddChild(bulletSprite);
            turretObject.AddChild(turretSprite);

            tankObject.AddChild(tankSprite);
            tankObject.AddChild(turretObject);

            tankObject.SetPosition(GetScreenWidth() / 2.0f, GetScreenHeight() / 2.0f);

        }



        public void Shutdown()
        {
        }

        public void Update()
        {
            //Console.WriteLine(tankObject.GlobalTransform.m20 + " " + tankObject.GlobalTransform.m21);
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

            }
            if (IsKeyDown(KeyboardKey.KEY_E))
            {
                turretObject.Rotate(deltaTime);

            }
            tankObject.Update(deltaTime);
            lastTime = currentTime;

            if (IsKeyPressed(KeyboardKey.KEY_SPACE))
            {

                SpawnBullet();
            }

            bulletObject.Update(deltaTime);
            MoveBullet();

        }
        public void SpawnBullet()
        {
            bulletObject.AddChild(bulletSprite);
            float rotation = (float)Math.Atan2(turretObject.GlobalTransform.m11,
            turretObject.GlobalTransform.m10);
            bulletObject.SetRotate(rotation);
            bulletObject.SetPosition(turretObject.GlobalTransform.m20, turretObject.GlobalTransform.m21);
        }

        public void MoveBullet()
        {

            

            if (
              bulletObject.GlobalTransform.m20 > 0 &&
              bulletObject.GlobalTransform.m20 < GetScreenWidth() &&
              bulletObject.GlobalTransform.m21 > 0 &&
              bulletObject.GlobalTransform.m21 < GetScreenHeight())
            {
                Vector3 facing = new Vector3(
                    bulletObject.LocalTransform.m10,
                    bulletObject.LocalTransform.m11, 1) * deltaTime * -400;
                bulletObject.Translate(facing.x, facing.y);
            }
            else
            {
                bulletObject.RemoveChild(bulletSprite);
            }
            
        }


        public void Draw()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);
            DrawText(fps.ToString(), 10, 10, 12, Color.RED);

            tankObject.Draw();
            bulletObject.Draw();
                


            EndDrawing();
        }



    }
}
