﻿using System;
using System.Collections.Generic;
using GetOut.Models;
using GetOut.Models.MapEntity;
using GetOut.Models.Monsters.Smart;
using GetOut.Models.Monsters.Stupid;
using Microsoft.Xna.Framework;

namespace GetOut.Controllers;

public static class LevelsEntitiesRegistry
{
    public static List<IEntityInterface> GetLevel1()
    {
        return new List<IEntityInterface>()
        {
            new MapPeaks(),
            new MapHealth(2),
            new PumpkinDude(new Vector2(37 * 16, 25 * 16), 1f, 30),
            new BigZombie(new Vector2(12 * 16, 51 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(10 * 16, 50 * 16), 5),
                new(new Point(10 * 16, 46 * 16), 0),
                new(new Point(22 * 16, 46 * 16), 0),
                new(new Point(22 * 16, 50 * 16), 5), //
                new(new Point(22 * 16, 46 * 16), 0),
                new(new Point(10 * 16, 46 * 16), 0),
            }),
            new BigOgre(new Vector2(23 * 16, 66 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(37 * 16, 66 * 16), 0),
                new(new Point(26 * 16, 66 * 16), 0)
            }),
            new BigDemon(new Vector2(57 * 16, 29 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(57 * 16, 29 * 16), 3),
                new(new Point(57 * 16, 33 * 16), 0),
                new(new Point(61 * 16, 33 * 16), 0),
                new(new Point(61 * 16, 25 * 16), 3), //
                new(new Point(61 * 16, 33 * 16), 0),
                new(new Point(57 * 16, 33 * 16), 0),
            }),
            new BigZombie(new Vector2(55 * 16, 79 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(66 * 16, 73 * 16), 7),
                new(new Point(74 * 16, 73 * 16), 3)
            })
        };
    }

    public static List<IEntityInterface> GetLevel2()
    {
        return new List<IEntityInterface>()
        {
            new MapPeaks(),
            new MapHealth(11),
            new BigZombie(new Vector2(2 * 16, 17 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(14 * 16, 17 * 16), 5),
                new(new Point(2 * 16, 17 * 16), 0)
            }, 3, 1.2f),
            new WarriorOrc(new Vector2(6 * 16, 21 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(14 * 16, 21 * 16), 0),
                new(new Point(14 * 16, 29 * 16), 0),
                new(new Point(14 * 16, 21 * 16), 0),
                new(new Point(6 * 16, 21 * 16), 3)
            }, 3, 1.3f),
            new Chort(new Vector2(8 * 16, 54 * 16), 1f, 10, 2),
            new BigDemon(new Vector2(10 * 16, 57 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(19 * 16, 57 * 16), 2),
                new(new Point(10 * 16, 57 * 16), 2)
            }),
            new BigOgre(new Vector2(22 * 16, 69 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(38 * 16, 69 * 16), 5),
                new(new Point(22 * 16, 69 * 16), 5)
            }, 3, 1.5f),
            new MaskedOrc(new Vector2(34 * 16, 41 * 16), 1.2f, 35, 1),
            new Slug(new Vector2(18 * 16, 38 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(18 * 16, 49 * 16), 0),
                new(new Point(18 * 16, 38 * 16), 0)
            }, 3, 0.5f),
            new Doc(new Vector2(42 * 16, 6 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(42 * 16, 14 * 16), 5),
                new(new Point(42 * 16, 6 * 16), 5)
            }),
            new Wogol(new Vector2(70 * 16, 6 * 16), 1.2f, 40, 2),
            new BigOgre(new Vector2(50 * 16, 57 * 16), new List<Tuple<Point, int>>()
            {
                new(new Point(70 * 16, 57 * 16), 7),
                new(new Point(50 * 16, 57 * 16), 7)
            }, 1, 1.5f)
        };
    }
}