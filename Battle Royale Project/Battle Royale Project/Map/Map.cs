﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Royale_Project
{
    public class Map
    {
        public static Rectangle Rectangle;
        public List<Item> Items;
        private ContentManager content;
        private Random Random;

        public Map(Rectangle mapRectangle, ContentManager contentManager)
        {
            content = contentManager;

            Rectangle = new Rectangle(mapRectangle.X,
                                      mapRectangle.Y,
                                      mapRectangle.Width,
                                      mapRectangle.Height);


            Random = new Random();
            Items = new List<Item>();

        }

        public void AddItem(ItemCategory itemToAdd)
        {
            Item item;

            switch (itemToAdd)
            {
                case ItemCategory.Ammo:
                    item = new GunAmmo(GeneratePosition(), GenerateAmmo());
                    item.LoadContent(content);
                    Items.Add(item);
                    break;
                case ItemCategory.Food:
                    item = new Food(GeneratePosition(), GenerateFood());
                    item.LoadContent(content);
                    Items.Add(item);
                    break;
                case ItemCategory.Shield:
                    item = new Shield(GeneratePosition(), GenerateShield());
                    item.LoadContent(content);
                    Items.Add(item);
                    break;
                case ItemCategory.Helmet:
                    item = new Helmet(GeneratePosition(), GenerateHelmet());
                    item.LoadContent(content);
                    Items.Add(item);
                    break;
            }
        }

        public FoodType GenerateFood() { return (FoodType)(Random.Next(3)); }

        public ShieldType GenerateShield() {
 
            int Number = Random.Next(71);

            if (Number >= 0 && Number <= 10)
                return ShieldType.Shield_Level_1;
            else if (Number >= 11 && Number <= 20)
                return ShieldType.Shield_Level_2;
            else if (Number >= 21 && Number <= 30)
                return ShieldType.Shield_Rare;
            else
                return ShieldType.Shield_Legendery;
        }
        public HelmetType GenerateHelmet() { return (HelmetType)(Random.Next(4)); }
        public AmmoType GenerateAmmo() { return (AmmoType)(Random.Next(1,2)); }

        public Vector2 GeneratePosition()
        {
            return new Vector2(Random.Next(200, Rectangle.Width - 200), Random.Next(200, Rectangle.Height - 200));
        }
    }
}
