using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using monogame_cros_platform.classes;

namespace proof_of_concept_find_shape.classes
{
    public class TilePoints
    {
        public Vector2 position;
        public Vector2[] points;
        public TilePoints() {}
        public TilePoints(Vector2 _position, Vector2[] _points) {
            position = _position;
            points = new Vector2[_points.Length];
            for (int i = 0; i < _points.Length; i++)
            {
                points[i] = _position + _points[i];
            }
        }

        public static TilePoints midphase(TilePoints a, TilePoints b, float percentage)
        {
            TilePoints tp = new TilePoints();
            tp.position = Helper.midphase(a.position, b.position, percentage);
            tp.points = Helper.midphase(a.points, b.points, percentage);
            return tp;
        }

        public static TilePoints operator+(TilePoints points, Vector2 v2)
        {
            TilePoints tp = new TilePoints();
            tp.position = points.position + v2;
            tp.points = new Vector2[points.points.Length];
            for (int i = 0;i < points.points.Length; i++)
            {
                tp.points[i] = points.points[i] + v2;
            }
            return tp;
        }

        public static TilePoints operator *(TilePoints points, float c)
        {
            TilePoints tp = new TilePoints();
            tp.position = points.position * c;
            tp.points = new Vector2[points.points.Length];
            for (int i = 0; i < points.points.Length; i++)
            {
                tp.points[i] = points.points[i] * c;
            }
            return tp;
        }
    }
}
