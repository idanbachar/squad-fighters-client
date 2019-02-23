﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Battle_Royale_Project
{
    public abstract class Item
    {
        public Texture2D Texture;
        public Vector2 Position;
        public Rectangle Rectangle;

        public Item(Vector2 itemPosition)
        {
            Position = new Vector2(itemPosition.X, itemPosition.Y);
            Rectangle = new Rectangle((int)Position.X, (int)Position.Y, 0, 0);
        }

        public abstract void LoadContent(ContentManager content);
        public abstract void Update();
        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
