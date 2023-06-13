using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AdventureGame
{
    public class Room
    {
        protected GameObject[] objects = new GameObject[3];
        public void AddGameObject(GameObject go)
        {
            for (int i = 0; i < 3; i++)
            {
                if (objects[i] == null)
                {

                    objects[i] = go;

                }
            }

        }

        public void Draw()
        {
            if (objects[0] == null)
            {
                Console.Write("_");
            }
            else
            {
                objects[0].Draw();
            }
        }
        public void RemoveGameObject(GameObject go)
        {
            for (int i = 0; i < 3; i++)
            {

                if (objects[i] == go)
                {

                    objects[i] = null;

                    switch (i)
                    {

                        case 1:
                            objects[0] = null;
                            objects[0] = objects[1];
                            objects[1] = objects[2];
                            objects[2] = null;

                            break;
                        case 2:
                            objects[1] = objects[2];
                            objects[2] = null;

                            break;
                        default:
                            objects[2] = null;

                            break;

                    }

                }

            }





        }
    }


}

