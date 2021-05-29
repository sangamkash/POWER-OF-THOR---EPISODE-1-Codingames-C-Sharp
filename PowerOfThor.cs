using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position
        var x=initialTx;
        var y=initialTy;
        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            
            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            var tx=lightX-x;
            var dx=tx==0?"":tx>0?"E":"W";
            var ty=lightY-y;
            var dy=ty==0?"":ty>0?"S":"N";
            var output=dy+dx;
            var ox=0;
            var oy=0;
            switch(output)
            {
                case "N":
                ox=0;
                oy=-1;
                break;
                case "NE":
                ox=1;
                oy=-1;
                break;
                case "E":
                ox=1;
                oy=0;
                break;
                case "SE":
                ox=1;
                oy=1;
                break;
                case "S":
                ox=0;
                oy=1;
                break;
                case "SW":
                ox=-1;
                oy=1;
                break;
                case "W":
                ox=-1;
                oy=0;
                break;
                case "NW":
                ox=1;
                oy=-1;
                break;
            }
            x+=ox;
            y+=oy;
            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(output);
            
        }
    }
}
