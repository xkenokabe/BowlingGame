﻿// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace BowlingGame
{
    public class Game
    {
        int[] itsThrows = new int[21];
        int itsCurrentThrow = 0;

        public int Score
        {
            get;
            private set;
        } = 0;

        public void Add(int pins)
        {
            itsThrows[itsCurrentThrow++] = pins;
            Score += pins;
        }

        public int ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;
            for (int currentFrame = 0;
                 currentFrame < theFrame;
                 ++currentFrame)
                score += itsThrows[ball++] + itsThrows[ball++];

            return score;
        }
    }
}
