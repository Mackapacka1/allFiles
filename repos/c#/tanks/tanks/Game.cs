﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Raylib;
using static Raylib.Raylib;
using Microsoft.VisualBasic;

using System.Runtime.CompilerServices;
using Raylib;

namespace tanks
{
     class Game
    {




        SceneObject tankObject = new SceneObject();
        SceneObject turretObject = new SceneObject();

        SpriteObject tankSprite = new SpriteObject();
        SpriteObject turretSprite = new SpriteObject();

        Stopwatch stopwatch = new Stopwatch();

        private long currentTime = 0;
        private long lastTime = 0;

      
        private float timer = 0;
        private int fps = 1;
        private int frames;

        private float deltaTime = 0.005f;

        public void Init()
        {

            tankSprite.Load("tankBlue_outline.png");
            // sprite is facing the wrong way... fix that here  
            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            // sets an offset for the base, so it rotates around the centre 
            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height /
2.0f);

            turretSprite.Load("barrelBlue.png");
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            // set the turret offset from the tank base 
            turretSprite.SetPosition(0, turretSprite.Width / 2.0f);

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

        }


        public void Draw()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);
            DrawText(fps.ToString(), 10, 10, 12, Color.RED);
            tankObject.Draw();

            EndDrawing();
        }
        //Stopwatch stopwatch = new Stopwatch();

        //private long currentTime = 0;
        //private long lastTime = 0;
        //private float timer = 0;
        //private int fps = 1;
        //private int frames;

        //private float deltaTime = 0.005f;
        //Vector3 position = new Vector3();
        //Vector3 enemyPosition = new Vector3();
        //public bool isAlive;

        //SceneObject tankObject = new SceneObject();
        //SceneObject turretObject = new SceneObject();

        //SpriteObject tankSprite = new SpriteObject();
        //SpriteObject turretSprite = new SpriteObject();




        //public void Init()
        //{
        //    isAlive = true;
        //    position.x = GetScreenWidth() / 2;
        //    position.y = GetScreenHeight() / 2;
        //    texture.width = 5;
        //    texture.height = 5;
        //    enemyPosition.x = 10;
        //    enemyPosition.y = GetScreenWidth() / 2;



        //    stopwatch.Start();
        //    lastTime = stopwatch.ElapsedMilliseconds;

        //    if (Stopwatch.IsHighResolution)
        //    {
        //        Console.WriteLine("Stopwatch high-resolution frequency: {0} ticks per second", Stopwatch.Frequency);
        //    }

        //    tankSprite.Load("tankBody_blue_outline.png");
        //    // sprite is facing the wrong way... fix that here  
        //    tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
        //    // sets an offset for the base, so it rotates around the centre 
        //    tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height / 2.0f);
        //}
        //public void Update(float deltaTime)
        //{
        //    // run OnUpdate behaviour 
        //    OnUpdate(deltaTime);

        //    // update children 
        //    foreach (SceneObject child in children)
        //    {
        //        child.Update(deltaTime);
        //    }
        //    if (enemyPosition.x <= position.x + texture.width &&
        //     enemyPosition.y <= position.y + texture.height &&
        //     enemyPosition.x >= position.x - texture.width &&
        //     enemyPosition.y >= position.y - texture.height)
        //    {
        //        isAlive = false;
        //    }
        //}



        //public void Draw()
        //{
        //    BeginDrawing();

        //    ClearBackground(Colour.WHITE);
        //    DrawText(fps.ToString(), 10, 10, 12, Colour.RED);

        //    EndDrawing();
        //}
        //public void DrawDeath()
        //{

        //}
        //public void Shutdown()
        //{

        //}



    }
}
