using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib;
using static Raylib.Raylib;




namespace tonk
{
    public class SpriteObject : SceneObject
    {

        Texture2D texture = new Texture2D();
        Image image = new Image();

        public float Width
        {
            get { return texture.width; }
        }

        public float Height
        {
            get { return texture.height; }
        }

        public SpriteObject()
        {
        }

        public void Load(string filename)
        {
            image = LoadImage(filename);
            texture = LoadTextureFromImage(image);
        }
        public override void OnDraw()
        {
            // local x-axis y and x get passed into Atan2
            float rotation = (float)Math.Atan2(globalTransform.m01,
            globalTransform.m00);

            DrawTextureEx(texture,
            new Vector2(globalTransform.m20, globalTransform.m21), 
         //translation x and y
            rotation * (float)(180.0f / Math.PI),
            1,
            Color.WHITE);
        }
    }
}
