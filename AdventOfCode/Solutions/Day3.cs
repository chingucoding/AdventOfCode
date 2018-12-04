﻿using System;
using AdventOfCode.Utils;

namespace AdventOfCode.Solutions {
  public class Day3 {
    public static Rectangle[] convert(String[] data) {
      //Data  
      //#1 @ 236,827: 24x17
      Rectangle[] rects = new Rectangle[data.Length];
      for (int i = 0; i < data.Length; i++) {
        string modified = data[i].Split('@')[1];
        modified = modified.Replace(':', ',');
        modified = modified.Replace('x', ',');

        string[] splitString = modified.Split(',');
        int[] values = ConverterUtils.getNumbers(splitString);
        rects[i] = new Rectangle(values[0], values[1], values[2], values[3], data[i]);

      }

      return rects;
    }

    public static int firstProblem(Rectangle[] data) {
      int[][] values = new int[1000][];

      for (int i = 0; i < 1000; i++) {
        values[i] = new int[1000];
      }

      for (int index = 0; index < data.Length; index++) {
        Rectangle current = data[index];
        for (int i = current.x; i < current.x + current.width; i++) {
          for (int j = current.y; j < current.y + current.height; j++) {
            if (values[i][j] != 0) {
              values[i][j] = -1;
            }
            else {
              values[i][j] = 1;
            }
          }
        }


      }


      int sum = 0;
      for (int i = 0; i < 1000; i++) {
        for (int j = 00; j < 1000; j++) {
          if (values[i][j] == -1) {
            sum++;
          }
        }
      }
      return sum;
    }

    public static String secondProblem(Rectangle[] data) {
      int[][] values = new int[1000][];

      for (int i = 0; i < 1000; i++) {
        values[i] = new int[1000];
      }

      //Writing stuff
      for (int index = 0; index < data.Length; index++) {
        Rectangle current = data[index];
        for (int i = current.x; i < current.x + current.width; i++) {
          for (int j = current.y; j < current.y + current.height; j++) {
            if (values[i][j] != 0) {
              values[i][j] = -1;
            }
            else {
              values[i][j] = 1;
            }
          }
        }
      }

      //Finding rect that was not modified
      Rectangle intact = new Rectangle(0, 0, 0, 0, "Null");
      for (int index = 0; index < data.Length; index++) {
        Rectangle current = data[index];
        bool damaged = false;
        for (int i = current.x; i < current.x + current.width; i++) {
          for (int j = current.y; j < current.y + current.height; j++) {
            if (values[i][j] == -1) {
              damaged = true; ;
            }
          }
        }
        if (!damaged) {
          intact = data[index];
        }
      }
      return intact.rootData;
    }

  }
}